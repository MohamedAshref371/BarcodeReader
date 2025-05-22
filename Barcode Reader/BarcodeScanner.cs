using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;

namespace Barcode_Reader
{
    public class BarcodeScanner
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;

        private readonly BarcodeReader reader;

        public BarcodeScanner()
        {
            reader = new BarcodeReader();
        }

        public bool AutoRotate { set => reader.AutoRotate = value; }
        public bool TryInverted { set => reader.Options.TryInverted = value; }
        public bool TryHarder { set => reader.Options.TryHarder = value; }
        public bool DecodeMultiple = false;

        public string[] Init()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            return videoDevices.Cast<FilterInfo>().Select(f => f.Name).ToArray();
        }

        public string[] Ready(int camera, out int lowestQualitySettingIndex)
        {
            videoSource = new VideoCaptureDevice(videoDevices[camera].MonikerString);
            
            VideoCapabilities[] caps = videoSource.VideoCapabilities;
            lowestQualitySettingIndex = Enumerable.Range(0, caps.Length).OrderBy(i => caps[i].FrameSize.Width * caps[i].FrameSize.Height).FirstOrDefault();
            
            return caps.Select(cap => $"{cap.FrameSize.Width}x{cap.FrameSize.Height}   {cap.AverageFrameRate}fps").ToArray();
        }

        public void Start(int quality = 0)
        {
            videoSource.VideoResolution = videoSource.VideoCapabilities[quality];
            videoSource.NewFrame += Video_NewFrame;
            videoSource.Start();
        }

        private bool isProcessing = false;
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (isProcessing) return;
            isProcessing = true;

            copyFrame = (Bitmap)eventArgs.Frame.Clone();
            
            Task.Run(TaskRun);
        }

        Bitmap copyFrame;
        private async Task TaskRun()
        {
            try
            {
                if (DecodeMultiple)
                {
                    Result[] results = reader.DecodeMultiple(copyFrame);
                    if (results?.Length >= 2)
                    {
                        Form1.Form.MutiExecute(results);
                        await Task.Delay(1000);
                    }
                    else if (results?.Length == 1)
                        Form1.Form.Execute(results[0].Text);
                }
                else
                {
                    Result result = reader.Decode(copyFrame);
                    if (result != null)
                        Form1.Form.Execute(result.Text);
                }
            }
            catch { }
            finally
            {
                copyFrame.Dispose();
                await Task.Delay(125);
                isProcessing = false;
            }
        }

        public void Stop()
        {
            videoSource.NewFrame -= Video_NewFrame;
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }
    }
}

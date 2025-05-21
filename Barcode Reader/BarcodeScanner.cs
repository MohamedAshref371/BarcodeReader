using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Linq;
using System.Drawing;

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

        public string[] Init()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            return videoDevices.Cast<FilterInfo>().Select(f => f.Name).ToArray();
        }

        public string[] Ready(int camera, out int lowestQualitySettingIndex)
        {
            videoSource = new VideoCaptureDevice(videoDevices[camera].MonikerString);
            
            VideoCapabilities[] caps = videoSource.VideoCapabilities;
            lowestQualitySettingIndex = Enumerable.Range(0, caps.Length).OrderBy(i => caps[i].FrameSize.Width * caps[i].FrameSize.Height * caps[i].AverageFrameRate).FirstOrDefault();
            
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

            Bitmap frameCopy = (Bitmap)eventArgs.Frame.Clone();

            System.Threading.Tasks.Task.Run(() =>
            {
                try
                {
                    var result = reader.Decode(frameCopy);
                    if (result != null)
                        Form1.Form.Execute(result.Text);
                }
                catch { }
                finally
                {
                    frameCopy.Dispose();
                    System.Threading.Thread.Sleep(125);
                    isProcessing = false;
                }
            });
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

using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Linq;
using System.Drawing;
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

        public string[] Init()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            return videoDevices.Cast<FilterInfo>().Select(f => f.Name).ToArray();
        }

        public void Start(int i = 0)
        {
            videoSource = new VideoCaptureDevice(videoDevices[i].MonikerString);
            videoSource.Start();
        }

        public void Resume()
        {
            videoSource.NewFrame += Video_NewFrame;
        }

        private bool isProcessing = false;
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (isProcessing) return;
            isProcessing = true;

            Bitmap frameCopy = (Bitmap)eventArgs.Frame.Clone();

            Task.Run(() =>
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
                    isProcessing = false;
                }
            });
        }

        public void Pause()
        {
            videoSource.NewFrame -= Video_NewFrame;
        }

        public void Stop()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
        }
    }
}

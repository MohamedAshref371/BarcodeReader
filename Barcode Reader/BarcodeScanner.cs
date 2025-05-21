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
        private bool isScanning = false;

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
            isScanning = true;
        }

        private bool isProcessing = false;
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (!isScanning || isProcessing) return;
            isProcessing = true;

            try {
                using (Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone())
                {
                    Result result = reader.Decode(bitmap);
                    if (result != null)
                        Form1.Form.Execute(result.Text);
                }
            } catch { }

            isProcessing = false;
        }

        public void Pause()
        {
            isScanning = false;
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

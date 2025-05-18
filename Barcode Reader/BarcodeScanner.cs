using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Linq;
using Barcode_Reader;

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

    private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
    {
        if (!isScanning) return;
        var result = reader.Decode(eventArgs.Frame);

        if (result != null)
        {
            Pause();
            Form1.Form.Execute(result.Text);
        }
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
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Barcode_Reader
{
    public partial class Form1 : Form
    {
        BarcodeScanner scanner = new BarcodeScanner();
        InputSimulator sim = new InputSimulator();
        Timer timer = new Timer();
        public static Form1 Form;

        public Form1()
        {
            InitializeComponent();
            Form = this;

            timer.Interval = (int)time.Value;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                scanner.Resume();
            };
        }

        private void SetTimeBtn_Click(object sender, EventArgs e) => timer.Interval = (int)time.Value;

        private void CamerasBtn_Click(object sender, EventArgs e)
        {
            string[] arr = scanner.Init();

            cameras.Items.Clear();
            cameras.Items.AddRange(arr);
            cameras.SelectedIndex = 0;

            camerasBtn.Enabled = false;
            startBtn.Enabled = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            scanner.Start(cameras.SelectedIndex);
            scanner.Resume();

            startBtn.Enabled = false;
            stopBtn.Enabled = true;
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            scanner.Pause();
            scanner.Stop();

            stopBtn.Enabled = false;
            camerasBtn.Enabled = true;
        }

        public void Execute(string s)
        {
            Invoke(new Action(() => { Clipboard.Clear(); Clipboard.SetText(s); }));

            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

            if (audioPlay.Checked && System.IO.File.Exists("success.wav"))
                new System.Media.SoundPlayer("success.wav").Play();
            
            Invoke(new Action(() => timer.Start() ));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (stopBtn.Enabled)
                StopBtn_Click(null, null);
        }
    }
}

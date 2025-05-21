using System;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Barcode_Reader
{
    public partial class Form1 : Form
    {
        readonly BarcodeScanner scanner = new BarcodeScanner();
        readonly InputSimulator sim = new InputSimulator();
        readonly Timer timer = new Timer();
        public static Form1 Form;

        public Form1()
        {
            InitializeComponent();
            Form = this;

            timer.Interval = (int)time.Value;
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                oldText = "";
            };

            if (System.IO.File.Exists("success.wav"))
                wavFile = new System.Media.SoundPlayer("success.wav");
        }

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

        readonly System.Media.SoundPlayer wavFile = null;
        string oldText;
        public void Execute(string s)
        {
            if (s == oldText) return;
            oldText = s;

            Invoke(new Action(() => { Clipboard.Clear(); Clipboard.SetText(s); timer.Start(); }));

            sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

            if (AudioPlay && wavFile != null)
            {
                wavFile.Stop();
                wavFile.Play();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (stopBtn.Enabled)
                StopBtn_Click(null, null);
        }

        private void Time_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = (int)(time.Value * 1000);
        }

        bool CopyCheck = true;
        private void CopyCheck_CheckedChanged(object sender, EventArgs e)
        {
            CopyCheck = copyCheck.Checked;
            textBox1.Visible = !CopyCheck;
            
            if (!CopyCheck)
                pasteCheck.Checked = false;
        }

        bool PasteCheck = true;
        private void PasteCheck_CheckedChanged(object sender, EventArgs e)
        {
            PasteCheck = pasteCheck.Checked;
            if (PasteCheck)
                copyCheck.Checked = true;
            else
                enterCheck.Checked = false;
        }

        bool EnterCheck = true;
        private void EnterCheck_CheckedChanged(object sender, EventArgs e)
        {
            EnterCheck = enterCheck.Checked;
            if (EnterCheck)
                pasteCheck.Checked = true;
        }

        bool AudioPlay = true;
        private void AudioPlay_CheckedChanged(object sender, EventArgs e)
        {
            AudioPlay = audioPlay.Checked;
        }
    }
}

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

            Time_ValueChanged(null, null);
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
            cameras.Items.Clear();

            string[] arr = scanner.Init();
            if (arr.Length == 0)
            {
                MessageBox.Show("لا يوجد كاميرات");
                return;
            }

            cameras.Items.AddRange(arr);
            cameras.SelectedIndex = 0;

            cameras.Enabled = true;
        }

        private void Cameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!stopBtn.Enabled)
            {
                startBtn.Enabled = false;
                qualities.Items.Clear();
                qualities.Enabled = false;
                qualityBtn.Enabled = true;
            }
        }

        private void QualityBtn_Click(object sender, EventArgs e)
        {
            qualities.Items.Clear();
            string[] arr = scanner.Ready(cameras.SelectedIndex, out int idx);

            qualities.Items.AddRange(arr);
            qualities.SelectedIndex = idx;

            qualities.Enabled = true;
            qualityBtn.Enabled = false;
            startBtn.Enabled = true;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            scanner.Start(qualities.SelectedIndex);

            cameras.Enabled = false;
            qualities.Enabled = false;

            camerasBtn.Enabled = false;
            startBtn.Enabled = false;
            stopBtn.Enabled = true;
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            scanner.Stop();

            stopBtn.Enabled = false;
            camerasBtn.Enabled = true;
        }

        readonly System.Media.SoundPlayer wavFile = null;
        string oldText;
        bool isProcessing = false;
        public void Execute(string s)
        {
            if (isProcessing || s == oldText) return;
            isProcessing = true;
            oldText = s;

            if (CopyCheck)
            {
                Invoke(new Action(() => { Clipboard.Clear(); Clipboard.SetText(s); timer.Stop(); timer.Start(); }));

                if (PasteCheck) sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
                if (EnterCheck) sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            }
            else
                Invoke(new Action(() => { textBox1.Text = s; timer.Stop(); timer.Start(); }));

            if (AudioPlay && wavFile != null) { wavFile.Stop(); wavFile.Play(); }

            isProcessing = false;
        }

        public void MutiExecute(ZXing.Result[] arr)
        {
            if (isProcessing) return;
            isProcessing = true;

            foreach (ZXing.Result res in arr)
            {
                Invoke(new Action(() => { Clipboard.Clear(); Clipboard.SetText(res.Text); }));

                sim.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
                sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            }
            
            if (AudioPlay && wavFile != null) { wavFile.Stop(); wavFile.Play(); }

            isProcessing = false;
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
            else
                multiCheck.Checked = false;
        }

        bool AudioPlay = true;
        private void AudioPlay_CheckedChanged(object sender, EventArgs e)
        {
            AudioPlay = audioPlay.Checked;
        }

        private void RotateCheck_CheckedChanged(object sender, EventArgs e)
        {
            scanner.AutoRotate = rotateCheck.Checked;
        }

        private void InvertedCheck_CheckedChanged(object sender, EventArgs e)
        {
            scanner.TryInverted = invertedCheck.Checked;
        }

        private void NoiseCheck_CheckedChanged(object sender, EventArgs e)
        {
            scanner.TryHarder = noiseCheck.Checked;
        }

        bool MultiCheck = false;
        private void MultiCheck_CheckedChanged(object sender, EventArgs e)
        {
            MultiCheck = multiCheck.Checked;
            scanner.DecodeMultiple = MultiCheck;
            if (MultiCheck)
                enterCheck.Checked = true;
        }
    }
}

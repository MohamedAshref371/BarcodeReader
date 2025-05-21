namespace Barcode_Reader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startBtn = new System.Windows.Forms.Button();
            this.camerasBtn = new System.Windows.Forms.Button();
            this.cameras = new System.Windows.Forms.ComboBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.NumericUpDown();
            this.audioPlay = new System.Windows.Forms.CheckBox();
            this.enterCheck = new System.Windows.Forms.CheckBox();
            this.pasteCheck = new System.Windows.Forms.CheckBox();
            this.copyCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.time)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(166, 71);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 37);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "البدأ";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // camerasBtn
            // 
            this.camerasBtn.Location = new System.Drawing.Point(249, 21);
            this.camerasBtn.Name = "camerasBtn";
            this.camerasBtn.Size = new System.Drawing.Size(75, 37);
            this.camerasBtn.TabIndex = 1;
            this.camerasBtn.Text = "الكاميرات";
            this.camerasBtn.UseVisualStyleBackColor = true;
            this.camerasBtn.Click += new System.EventHandler(this.CamerasBtn_Click);
            // 
            // cameras
            // 
            this.cameras.FormattingEnabled = true;
            this.cameras.Location = new System.Drawing.Point(19, 30);
            this.cameras.Name = "cameras";
            this.cameras.Size = new System.Drawing.Size(224, 21);
            this.cameras.TabIndex = 2;
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(85, 71);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 37);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "ايقاف";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // time
            // 
            this.time.DecimalPlaces = 2;
            this.time.Location = new System.Drawing.Point(237, 128);
            this.time.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.time.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(56, 20);
            this.time.TabIndex = 7;
            this.time.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.time.ValueChanged += new System.EventHandler(this.Time_ValueChanged);
            // 
            // audioPlay
            // 
            this.audioPlay.AutoSize = true;
            this.audioPlay.Checked = true;
            this.audioPlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.audioPlay.Location = new System.Drawing.Point(103, 275);
            this.audioPlay.Name = "audioPlay";
            this.audioPlay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.audioPlay.Size = new System.Drawing.Size(157, 17);
            this.audioPlay.TabIndex = 9;
            this.audioPlay.Text = "إصدار صوت عند قراءة الباركود";
            this.audioPlay.UseVisualStyleBackColor = true;
            this.audioPlay.CheckedChanged += new System.EventHandler(this.AudioPlay_CheckedChanged);
            // 
            // enterCheck
            // 
            this.enterCheck.AutoSize = true;
            this.enterCheck.Checked = true;
            this.enterCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enterCheck.Location = new System.Drawing.Point(132, 249);
            this.enterCheck.Name = "enterCheck";
            this.enterCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.enterCheck.Size = new System.Drawing.Size(128, 17);
            this.enterCheck.TabIndex = 10;
            this.enterCheck.Text = "ضغط enter بعد اللصق";
            this.enterCheck.UseVisualStyleBackColor = true;
            this.enterCheck.CheckedChanged += new System.EventHandler(this.EnterCheck_CheckedChanged);
            // 
            // pasteCheck
            // 
            this.pasteCheck.AutoSize = true;
            this.pasteCheck.Checked = true;
            this.pasteCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pasteCheck.Location = new System.Drawing.Point(98, 226);
            this.pasteCheck.Name = "pasteCheck";
            this.pasteCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pasteCheck.Size = new System.Drawing.Size(162, 17);
            this.pasteCheck.TabIndex = 11;
            this.pasteCheck.Text = "لصق النص بعد النسخ مباشرة";
            this.pasteCheck.UseVisualStyleBackColor = true;
            this.pasteCheck.CheckedChanged += new System.EventHandler(this.PasteCheck_CheckedChanged);
            // 
            // copyCheck
            // 
            this.copyCheck.AutoSize = true;
            this.copyCheck.Checked = true;
            this.copyCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyCheck.Location = new System.Drawing.Point(75, 203);
            this.copyCheck.Name = "copyCheck";
            this.copyCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.copyCheck.Size = new System.Drawing.Size(185, 17);
            this.copyCheck.TabIndex = 12;
            this.copyCheck.Text = "نسخ النص من الباركود إلى الحافظة";
            this.copyCheck.UseVisualStyleBackColor = true;
            this.copyCheck.CheckedChanged += new System.EventHandler(this.CopyCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 131);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "انتظار";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 131);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ثانية   حتى يتم قراءة نفس الباركود على التوالي";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 313);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyCheck);
            this.Controls.Add(this.pasteCheck);
            this.Controls.Add(this.enterCheck);
            this.Controls.Add(this.audioPlay);
            this.Controls.Add(this.time);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.cameras);
            this.Controls.Add(this.camerasBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Convert Camera To Barcode Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button camerasBtn;
        private System.Windows.Forms.ComboBox cameras;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.NumericUpDown time;
        private System.Windows.Forms.CheckBox audioPlay;
        private System.Windows.Forms.CheckBox enterCheck;
        private System.Windows.Forms.CheckBox pasteCheck;
        private System.Windows.Forms.CheckBox copyCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}


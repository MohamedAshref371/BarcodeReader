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
            this.qualities = new System.Windows.Forms.ComboBox();
            this.qualityBtn = new System.Windows.Forms.Button();
            this.rotateCheck = new System.Windows.Forms.CheckBox();
            this.invertedCheck = new System.Windows.Forms.CheckBox();
            this.noiseCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.time)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(166, 107);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 37);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "البدأ";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // camerasBtn
            // 
            this.camerasBtn.Location = new System.Drawing.Point(249, 12);
            this.camerasBtn.Name = "camerasBtn";
            this.camerasBtn.Size = new System.Drawing.Size(75, 37);
            this.camerasBtn.TabIndex = 0;
            this.camerasBtn.Text = "قائمة الكاميرات";
            this.camerasBtn.UseVisualStyleBackColor = true;
            this.camerasBtn.Click += new System.EventHandler(this.CamerasBtn_Click);
            // 
            // cameras
            // 
            this.cameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameras.Enabled = false;
            this.cameras.FormattingEnabled = true;
            this.cameras.Location = new System.Drawing.Point(19, 21);
            this.cameras.Name = "cameras";
            this.cameras.Size = new System.Drawing.Size(224, 21);
            this.cameras.TabIndex = 1;
            this.cameras.SelectedIndexChanged += new System.EventHandler(this.Cameras_SelectedIndexChanged);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(85, 107);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 37);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.Text = "ايقاف";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // time
            // 
            this.time.DecimalPlaces = 2;
            this.time.Location = new System.Drawing.Point(237, 164);
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
            this.time.TabIndex = 12;
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
            this.audioPlay.Location = new System.Drawing.Point(172, 298);
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
            this.enterCheck.Location = new System.Drawing.Point(201, 272);
            this.enterCheck.Name = "enterCheck";
            this.enterCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.enterCheck.Size = new System.Drawing.Size(128, 17);
            this.enterCheck.TabIndex = 8;
            this.enterCheck.Text = "ضغط enter بعد اللصق";
            this.enterCheck.UseVisualStyleBackColor = true;
            this.enterCheck.CheckedChanged += new System.EventHandler(this.EnterCheck_CheckedChanged);
            // 
            // pasteCheck
            // 
            this.pasteCheck.AutoSize = true;
            this.pasteCheck.Checked = true;
            this.pasteCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pasteCheck.Location = new System.Drawing.Point(167, 249);
            this.pasteCheck.Name = "pasteCheck";
            this.pasteCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pasteCheck.Size = new System.Drawing.Size(162, 17);
            this.pasteCheck.TabIndex = 7;
            this.pasteCheck.Text = "لصق النص بعد النسخ مباشرة";
            this.pasteCheck.UseVisualStyleBackColor = true;
            this.pasteCheck.CheckedChanged += new System.EventHandler(this.PasteCheck_CheckedChanged);
            // 
            // copyCheck
            // 
            this.copyCheck.AutoSize = true;
            this.copyCheck.Checked = true;
            this.copyCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyCheck.Location = new System.Drawing.Point(144, 226);
            this.copyCheck.Name = "copyCheck";
            this.copyCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.copyCheck.Size = new System.Drawing.Size(185, 17);
            this.copyCheck.TabIndex = 6;
            this.copyCheck.Text = "نسخ النص من الباركود إلى الحافظة";
            this.copyCheck.UseVisualStyleBackColor = true;
            this.copyCheck.CheckedChanged += new System.EventHandler(this.CopyCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 167);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "انتظار";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 167);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ثانية   حتى يتم قراءة نفس الباركود على التوالي";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "https://github.com/MohamedAshref371/BarcodeReader";
            this.textBox1.Visible = false;
            // 
            // qualities
            // 
            this.qualities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.qualities.Enabled = false;
            this.qualities.FormattingEnabled = true;
            this.qualities.Location = new System.Drawing.Point(19, 64);
            this.qualities.Name = "qualities";
            this.qualities.Size = new System.Drawing.Size(224, 21);
            this.qualities.TabIndex = 3;
            // 
            // qualityBtn
            // 
            this.qualityBtn.Enabled = false;
            this.qualityBtn.Location = new System.Drawing.Point(249, 55);
            this.qualityBtn.Name = "qualityBtn";
            this.qualityBtn.Size = new System.Drawing.Size(75, 37);
            this.qualityBtn.TabIndex = 2;
            this.qualityBtn.Text = "جلب قائمة الجودات";
            this.qualityBtn.UseVisualStyleBackColor = true;
            this.qualityBtn.Click += new System.EventHandler(this.QualityBtn_Click);
            // 
            // rotateCheck
            // 
            this.rotateCheck.AutoSize = true;
            this.rotateCheck.Location = new System.Drawing.Point(193, 326);
            this.rotateCheck.Name = "rotateCheck";
            this.rotateCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rotateCheck.Size = new System.Drawing.Size(136, 17);
            this.rotateCheck.TabIndex = 10;
            this.rotateCheck.Text = "دعم قراءة الباركود المائل";
            this.rotateCheck.UseVisualStyleBackColor = true;
            this.rotateCheck.CheckedChanged += new System.EventHandler(this.RotateCheck_CheckedChanged);
            // 
            // invertedCheck
            // 
            this.invertedCheck.AutoSize = true;
            this.invertedCheck.Location = new System.Drawing.Point(12, 326);
            this.invertedCheck.Name = "invertedCheck";
            this.invertedCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.invertedCheck.Size = new System.Drawing.Size(139, 17);
            this.invertedCheck.TabIndex = 11;
            this.invertedCheck.Text = "دعم قراءة الباركود الأبيض";
            this.invertedCheck.UseVisualStyleBackColor = true;
            this.invertedCheck.CheckedChanged += new System.EventHandler(this.InvertedCheck_CheckedChanged);
            // 
            // noiseCheck
            // 
            this.noiseCheck.AutoSize = true;
            this.noiseCheck.Location = new System.Drawing.Point(67, 349);
            this.noiseCheck.Name = "noiseCheck";
            this.noiseCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.noiseCheck.Size = new System.Drawing.Size(207, 17);
            this.noiseCheck.TabIndex = 15;
            this.noiseCheck.Text = "قراءة أعمق للباركود غير المثالي (بطيء)";
            this.noiseCheck.UseVisualStyleBackColor = true;
            this.noiseCheck.CheckedChanged += new System.EventHandler(this.NoiseCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 372);
            this.Controls.Add(this.noiseCheck);
            this.Controls.Add(this.invertedCheck);
            this.Controls.Add(this.rotateCheck);
            this.Controls.Add(this.qualities);
            this.Controls.Add(this.qualityBtn);
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
        private System.Windows.Forms.ComboBox qualities;
        private System.Windows.Forms.Button qualityBtn;
        private System.Windows.Forms.CheckBox rotateCheck;
        private System.Windows.Forms.CheckBox invertedCheck;
        private System.Windows.Forms.CheckBox noiseCheck;
    }
}


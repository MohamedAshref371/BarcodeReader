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
            this.setTimeBtn = new System.Windows.Forms.Button();
            this.audioPlay = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.time)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Enabled = false;
            this.startBtn.Location = new System.Drawing.Point(239, 174);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 55);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "البدأ";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // camerasBtn
            // 
            this.camerasBtn.Location = new System.Drawing.Point(257, 9);
            this.camerasBtn.Name = "camerasBtn";
            this.camerasBtn.Size = new System.Drawing.Size(75, 55);
            this.camerasBtn.TabIndex = 1;
            this.camerasBtn.Text = "الكاميرات";
            this.camerasBtn.UseVisualStyleBackColor = true;
            this.camerasBtn.Click += new System.EventHandler(this.CamerasBtn_Click);
            // 
            // cameras
            // 
            this.cameras.FormattingEnabled = true;
            this.cameras.Location = new System.Drawing.Point(25, 27);
            this.cameras.Name = "cameras";
            this.cameras.Size = new System.Drawing.Size(224, 21);
            this.cameras.TabIndex = 2;
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(25, 174);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 55);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "ايقاف";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(157, 111);
            this.time.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.time.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(75, 20);
            this.time.TabIndex = 7;
            this.time.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // setTimeBtn
            // 
            this.setTimeBtn.Location = new System.Drawing.Point(94, 103);
            this.setTimeBtn.Name = "setTimeBtn";
            this.setTimeBtn.Size = new System.Drawing.Size(57, 33);
            this.setTimeBtn.TabIndex = 8;
            this.setTimeBtn.Text = "الوقت";
            this.setTimeBtn.UseVisualStyleBackColor = true;
            this.setTimeBtn.Click += new System.EventHandler(this.SetTimeBtn_Click);
            // 
            // audioPlay
            // 
            this.audioPlay.AutoSize = true;
            this.audioPlay.Location = new System.Drawing.Point(157, 258);
            this.audioPlay.Name = "audioPlay";
            this.audioPlay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.audioPlay.Size = new System.Drawing.Size(157, 17);
            this.audioPlay.TabIndex = 9;
            this.audioPlay.Text = "إصدار صوت عند قراءة الباركود";
            this.audioPlay.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 289);
            this.Controls.Add(this.audioPlay);
            this.Controls.Add(this.setTimeBtn);
            this.Controls.Add(this.time);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.cameras);
            this.Controls.Add(this.camerasBtn);
            this.Controls.Add(this.startBtn);
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
        private System.Windows.Forms.Button setTimeBtn;
        private System.Windows.Forms.CheckBox audioPlay;
    }
}


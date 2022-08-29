namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.showTimerLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.minNumeric = new System.Windows.Forms.NumericUpDown();
            this.minLabel = new System.Windows.Forms.Label();
            this.breakLabel = new System.Windows.Forms.Label();
            this.breakNumeric = new System.Windows.Forms.NumericUpDown();
            this.secondLabel = new System.Windows.Forms.Label();
            this.secNumeric = new System.Windows.Forms.NumericUpDown();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.breakTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.minNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // showTimerLabel
            // 
            this.showTimerLabel.AutoSize = true;
            this.showTimerLabel.Font = new System.Drawing.Font("Lucida Sans", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTimerLabel.Location = new System.Drawing.Point(243, 67);
            this.showTimerLabel.Name = "showTimerLabel";
            this.showTimerLabel.Size = new System.Drawing.Size(639, 150);
            this.showTimerLabel.TabIndex = 0;
            this.showTimerLabel.Text = "00:00:00";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.startButton.Location = new System.Drawing.Point(257, 278);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(152, 77);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.stopButton.Location = new System.Drawing.Point(470, 278);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(152, 77);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.restartButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.restartButton.Location = new System.Drawing.Point(671, 278);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(152, 77);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // minNumeric
            // 
            this.minNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minNumeric.Location = new System.Drawing.Point(18, 186);
            this.minNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minNumeric.Name = "minNumeric";
            this.minNumeric.Size = new System.Drawing.Size(83, 31);
            this.minNumeric.TabIndex = 4;
            this.minNumeric.ValueChanged += new System.EventHandler(this.minNumeric_ValueChanged);
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minLabel.Location = new System.Drawing.Point(12, 139);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(117, 33);
            this.minLabel.TabIndex = 5;
            this.minLabel.Text = "Minutes";
            // 
            // breakLabel
            // 
            this.breakLabel.AutoSize = true;
            this.breakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.breakLabel.Location = new System.Drawing.Point(15, 318);
            this.breakLabel.Name = "breakLabel";
            this.breakLabel.Size = new System.Drawing.Size(165, 33);
            this.breakLabel.TabIndex = 7;
            this.breakLabel.Text = "Break (sec)";
            // 
            // breakNumeric
            // 
            this.breakNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.breakNumeric.Location = new System.Drawing.Point(18, 367);
            this.breakNumeric.Name = "breakNumeric";
            this.breakNumeric.Size = new System.Drawing.Size(83, 31);
            this.breakNumeric.TabIndex = 6;
            this.breakNumeric.ValueChanged += new System.EventHandler(this.breakNumeric_ValueChanged);
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondLabel.Location = new System.Drawing.Point(12, 230);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(128, 33);
            this.secondLabel.TabIndex = 9;
            this.secondLabel.Text = "Seconds";
            // 
            // secNumeric
            // 
            this.secNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secNumeric.Location = new System.Drawing.Point(18, 277);
            this.secNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secNumeric.Name = "secNumeric";
            this.secNumeric.Size = new System.Drawing.Size(83, 31);
            this.secNumeric.TabIndex = 8;
            this.secNumeric.ValueChanged += new System.EventHandler(this.secNumeric_ValueChanged);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1000;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // breakTimer
            // 
            this.breakTimer.Interval = 1000;
            this.breakTimer.Tick += new System.EventHandler(this.breakTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.secNumeric);
            this.Controls.Add(this.breakLabel);
            this.Controls.Add(this.breakNumeric);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.minNumeric);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.showTimerLabel);
            this.Name = "Form1";
            this.Text = "Timer";
            ((System.ComponentModel.ISupportInitialize)(this.minNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showTimerLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.NumericUpDown minNumeric;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label breakLabel;
        private System.Windows.Forms.NumericUpDown breakNumeric;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.NumericUpDown secNumeric;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Timer breakTimer;
    }
}


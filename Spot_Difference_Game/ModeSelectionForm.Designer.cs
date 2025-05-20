namespace Spot_Difference_Game
{
    partial class ModeSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModeSelectionForm));
            btnTimerMode = new Button();
            btnLimitedTries = new Button();
            btnBack = new Button();
            timer = new PictureBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)timer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnTimerMode
            // 
            btnTimerMode.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTimerMode.Location = new Point(193, 113);
            btnTimerMode.Name = "btnTimerMode";
            btnTimerMode.Size = new Size(297, 77);
            btnTimerMode.TabIndex = 1;
            btnTimerMode.Text = "Timer Mode";
            btnTimerMode.UseVisualStyleBackColor = true;
            btnTimerMode.Click += btnTimerMode_Click;
            // 
            // btnLimitedTries
            // 
            btnLimitedTries.Font = new Font("Impact", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimitedTries.Location = new Point(193, 224);
            btnLimitedTries.Name = "btnLimitedTries";
            btnLimitedTries.Size = new Size(297, 77);
            btnLimitedTries.TabIndex = 2;
            btnLimitedTries.Text = " Limited Attempts Mode\r\n";
            btnLimitedTries.TextAlign = ContentAlignment.MiddleRight;
            btnLimitedTries.UseVisualStyleBackColor = true;
            btnLimitedTries.Click += btnLimitedTries_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Impact", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(251, 331);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(163, 40);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back To Main";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // timer
            // 
            timer.BackColor = SystemColors.ButtonHighlight;
            timer.Image = (Image)resources.GetObject("timer.Image");
            timer.Location = new Point(205, 127);
            timer.Name = "timer";
            timer.Size = new Size(55, 49);
            timer.SizeMode = PictureBoxSizeMode.Zoom;
            timer.TabIndex = 4;
            timer.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(205, 239);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(255, 192, 128);
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Palatino Linotype", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(678, 58);
            label2.TabIndex = 6;
            label2.Text = "How would you like to play?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ModeSelectionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(678, 450);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(timer);
            Controls.Add(btnBack);
            Controls.Add(btnLimitedTries);
            Controls.Add(btnTimerMode);
            Name = "ModeSelectionForm";
            Text = "ModeSelectionForm";
            Load += ModeSelectionForm_Load;
            ((System.ComponentModel.ISupportInitialize)timer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTimerMode;
        private Button btnLimitedTries;
        private Button btnBack;
        private PictureBox timer;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
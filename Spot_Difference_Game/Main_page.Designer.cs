namespace Spot_Difference_Game
{
    partial class Main_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_page));
            title = new Label();
            btnEasy = new Button();
            btnMedium = new Button();
            btnHard = new Button();
            timer = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)timer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.BackColor = Color.FromArgb(255, 192, 128);
            title.Dock = DockStyle.Top;
            title.Font = new Font("Palatino Linotype", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.Desktop;
            title.Location = new Point(0, 0);
            title.Name = "title";
            title.Size = new Size(800, 58);
            title.TabIndex = 6;
            title.Text = "Spot the Difference Game";
            title.TextAlign = ContentAlignment.MiddleCenter;
            title.Click += title_Click;
            // 
            // btnEasy
            // 
            btnEasy.Font = new Font("Imprint MT Shadow", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEasy.Location = new Point(237, 130);
            btnEasy.Name = "btnEasy";
            btnEasy.Size = new Size(332, 76);
            btnEasy.TabIndex = 7;
            btnEasy.Text = "Easy level";
            btnEasy.UseVisualStyleBackColor = true;
            btnEasy.Click += button1_Click;
            // 
            // btnMedium
            // 
            btnMedium.Font = new Font("Imprint MT Shadow", 13F, FontStyle.Bold);
            btnMedium.Location = new Point(237, 248);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(332, 76);
            btnMedium.TabIndex = 8;
            btnMedium.Text = " Medium level";
            btnMedium.UseVisualStyleBackColor = true;
            btnMedium.Click += btnMedium_Click;
            // 
            // btnHard
            // 
            btnHard.Font = new Font("Imprint MT Shadow", 13F, FontStyle.Bold);
            btnHard.Location = new Point(237, 355);
            btnHard.Name = "btnHard";
            btnHard.Size = new Size(332, 76);
            btnHard.TabIndex = 9;
            btnHard.Text = "Hard level";
            btnHard.UseVisualStyleBackColor = true;
            btnHard.Click += btnHard_Click;
            // 
            // timer
            // 
            timer.BackColor = SystemColors.ButtonHighlight;
            timer.Image = (Image)resources.GetObject("timer.Image");
            timer.Location = new Point(259, 145);
            timer.Name = "timer";
            timer.Size = new Size(55, 49);
            timer.SizeMode = PictureBoxSizeMode.Zoom;
            timer.TabIndex = 10;
            timer.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(259, 263);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(259, 365);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 79);
            label1.Name = "label1";
            label1.Size = new Size(411, 32);
            label1.TabIndex = 13;
            label1.Text = "Ready to play? Pick Difficulty level ! ";
            label1.Click += label1_Click;
            // 
            // Main_page
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(timer);
            Controls.Add(btnHard);
            Controls.Add(btnMedium);
            Controls.Add(btnEasy);
            Controls.Add(title);
            Name = "Main_page";
            Text = "Main_page";
            ((System.ComponentModel.ISupportInitialize)timer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button btnEasy;
        private Button btnMedium;
        private Button btnHard;
        private PictureBox timer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}
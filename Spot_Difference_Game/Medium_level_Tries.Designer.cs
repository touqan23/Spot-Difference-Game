namespace Spot_Difference_Game
{
    partial class Medium_level_Tries
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
            components = new System.ComponentModel.Container();
            lblRemaining = new Label();
            lblFound = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnLoadimage2 = new Button();
            btnLoadimage1 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnBack = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblRemaining
            // 
            lblRemaining.Location = new Point(558, 377);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(109, 55);
            lblRemaining.TabIndex = 32;
            lblRemaining.Text = "Attempts Left : 10";
            lblRemaining.Click += lblRemaining_Click;
            // 
            // lblFound
            // 
            lblFound.Location = new Point(558, 291);
            lblFound.Name = "lblFound";
            lblFound.Size = new Size(106, 59);
            lblFound.TabIndex = 31;
            lblFound.Text = "Differences left: ";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 74);
            label2.Name = "label2";
            label2.Size = new Size(803, 38);
            label2.TabIndex = 30;
            label2.Text = "There are eight differences int the image below . can you spot them all and win the game?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(684, 115);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(508, 488);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            pictureBox2.MouseClick += pictureBox2_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 488);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // btnLoadimage2
            // 
            btnLoadimage2.Location = new Point(860, 609);
            btnLoadimage2.Name = "btnLoadimage2";
            btnLoadimage2.Size = new Size(172, 34);
            btnLoadimage2.TabIndex = 27;
            btnLoadimage2.Text = "Load_Image 2";
            btnLoadimage2.UseVisualStyleBackColor = true;
            btnLoadimage2.Click += btnLoadimage2_Click;
            // 
            // btnLoadimage1
            // 
            btnLoadimage1.Location = new Point(179, 609);
            btnLoadimage1.Name = "btnLoadimage1";
            btnLoadimage1.Size = new Size(172, 34);
            btnLoadimage1.TabIndex = 26;
            btnLoadimage1.Text = "Load_Image 1";
            btnLoadimage1.UseVisualStyleBackColor = true;
            btnLoadimage1.Click += btnLoadimage1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Palatino Linotype", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1228, 58);
            label1.TabIndex = 25;
            label1.Text = "Spot the Difference Game";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Location = new Point(12, 17);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(58, 35);
            btnBack.TabIndex = 33;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Medium_level_Tries
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1228, 644);
            Controls.Add(lblRemaining);
            Controls.Add(lblFound);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoadimage2);
            Controls.Add(btnLoadimage1);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "Medium_level_Tries";
            Text = "Medium_level_Tries";
            Load += Medium_level_Tries_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRemaining;
        private Label lblFound;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnLoadimage2;
        private Button btnLoadimage1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button btnBack;
        private OpenFileDialog openFileDialog1;
    }
}
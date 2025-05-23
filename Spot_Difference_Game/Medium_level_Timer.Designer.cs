namespace Spot_Difference_Game
{
    partial class Medium_level_Timer
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
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnLoadimage2 = new Button();
            btnLoadimage1 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            btnBack = new Button();
            openFileDialog1 = new OpenFileDialog();
            lblTimer = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 72);
            label2.Name = "label2";
            label2.Size = new Size(803, 38);
            label2.TabIndex = 21;
            label2.Text = "There are eight differences int the image below . can you spot them all and win the game?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(684, 113);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(508, 488);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.MouseClick += pictureBox2_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 488);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnLoadimage2
            // 
            btnLoadimage2.Location = new Point(860, 607);
            btnLoadimage2.Name = "btnLoadimage2";
            btnLoadimage2.Size = new Size(172, 34);
            btnLoadimage2.TabIndex = 18;
            btnLoadimage2.Text = "Load_Image 2";
            btnLoadimage2.UseVisualStyleBackColor = true;
            btnLoadimage2.Click += btnLoadimage2_Click;
            // 
            // btnLoadimage1
            // 
            btnLoadimage1.Location = new Point(179, 607);
            btnLoadimage1.Name = "btnLoadimage1";
            btnLoadimage1.Size = new Size(172, 34);
            btnLoadimage1.TabIndex = 17;
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
            label1.TabIndex = 16;
            label1.Text = "Spot the Difference Game";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.AutoSize = true;
            btnBack.Location = new Point(12, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(58, 35);
            btnBack.TabIndex = 22;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTimer.Location = new Point(540, 601);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(149, 38);
            lblTimer.TabIndex = 23;
            lblTimer.Text = "Timer : 40";
            // 
            // Medium_level_Timer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PapayaWhip;
            ClientSize = new Size(1228, 644);
            Controls.Add(lblTimer);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoadimage2);
            Controls.Add(btnLoadimage1);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Name = "Medium_level_Timer";
            Text = "Medium_level";
            Load += Medium_level_Timer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button btnLoadimage2;
        private Button btnLoadimage1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Button btnBack;
        private OpenFileDialog openFileDialog1;
        private Label lblTimer;
    }
}
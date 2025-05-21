using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;

namespace Spot_Difference_Game
{
    public partial class Medium_level_Tries : Form
    {
        private ImageDifferenceDetector detector = new ImageDifferenceDetector();
        private Bitmap image1, image2;
        private SoundManager soundManager = new SoundManager();
        private string correctSoundPath = @"Sounds/correct.wav";
        private string wrongSoundPath = @"Sounds/wrong.mp3";
        private string winSoundPath = @"Sounds/588234__mehraniiii__win.wav";
        private string loseSoundPath = @"Sounds/382310__mountain_man__game-over-arcade.wav";
        private int maxAttempts = 8;
        private int currentAttempts = 0;
        public Medium_level_Tries()
        {
            InitializeComponent();
        }

        private void btnLoadimage1_Click(object sender, EventArgs e)
        {
            string imagePath = "pictures/1(1).jpg";

            if (File.Exists(imagePath))
            {
                image1 = new Bitmap(imagePath);
                pictureBox1.Image = image1;
                Mat mat1 = image1.ToMat();

                TryDetectDifferences();
            }
            else
            {
                MessageBox.Show("Image file not found!");
            }
        }

        private void btnLoadimage2_Click(object sender, EventArgs e)
        {
            string imagePath = "pictures/1(2).jpg";

            if (File.Exists(imagePath))
            {
                image2 = new Bitmap(imagePath);
                pictureBox2.Image = image2;
                Mat mat1 = image2.ToMat();

                TryDetectDifferences();
            }
            else
            {
                MessageBox.Show("Image file not found!");
            }
        }

        private void TryDetectDifferences()
        {
            if (image1 != null && image2 != null)
            {
                Mat mat1 = image1.ToMat(); // Convert Bitmap to Mat
                Mat mat2 = image2.ToMat(); // Convert Bitmap to Mat

                detector.DetectDifferences(mat1, mat2); // Now pass the Mats

                lblFound.Text = $"Differences left: {detector.DifferenceAreas.Count}";

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_page mainForm = new Main_page();
            mainForm.Show();
            this.Close();
        }

        private void EndGame()
        {
            if (detector.DifferenceAreas.Count == 0)
            {
                soundManager.PlaySound(winSoundPath);
                MessageBox.Show("You win! Great job!");
            }
            else
            {
                soundManager.PlaySound(loseSoundPath);
                MessageBox.Show("You lost! Better luck next time.");
            }

            this.Close();
            new Main_page().Show();
        }

        private void Medium_level_Tries_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (image2 == null || detector.DifferenceAreas.Count == 0) return;

            if (currentAttempts >= maxAttempts)
            {
                EndGame();
                return;
            }
            currentAttempts++;
            lblRemaining.Text = $"Attempts Left: {maxAttempts - currentAttempts}";
            float scaleX = (float)image2.Width / pictureBox2.Width;
            float scaleY = (float)image2.Height / pictureBox2.Height;
            Point realClick = new Point((int)(e.X * scaleX), (int)(e.Y * scaleY));
            int tolerance = 25;
            Rectangle matchedArea = detector.DifferenceAreas.FirstOrDefault(r =>
            {
                Rectangle expanded = Rectangle.Inflate(r, tolerance, tolerance);
                return expanded.Contains(realClick);
            });
            if (!matchedArea.IsEmpty)
            {
                // رسم دائرة خضراء
                Graphics g = pictureBox2.CreateGraphics();
                
                g.DrawEllipse(Pens.Green, e.X - 10, e.Y - 10, 40, 40);
                g.Dispose();

                soundManager.PlaySound(correctSoundPath);

                detector.DifferenceAreas.Remove(matchedArea);
                // تحديث عدد الفروق المتبقية
                lblFound.Text = $"Differences left: {detector.DifferenceAreas.Count}";
                if (detector.DifferenceAreas.Count == 0)
                {
                    MessageBox.Show("You found all differences!");
                    EndGame();
                }
            }
            else
            {
                // رسم دائرة حمراء
                Graphics g = pictureBox2.CreateGraphics();
                g.DrawEllipse(Pens.Red, e.X - 10, e.Y - 10, 40, 40);
                g.Dispose();

                soundManager.PlaySound(wrongSoundPath);

                // تحديث عدد الفروق 
                lblFound.Text = $"Differences left: {detector.DifferenceAreas.Count}";
            }
            // Check if player ran out of attempts
            if (currentAttempts >= maxAttempts && detector.DifferenceAreas.Count > 0)
            {
                MessageBox.Show("No attempts left!");
                EndGame();
            }
        }

        private void lblRemaining_Click(object sender, EventArgs e)
        {
            lblRemaining.Text = $"Attempts Left: {maxAttempts}";
        }
    }
}

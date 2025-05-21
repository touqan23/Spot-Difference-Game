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
    public partial class Medium_level_Timer : Form
    {
        private ImageDifferenceDetector detector = new ImageDifferenceDetector();
        private Bitmap image1, image2;
        private SoundManager soundManager = new SoundManager();
        private string correctSoundPath = @"Sounds/correct.wav";
        private string wrongSoundPath = @"Sounds/wrong.mp3";
        private string winSoundPath = @"Sounds/588234__mehraniiii__win.wav";
        private string loseSoundPath = @"Sounds/382310__mountain_man__game-over-arcade.wav";
        private System.Windows.Forms.Timer gameTimer;
        private int totalSeconds = 20;
        private bool isTimerMode = false;
        public Medium_level_Timer()
        {
            InitializeComponent();
            isTimerMode = true;

            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
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
            gameTimer.Start();

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
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_page mainForm = new Main_page();
            mainForm.Show();
            this.Close();
        }

        private void Medium_level_Timer_Load(object sender, EventArgs e)
        {
            isTimerMode = true;

            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000;
            gameTimer.Tick += GameTimer_Tick;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            totalSeconds--;
            lblTimer.Text = $"Time: {totalSeconds.ToString()}";

            if (totalSeconds <= 0)
            {
                gameTimer.Stop();
                EndGame(); // Check win/loss logic
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (image2 == null || detector.DifferenceAreas.Count == 0) return;

            float scaleX = (float)image2.Width / pictureBox2.Width;
            float scaleY = (float)image2.Height / pictureBox2.Height;
            Point realClick = new Point((int)(e.X * scaleX), (int)(e.Y * scaleY));

            // السماح بهامش أكبر حول نقطة الفرق
            int tolerance = 25; // 👈 غيري هذا الرقم لتكبير أو تصغير النطاق المقبول

            Rectangle matchedArea = detector.DifferenceAreas.FirstOrDefault(r =>
            {
                Rectangle expanded = Rectangle.Inflate(r, tolerance, tolerance); // توسعة المستطيل
                return expanded.Contains(realClick);
            });

            if (!matchedArea.IsEmpty)
            {
                Graphics g = pictureBox2.CreateGraphics();
                
                g.DrawEllipse(Pens.Green, e.X - 10, e.Y - 10, 40, 40);
                g.Dispose();

                soundManager.PlaySound(correctSoundPath);


                detector.DifferenceAreas.Remove(matchedArea); // إزالة الفرق الذي تم العثور عليه

                if (detector.DifferenceAreas.Count == 0)
                {
                    MessageBox.Show("You found all differences!");
                    EndGame();
                }
            }
            else
            {
                Graphics g = pictureBox2.CreateGraphics();
                
                g.DrawEllipse(Pens.Red, e.X - 10, e.Y - 10, 40, 40);
                g.Dispose();

                soundManager.PlaySound(wrongSoundPath);
            }
        }
        private void EndGame()
        {
            gameTimer.Stop(); // نوقف المؤقت في جميع الحالات

            if (detector.DifferenceAreas.Count == 0)
            {
                // اللاعب وجد جميع الاختلافات
                soundManager.PlaySound(winSoundPath);
                MessageBox.Show("You win! Great job!");

            }
            else
            {
                // الوقت انتهى قبل أن يجد كل الاختلافات
                soundManager.PlaySound(loseSoundPath);
                MessageBox.Show("You lost! Better luck next time.");

            }

            this.Close();
            new Main_page().Show();
        }
    }
}

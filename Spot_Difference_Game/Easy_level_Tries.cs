using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spot_Difference_Game
{
    public partial class Easy_level_Tries : Form
    {
        public Easy_level_Tries()
        {
            InitializeComponent();
        }

        private void Easy_level_Tries_Load(object sender, EventArgs e)
        {

        }

        private void btnLoadimage1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(imagePath);
            }
        }

        private void btnLoadimage2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                pictureBox2.Image = new Bitmap(imagePath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Main_page mainForm = new Main_page();
            mainForm.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_page mainForm = new Main_page();
            mainForm.Show();
            this.Close();
        }
    }
}

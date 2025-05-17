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
    public partial class Main_page : Form
    {
        public Main_page()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModeSelectionForm modeForm = new ModeSelectionForm("Easy");
            modeForm.Show();
            this.Hide();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            ModeSelectionForm modeForm = new ModeSelectionForm("Medium");
            modeForm.Show();
            this.Hide();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            ModeSelectionForm modeForm = new ModeSelectionForm("Hard");
            modeForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

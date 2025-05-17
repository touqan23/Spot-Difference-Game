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
    public partial class ModeSelectionForm : Form
    {
        private string selectedLevel;
        public ModeSelectionForm(string level)
        {
            InitializeComponent();
            selectedLevel = level;
        }


        private void ModeSelectionForm_Load(object sender, EventArgs e)
        {

        }

        private void btnTimerMode_Click(object sender, EventArgs e)
        {
            OpenGameForm("timer");
        }

        private void btnLimitedTries_Click(object sender, EventArgs e)
        {
            OpenGameForm("tries");
        }

        private void OpenGameForm(string mode)
        {
            Form gameForm = null;

            if (selectedLevel == "Easy" && mode == "timer")
                gameForm = new Easy_level_Timer();
            else if (selectedLevel == "Easy" && mode == "tries")
                gameForm = new Easy_level_Tries();
            else if (selectedLevel == "Medium" && mode == "timer")
                gameForm = new Medium_level_Timer();
            else if (selectedLevel == "Medium" && mode == "tries")
                gameForm = new Medium_level_Tries();
            else if (selectedLevel == "Hard" && mode == "timer")
                gameForm = new Hard_level_Timer();
            else if (selectedLevel == "Hard" && mode == "tries")
                gameForm = new Hard_level_Tries();
            else
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            gameForm.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main_page mainForm = new Main_page();
            mainForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

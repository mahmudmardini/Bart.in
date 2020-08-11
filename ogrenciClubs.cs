using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bartin
{
    public partial class ogrenciClubs : Form
    {
        public ogrenciClubs()
        {
            InitializeComponent();
            soundFunc();
        }

        private void ogrenciClubs_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://mahmoudmardini.github.io/module2.github.io/");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            uniForm uniForm = new uniForm();
            Hide();
            uniForm.Show();
        }

        private void soundBTN_Click(object sender, EventArgs e)
        {
            homeForm.sound++;
            soundFunc();
        }
        public void soundFunc()
        {
            if (homeForm.sound % 2 == 0)
            {
                homeForm.player.settings.volume = 10;
                soundBTN.BackgroundImage = Properties.Resources.Sound_on_icon;

            }
            else
            {
                homeForm.player.settings.volume = 00;
                soundBTN.BackgroundImage = Properties.Resources.Sound_off_icon;
            }

        }

        private void ogrenciClubs_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}

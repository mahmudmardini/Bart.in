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
    public partial class genelBilgileriForm : Form
    {
        public genelBilgileriForm()
        {
            InitializeComponent();
            soundFunc();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            uniForm uniForm = new uniForm();
            Hide();
            uniForm.Show();
        }

        private void genelBilgilerButton_Click(object sender, EventArgs e)
        {
           pictureBox1.ImageLocation = string.Format(@"images/{0}.png", 11);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = string.Format(@"images/{0}.jpeg", 22);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = string.Format(@"images/{0}.jpg", 33); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = string.Format(@"images/{0}.jpg", 44);
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

        private void genelBilgileriForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

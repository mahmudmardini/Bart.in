using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Bartin
{
    public partial class uniForm : Form
    {
        int firstSize = 0;

        public uniForm()
        {
            InitializeComponent();
            soundFunc();
        }
        private int imageNum = 2;

        private void LoadNextImage()
        {
            if (imageNum == 11)
            {
                imageNum = 1;
            }
            UniMainpicture.ImageLocation = string.Format(@"images/{0}.jpg",imageNum);
            imageNum++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }




        private void backButtonUni_Click(object sender, EventArgs e)
        {
            homeForm homeForm = new homeForm();
            Hide();
            homeForm.Show();

        }

               
        private void soundBTN_Click(object sender, EventArgs e)
        {
            homeForm.sound++;
            soundFunc();
        }

        private void uniForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        

        private void backButton_Click(object sender, EventArgs e)
        {
            homeForm homeForm = new homeForm();
            Hide();
            homeForm.Show();
        }

        private void uniForm_SizeChanged(object sender, EventArgs e)
        {
            /*
            if (firstSize != 0)
            {
                if (Width >= 1400)
                {
                    button122.Height += 900;
                }
                else if (Width <= 1300)
                {
                    button122.Height -= 900;
                }
            }
            firstSize++;
            */
        }
        
        private void button4_Click_1(object sender, EventArgs e)
        {
            ogrenciClubs ogrenciClubs = new ogrenciClubs();
            Hide();
            ogrenciClubs.Show();
        }

        private void genelBilgilerButton_Click(object sender, EventArgs e)
        {
            genelBilgileriForm genelBilgileriForm = new genelBilgileriForm();
            Hide();
            genelBilgileriForm.Show();
        }

        private void UniMainpicture_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(@"Notunu Hesapla.exe");
        }
    }
}

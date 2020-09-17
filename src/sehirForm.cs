using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Bartin
{
    public partial class sehirForm : Form
    {

        public sehirForm()
        {
            InitializeComponent();
            soundFunc();
        }

        private void bartinbutton_Click(object sender, EventArgs e)
        {
            sehir_bartin sehir_bartin = new sehir_bartin();
            Hide();
            sehir_bartin.Show();
        }

               

        private void button1_Click(object sender, EventArgs e)
        {
            sehir_kurucasile sehir_kurucasile = new sehir_kurucasile();
            // Hide();
            // sehir_kurucasile.Show();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            sehir_amasra sehir_amasra = new sehir_amasra();
            Hide();
            sehir_amasra.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sehir_ulus sehir_ulus = new sehir_ulus();
            Hide();
            sehir_ulus.Show();
        }



        private void backButton_Click(object sender, EventArgs e)
        {
            homeForm homeForm = new homeForm();
            Hide();
            homeForm.Show();
        }

        private void ENButton_Click(object sender, EventArgs e)
        {
            homeForm.language = 2;
            //EnglishTranslation();
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

        private void soundOfBTN_Click(object sender, EventArgs e)
        {
            homeForm.sound++;
            soundFunc();
        }

        private void sehirForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            bartin_lable_bilgileri bartin_Lable_Bilgileri = new bartin_lable_bilgileri();
            Hide();
            bartin_Lable_Bilgileri.Show();
        }

        private void TRButton_Click(object sender, EventArgs e)
        {
            homeForm.language = 0;
            //TurkishTranslation();
        }

        private void ARButton_Click(object sender, EventArgs e)
        {
            homeForm.language = 1;
            //ArabicTranslation();
        }
    }
}

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
using System.Drawing.Drawing2D;

namespace Bartin
{
    public partial class homeForm : Form
    {
        public static int mapsOpend = 0;
        public static int sound;
        public static int language =0;
        public static WindowsMediaPlayer player = new WindowsMediaPlayer();
        public homeForm()
        {
            InitializeComponent();
            if (sound == 0) { player.URL = "music/Relaxing Music.mp3"; }
            soundFunc();
            sound += 2;
           
            
        }
        
        

        private void aboutButton_Click00(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
            
           

        }
       

        private void homeForm_Load(object sender, EventArgs e)
        {
            player.settings.volume = 01;
            soundFunc();

        }

        
        private void soundOfBTN_Click(object sender, EventArgs e)
        {
            

        }
        public void soundFunc() {
            if (sound % 2 == 0)
            {
                player.settings.volume = 10;
                soundOfBTN.BackgroundImage = Properties.Resources.Sound_on_icon;

                 }
            else
            {
                player.settings.volume = 00;
                soundOfBTN.BackgroundImage = Properties.Resources.Sound_off_icon;
            }
        }

        private void homeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            iletisim iletisim = new iletisim();
            //iletisim.Show();
        }

        private void soundOfBTN_Click_1(object sender, EventArgs e)
        {
            sound++;
            soundFunc();
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton2_Click(object sender, EventArgs e)
        {

            sehirForm bartinForm = new sehirForm();
            bartinForm.Show();
            Hide();
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            uniForm uniForm = new uniForm();
            uniForm.Show();
            Hide();
        }

        private void TRButton_Click(object sender, EventArgs e)
        {
            homeForm.language = 0;
            //TurkishTranlation();
        }

        private void ARButton_Click(object sender, EventArgs e)
        {
            homeForm.language = 1;
            //ArabicTranlation();

        }

        private void ENButton_Click(object sender, EventArgs e)
        {
            homeForm.language = 2;
           // EnglishTranlation();
        }

    }
}  
class RoundButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        GraphicsPath graphics = new GraphicsPath();
        graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        Region = new Region(graphics);

        base.OnPaint(pevent);
    }
}
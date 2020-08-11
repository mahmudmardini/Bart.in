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
    public partial class sehir_kurucasile : Form
    {
        public sehir_kurucasile()
        {
            InitializeComponent();
            soundFunc();

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            sehirForm sehirForm = new sehirForm();
            Hide();
            sehirForm.Show();
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

        private void soundBTN_Click(object sender, EventArgs e)
        {
            homeForm.sound++;
            soundFunc();
        }

        private void sehir_kurucasile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sehir_kurucasile_Load(object sender, EventArgs e)
        {
            tarihVeKulturtextBox.Text = "Yörenin ilk sahiplerinin Hititler döneminde yaşayan Pala ve Kaşkalar olduğu sanılmaktadır.\r\n" +
                " Sonra Fenikeliler, Karyalılar ve Akalar görülür. Bundan sonraki tarihsel seyir bir farkla aynıdır.\r\n" +
                " Farklılık Amastrist dönemidir.\r\n" +
                " M.Ö. 306 yılında Kurucaşilede Kromna medeniyeti yer alır.\r\n" +
                " Kromnalılar kendi adlarına para basmışlardır. Kurucaşile’ nin bilinen en eski adı KROMNA ( CROMNA )’ dır. Kromna Anadolu’ nun Paflogonya bölgesinde Karadeniz' in kıyısında kurulmuş bir eski çağ kentidir.\r\n" +
                " İyon, Lidya, Pers, Amastrist, Pontus, Roma ve Bizans dönemlerini yaşayan Kurucaşile 1460 yılında Osmanlıların egemenliği altına girmiştir.\r\n" +
                " Cumhuriyetimizin ilanıyla beraber 1957 yılına kadar Bartın İlçesine bağlı nahiye olarak kalan Kurucaşile, İlçe olmuş ve Zonguldak İline bağlanmıştır.\r\n" +
                " 1991 yılında Bartın’ın İl yapılmasıyla beraber Bartın’ın İlçesi olmuştur.";

            ayaNikolastextBox.Text = "Tarihi Kromna Kenti'nin merkezi olan Tekkeönü (Hisar) Köyündedir.\r\n" +
                " Tekkeönü Kalesine ait kalıntılarla bütünleşen ve kale içinden denize kadar uzanan bir dehliz ile 7 adet Kayakuyusundan oluşmaktadır.\r\n" +
                " Dönemi bilinmemekle birlikte, kuyuların, Kromna halkınca savaşta erzaklarını saklamak için kullanıldığı, dehlizin gerektiğinde kaleden denize kaçış dehlizi olduğu ve denize açılan kapısının liman yapımı sırasında doldurulduğu söylenmektedir.";

            kemalSamancitextBox.Text = "\r\nBartın'ın kuzeydoğu ucunda yer alan Kurucaşile, Tekkeönü, Karaman ve Kapısuyu plajları; Karadeniz'in vahşi güzelliğini sergileyen doğası, temiz kumu ve sularıyla beğenilen tatil beldelerimizdir.\r\n" +
                "Tarihi Kromna kentinin merkezi olan Tekkeönü ile balıkçı köyümüz Kapısuyu; turizme yönelik Ahşap Yat ve Tekne yapımcılığı ile de ilgi çekmektedir.";


            inkumutextBox.Text = "Şehir Merkezi, Bartın'ın kuzey doğusunda zeytin ve sandal burunları ile sınırlanan koylar üzerinde kurulmuştur.\r\n" +
                "Ortalarına yükseklik 20-300 m. ve arazi eğimi % 50'dir.\r\n" +
                "Kemrelik, Akyar, Armutçalı, Bakacakkaya önemli yükseltilerdir.\r\n" +
                " Tekkeönü, Başköy, Elvanlar, Kapısuyu ve Gölderesi adı altında dereler yer alır.\r\n" +
                " Karaman Meydan köyleri arasında fok balıklarına mahsus 10x10x10 ebadında kıyı mağarası vardır. Kömür, Dolamit, Kuvars ve Marn taşları yer altı zenginliğini oluşturur.\r\n" +
                " Yüzölçümü 159 km2 olan Kurucaşile'nin ilçe nüfusu 1997 sayımına göre 8635'dir.\r\n" +
                " Şehir merkezi nüfusu ise 1843'dür.\r\n" +
                " 1957 yılına kadar Bartın kazasının nahiyesi olan Kurucaşile 19.06.1957 yılında çıkarılan bir kanunla İlçe statüsüne geçirilmiştir.\r\n" +
                " Merkez Belediyesi ve 28 köyü mevcuttur.";
        }
    }
}

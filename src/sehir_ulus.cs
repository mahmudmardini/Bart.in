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
    public partial class sehir_ulus : Form
    {
        public sehir_ulus()
        {
            InitializeComponent();
            soundFunc();
            if (homeForm.language == 0) TurkishTranslation();
            if (homeForm.language == 1) ArabicTranslation();
            if (homeForm.language == 2) EnglishTranlation();
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

        private void sehir_ulus_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        public void EnglishTranlation()
        {

            tarihVeKulturtextBox.Text = "Located in the west of the Black Sea Region, on the Küre Mountains, the National Park is completely a plateau character.\r\n" +
                "The area of the area covered by Küre Dağlart Mili Park is 37.753 hectares and the buffer zone around it is 134.366 hectares.\r\n" +
                "The ongoing life in the vicinity has not spread to the borders of the National Park and no settlement has been established within the national park.\r\n" +
                "In other words, the National Park, which extends in the east-west direction, is a physical and social threshold for its immediate surroundings.";
            tarihVeKulturtextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            tarihVeKulturtextBox.RightToLeft = RightToLeft.No;


            ayaNikolastextBox.Text = "The spiritual founder of the Ulus district and the pride of the medar - ı iftih. The father of Hasan Timurci from Horasan Herat region.\r\n" +
                "Cihan Sultan was sent to our district by Fatih Sultan iMehmet Han and in 140 he came to our nation with his family.\r\n" +
                "His son's name (VELİ DERVİŞ) 's grandson' s name is HALIL. On the other hand, the mosque was built by Drahna Valley (Kozanh Village), Gürgen Mosque Village, Guneyören Village, Keçideresi Village (Kumluca), Hasanorer Village and İncecam Village (Orma) with a timber system.\r\n" +
                "On Friday, the market is established ablution from the river is taken , and everyone stops for Friday prayer.\r\n" +
                "However, in the past, this mosque(rebuilt between the years 1306 M.1889 and R. 1321 M. 1904 in the summer of those returning) had been rebuilt several times.\r\n" +
                "(R. 1326 - M. 1210) District of the people \"Big Snow \" he called the snowfall and the roof was destroyed and rebuilt.\r\n" +
                "It was repaired in 1946 and lastly maintained and restored in 2000.\r\n" +
                "Since its first construction, it has remained open to worship ever since.\r\n" +
                "The Foundation, which bears its name, established Zaviye and Madrasah near the mosque and made a great contribution to the warmth and development of the district.\r\n" +
                "Şeyh Hasan Dede Vakfi was transferred to the Prime Ministry General Directorate of Foundations in 1953 with the assets.\r\n" +
                "HASAN DEDE HAZRETS, accepted as the spiritual protector of our nation, is a medfund in the tomb bearing its name.";
            ayaNikolastextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            ayaNikolastextBox.RightToLeft = RightToLeft.No;

            kemalSamancitextBox.Text = "Near the Drahna Canyon, the waterfall formed by the water coming out of a rock cavity in the village of Ulukaya flows from a height of about 25 meters.\r\n" +
                "30 - 40 meters wide pond was formed in the area where the waterfall falls.\r\n" +
                "The length of the canyon in the basin where the waterfall is poured is about 1 km.There is a lively natural life in the Canyon area and especially the living species such as water salamander, water snakes, trout and goby are frequently encountered.\r\n" +
                "Ulukaya Village, named after the waterfall and canyon, is located very close to the waterfall and a part of the running water meets the drinking water needs of the Ulus district center.";
            kemalSamancitextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            kemalSamancitextBox.RightToLeft = RightToLeft.No;


            inkumutextBox.Text = "It is within the borders of the village of Aşağı Çamli and can be reached by a 40-minute walk from the asphalt and fountain.\r\n" +
                "The entrance is 30 meters depth and 113 meters and it is a horizontally developed fossil cave with stalactites in it.\r\n" +
                "The fault mirror is closely observed in the National Park.\r\n" +
                "The railings and the walkway in front of the cave were completed in 2011 under the leadership of the deputy Yilmaz Tunç.";
            inkumutextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            inkumutextBox.RightToLeft = RightToLeft.No;


            guzelceHRltextBox.Text = "Located 27 km away from the center of the nation, this plateau invites people here with its cool air, cold water and greenery.\r\n" +
                "As soon as you reach the plateau, you can see the colorful flowers and natural beauties.\r\n" +
                "Especially pigs are found too.\r\n" +
                "Festivals are held every summer in August.";
            guzelceHRltextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            inkumutextBox.RightToLeft = RightToLeft.No;


            tarihVeKulturlabel.Text = "Küre Dağlari Park";
            tarihVeKulturlabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            inkumulabel.Text = "KEMERLi CAVE";
            inkumulabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            ayaNikolaslabel.Text = "HASAN DEDE HAZRETLERİ";
            ayaNikolaslabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            kemalSamancilabel.Text = "ULUKAYA WATERFALLS";
            kemalSamancilabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            guzelceHRlabel.Text = "ULUYAYLA";
            guzelceHRlabel.Font = new Font("Algerian", 14, FontStyle.Bold);


            kemerTextBox.Text = "";
            orduYeritextBox.Text = "";


        }

        public void ArabicTranslation()
        {

            tarihVeKulturtextBox.Text = "تقع الحديقة الوطنية في غرب منطقة البحر الأسود ، على جبال كور ، وهي شخصية هضبة تمامًا.\r\n" +
                "تبلغ مساحة المنطقة التي يغطيها منتزه Küre Dağlart Mili Park 37.753 هكتار ، والمنطقة العازلة المحيطة بها تبلغ 134.366 هكتار.\r\n" +
                "لم تنتشر الحياة المستمرة في المنطقة المجاورة إلى حدود الحديقة الوطنية ولم يتم إنشاء أي مستوطنة داخل الحديقة الوطنية.\r\n" +
                "وبعبارة أخرى ، فإن الحديقة الوطنية ، التي تمتد في اتجاه الشرق والغرب ، هي عتبة مادية واجتماعية لمحيطها المباشر.";
            tarihVeKulturtextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            tarihVeKulturtextBox.RightToLeft = RightToLeft.Yes;

            ayaNikolastextBox.Text = "المؤسس الروحي لمنطقة أولوس وفخر المدار - تم تعيين والد حسن تيمورشي من منطقة حراسان هيرات من قبل أستاذه زين الدين - حافي لنشر الإسلام وجاء إلى منطقتنا مع أصدقائه السبعة.\r\n" +
                "أرسل جيهان سلطان إلى منطقتنا من قبل فاتح السلطان محمد هان وفي عام 140 ، جاء إلى أمتنا مع عائلته.\r\n" +
                "اسم ابنه(VELİ DERVİŞ) واسم حفيده خليل.\r\n" +
                "أيضاً، تم بناء مسجد وادي Drahna(قرية Kozanh) ، قرية مسجد Gürgen ، قرية Guneyören ، قرية Keçideresi(Kumluca) ، قرية Hasanorer وقرية İncecam(Orma) باستخدام نظام الأخشاب.\r\n" +
                "يوم الجمعة ، يتم تأسيس السوق ، الوضوء من النهر ثم الوقوف لصلاة الجمعة.\r\n" +
                "ومع ذلك ، في الماضي ، تم إعادة بناء هذا المسجد(الذي أعيد بناؤه بين عامي 1306 M.1889 و R 1321 م 1904 في صيف العائدين) عدة مرات.\r\n" +
                "(ص. 1326 - 1210 م). مسجد منطقة الشعب(الثلج الكثيف)  سمي بذلك بسبب كثرة تساقط الثلوج.\r\n" +
                "تم ترميمه في عام 1946 وتم ترميمه في عام 2000.\r\n" +
                " منذ بنائه الأول ، ظل مفتوحًا للعبادة منذ ذلك الحين.\r\n" +
                "المؤسسة ، التي تحمل اسمه ، أنشأت مدرسة بالقرب من المسجد وقدمت مساهمة كبيرة في التنمية في المنطقة.\r\n" +
                "تم نقل حسن حسن ديدي فاكفي إلى المديرية العامة للمؤسسات التابعة للوزارة في عام 1953 باستخدام الأصول.\r\n" +
                "حضرة حسن ديدي  ، المقبولة كحامي روحي لأمتنا ، هو مدفون في القبر يحمل اسمه.";
            ayaNikolastextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            ayaNikolastextBox.RightToLeft = RightToLeft.Yes;


            kemalSamancitextBox.Text = "\r\n" + "بالقرب من وادي Drahna ، يتدفق الشلال الناتج عن تجويف صخري في قرية اولوكايا من ارتفاع حوالي 25 مترًا.\r\n" +
                "تشكلت بركة بعرض 30 - 40 متر في المنطقة التي يسقط فيها الشلال.\r\n" +
                "يبلغ طول الوادي في الحوض الذي يسكب فيه الشلال حوالي كيلومتر واحد ، وهناك حياة طبيعية حيوية في منطقة كانيون ، وخاصة الأنواع الحية مثل السمندر المائي والثعابين المائية وسمك السلمون المرقط والغوبي.\r\n" +
                "تقع قرية اولوكايا ، التي سميت باسم الشلال والوادي ، بالقرب من الشلال وجزء من المياه الجارية يلبي احتياجات مياه الشرب في مركز مقاطعة أولوس.";
            kemalSamancitextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            kemalSamancitextBox.RightToLeft = RightToLeft.Yes;



            inkumutextBox.Text = "\r\n" + "يقع داخل حدود قرية Aşağı Çamli ويمكن الوصول إليه في غضون 40 دقيقة سيراً على الأقدام من الأسفلت والنافورة.\r\n" +
                "يبلغ عمق المدخل 30 متراً و 113 متراً وهو كهف أحفوري مطور أفقياً به صخور.\r\n" +
                "ويلاحظ المرآة عن كثب في الحديقة الوطنية.\r\n" +
                "تم الانتهاء من السور والممر أمام الكهف في عام 2011 تحت قيادة النائب يلماز تون.";
            inkumutextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            inkumutextBox.RightToLeft = RightToLeft.Yes;


            guzelceHRltextBox.Text = "\r\n" + "تقع هذه الهضبة على بعد 27 كم من وسط البلاد ، وتدعو الناس بهواء بارد ومياه باردة ومساحات خضراء. بمجرد وصولك إلى الهضبة ، يمكنك رؤية الزهور الملونة والجمال الطبيعي. تم العثور على خنازير خاصة جدا. تقام المهرجانات كل صيف في أغسطس.";
            guzelceHRltextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            guzelceHRltextBox.RightToLeft = RightToLeft.Yes;


            kemerTextBox.Text = "";
            orduYeritextBox.Text = "";


            tarihVeKulturlabel.Text = "Küre Dağlari حدائق";
            tarihVeKulturlabel.Font = new Font("Arial", 14, FontStyle.Bold);
            inkumulabel.Text = "KEMERLi كهف";
            inkumulabel.Font = new Font("Arial", 14, FontStyle.Bold);
            ayaNikolaslabel.Text = "حضرة حسن ديدي";
            ayaNikolaslabel.Font = new Font("Arial", 14, FontStyle.Bold);
            kemalSamancilabel.Text = "شلالات اولوكايا";
            kemalSamancilabel.Font = new Font("Arial", 14, FontStyle.Bold);
            guzelceHRlabel.Text = "اولوكايا";
            guzelceHRlabel.Font = new Font("Arial", 14, FontStyle.Bold);


        }



        public void TurkishTranslation()
        {
            
            tarihVeKulturtextBox.Text = "Karadeniz Bölgesi'nin batısinda, Küre Dağlari üzerinde yerleşik Milli Park, tamamen bir plato karakteri taşır.\r\n" +
                " Küre Dağlart Mili Park'nın kapladğ alanın yüzölçümü 37.753 hektara, çevresindeki tampon bölge ise 134.366 hektara denk düşer.\r\n" +
                " Yakin çevresinde süregelen yaşam, Milli Park sinirlari içerisine yayilmamiş ve milli park içerisinde hiçbir yerleşim kurulmamıştir.\r\n" +
                " Yani, doğu-batı doğrultusunda uzanan Milli Park, yakın çevresi için fiziksel ve sosyal anlamda bir eşik niteliğindedir.";


            ayaNikolastextBox.Text = "Ulus İlçemizin manevi kurucusu ve medar - ı iftiharı olan Ermişler Dergahin' dan TIMURCU HASAN BABA HAZRETLERİ \" Horasan Herat bölgesin..en Islamiyeti yaymak için hocası Zeynüddin - i Hafi tarafından gorevlendirilmiş ve yedi arkadaşı ile birlikte yöremize gelmiştir.\r\n" +
                " Cihan Padişaht Fatih Sultan iMehmet Han tarafından ilçemize gönderilmiş ve 140 yılında ailesi ile birlikte Ulus liçemize gelmiştir.\r\n" +
                "Oğlunun ismi VELİ DERVİŞ torunu ' nun ismi HALİL ' dir.Alpı çayının eteklerine ahşaptan ağaç civiler ile çatma sistemi ile saşılacak derecede sağlam ve buyük bir Cami yapmiştır. Bununla pirlikte Drahna Vadisi(Kozanh Köyü), Gürgen Cami Köyü, Guneyören Köyü, Keçideresi Köyü(Kumluca) , Hasanorer Köyü ve İncecam Köyüne(Orma) kendi adinı taşiyan ahsaptan ve çatma sistemi ile Cami yapmiştir.\r\n" +
                " Cuma günleri pazar kurulur rmaktan abdest alinarak Cuma namaina durulur.\r\n" +
                " Bununla birlikte bir Değirmen ve Şadirvan eserleri arasindadr Ancak geçmiş tarihlerde bu Cami(R. 1306 M.1889 ve R. 1321 M. 1904 yillari arasinda o dönenin yaz ayinda yeniden yapılmıştır) birkaç defa yangin geçirdiği için yeniden inşa edilmiştir.\r\n" +
                " (R. 1326 - M. 1210) lçe halkının \"Koca Kar\"diye adlandırdığı kar yağışt ida çatisı yıkılmiş ve yeniden yapilmiştir.\r\n" +
                " 1946 ylında onarimdan geçirilmiş ve en son olarak 2000 yilinda bakım ve restorasyonu yapilmiş ilk yapıldiğiı günden bu güne kadar ib.dete devamli surette açık kalmiştır.\r\n" +
                "Kendi adinı taşıy an Vakif, Caminin yaninda Zaviye ve Medrese kurarak İsı , miyet'e ve İlçenin gelişimine çok büyük bir katki sunmustur.\r\n" +
                " Vakif hizmeti kendisinden sonra Oğlu Veli Derviş'e ciaha sonrada torunu Halil'e Vakfi tasarruf etmiştir.\r\n" +
                " Şeyh Hasan Dede Vakfi 1953 senesinde mal varlığ ile birlikte Başbakanlık Vakıflar Genel Müdürlüğüne devir ve teslim edilmiştir .\r\n" +
                " Ulus İlçemizin manevi koruyucusu kabul edilen HASAN DEDE HAZRETLERİ kendi adını taşıyan Türbe - inde medfundur.";

            kemalSamancitextBox.Text = "Drahna Kanyonu'nun yakinlarında, Ulukaya Köyü'nde bir  kaya oyuğu içinden çıkan suyun oluşturduğu Şelale yaklaşık 25 metrelik yükseklikten akar.\r\n" +
                " Şelalenin döküldüğü alanda 30-40 metre genişliğinde bir gölet oluşmuştur.\r\n" +
                " Şelalenin döküldüğü havzada yer alan kanyonun uzunluğu yaklaşık 1 km, Kanyon bölgesinde canli bir doğal hayat gözlenmekte ve özellikle su semenderi, su yılanlari, alabalık, kayabalığı gibi canli türlerine sıkliıkla rastlanmaktadir.\r\n" +
                " Şelalenin ve kanyonun ismini aldiği Ulukaya Köyü, şelalenin çok yakıninda bulunur ve akan suyun bir bölümü Ulus ilçe merkezinin içme suyu ihtiyacinı karşılamaktadır.";

            

            inkumutextBox.Text = "Aşağı Çamli köyü sınırlanı içerisinde olup asfalt ve çeşmenin yanından 40 dakikalık yürüyüş ile ulaşilir.\r\n" +
                " Giris 30 metre derinlik 113 metredir ve yatay olarak gelişmiş fosil bir Mağara ve içinde sarkıtlar mevcut olup on alanı çok açık olduğu için seyir terası olarak kullanılır.\r\n" +
                " Fay aynasi Milli Park içinde yakindan görülmektedir.\r\n" +
                " Mağaranın önünde korkuluklar ve yürüyüş yolu 2011 yılında dönem Milletvekili Yilmaz Tunç önderliğinde tamamlanmıştır.";
            guzelceHRltextBox.Text = "Ulus merkezine 27 km uzaklığında bulunan bu yayla serin havası,soğuk suyu ve yeşilliği ile insanı buraya çağırmaktadır. Yaylaya ulaşır ulaşmaz burada bulunan rengarenk çiçekleri ve doğal güzellikleri siz karşılamaktadır." +
                "Burada yaban hayatta da şahit olabilirsiniz. Özellikle domuz çok bulunur. Her yaz mevsiminde Ağustos ayı içerisinde şenlikler yapılmaktadır.";

            kemerTextBox.Text = "";

            orduYeritextBox.Text = "";
        }



        private void sehir_ulus_Load(object sender, EventArgs e)
        {
        }


        private void tarihVeKulturlabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtu.be/4q9Tv8joV5o");

        }

        private void inkumulabel_Click(object sender, EventArgs e)
        {

        }

        public void goToBrowser()
        {
            maps map = new maps();
            map.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
        }
        private void kemalSamancilabel_Click(object sender, EventArgs e)
        {
            maps.mapLink = "https://www.youtube.com/watch?v=FMk1Zw-6MCM";
            goToBrowser();
        }

        private void ARButton_Click(object sender, EventArgs e)
        {
            homeForm.language = 1;
            ArabicTranslation();
        }

        private void ENButton_Click(object sender, EventArgs e)
        {
            homeForm.language = 2;
            EnglishTranlation();
        }

        private void TRButton_Click(object sender, EventArgs e)
        {
            homeForm.language = 0;
            TurkishTranslation();
        }
    }
}

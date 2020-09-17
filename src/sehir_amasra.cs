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
    public partial class sehir_amasra : Form
    {
        public sehir_amasra()
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
        private int imageNum = 1;
        private void LoadNextImage()
        {
            if (imageNum == 5)
            {
                imageNum = 1;
            }
            BartinMainpicture.ImageLocation = string.Format(@"images/amasra{0}.jpg", imageNum);
            imageNum++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
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
        public void goToMaps()
        {
            maps map = new maps();
            map.Show();
        }


        private void sehir_amasra_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void sehir_amasra_Load(object sender, EventArgs e)
        {
        }

        private void tarihVeKulturpictureBox_Click(object sender, EventArgs e)
        {
            maps.mapLink = "https://goo.gl/maps/xVXbG8QkmGPsufrQ8";
             goToMaps();
        }

        private void inkumupictureBox_Click(object sender, EventArgs e)
        {
            maps.mapLink = "https://goo.gl/maps/gRcwofq129KzsRWx7";
            goToMaps();
        }

        private void ayaNikolaspictureBox_Click(object sender, EventArgs e)
        {
            maps.mapLink = "https://goo.gl/maps/St7xG8CuqGhk2R9d7";
            goToMaps();
        }

        private void kemalSamancipictureBox_Click(object sender, EventArgs e)
        {
            maps.mapLink = "https://goo.gl/maps/N87FTRRG8SzqnsT28";
            goToMaps();
        }

        private void guzelceHRlpictureBox_Click(object sender, EventArgs e)
        {
            //maps.mapLink = "https://goo.gl/maps/xVXbG8QkmGPsufrQ8";
           // goToMaps();
        }

        private void kemerPictureBox_Click(object sender, EventArgs e)
        {
            maps.mapLink = "https://goo.gl/maps/f4YXXy7ZSd6Edgs3A";
            goToMaps();
        }

        private void orduYeripictureBox_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            maps.mapLink = "http://www.amasrasanaltur.com/";
            goToMaps();

            /*
            _360dereceli.foto360 = "http://www.amasrasanaltur.com/";

            _360dereceli fotoForm = new _360dereceli();
            fotoForm.Show(); */
        }

        public void TurkishTranslation()
        {

            tarihVeKulturtextBox.Text = "1955 yılında, antik bir yerleşim merkezi olan Amasra ve çevresinde sık sık ortaya çıkan taşınabilir arkeolojik ve etnoğrafik eski eserler, Belediye binasında küçük bir salonda sergilenmeye başlanmıştır.\r\n" +
                " 1976 yılında Kültür Bakanlığı’nca müze binası arayışları sürerken 1884 yılında Denizcilik Okulu olarak yapımına başlanan ancak bitirilemeyen bina satın alınarak restore edilmiş ve 1982 yılında tamamlanmıştır.\r\n" +
                " 1982 yılından beri bugünkü tarihi binasında hizmet veren ve dört teşhir salonundan oluşan Amasra Müzesi’nde; Hellenistik, Roma ve Bizans, Ceneviz ve Osmanlı Dönemlerine ait eserler sergilenmektedir.";

            kemerTextBox.Text = "9. yy.da Amasra Kalesi içinde yapılmış eski bir Bizans Kilisesidir.\r\n" +
                " Amasra’nın 1460 yılında, Fatih Sultan Mehmet tarafından fethi sırasında camiye çevrilmiştir.\r\n Dönemin tüm yapı özelliklerini taşıyan yapının Narthex (İlk Cemaat) bölümü ile Ambon (Apsis) çıkıntısı sonradan mekana katılmıştır.\r\n" +
                " 19x11 m boyutlarındaki caminin, 1887 yılında dört duvarı dışında mekanı örten ve yer yer yıkılma tehlikesi gösteren beşik tonoz çatısı kaldırılmış, yerine ahşap tavan ve çatı yapılarak büyük bir onarımdan geçirilmiştir.\r\n" +
                " Türkiye’de ve diğer İslam ülkelerinde rastlanılmayan “Cuma hutbesinin kılıç çekilerek okunması” geleneği günümüzde Fatih Camii’nde yaşatılmaktadır.\r\n" +
                " Bilindiği gibi, Peygamber Efendimiz Hz. Muhammed’in savaş kıyafetleriyle gittiği Mekke’de Cuma hutbesini kılıcını kınından çıkararak okuması; yıllarca “Sünnet” kabul edilerek bütün camilerde uygulanmaya başlamıştı.\r\n" +
                " Geçen 1400 yıllık sürede bu gelenek zamanla unutulmuş olsa da, Amasra Fatih Camii’nde hala sürdürülmekte ve hayli ilgi çekmektedir.";


            ayaNikolastextBox.Text =
            "13. yy’da Cenovalıların Samastro, Sakız Adası, Foça, Galata, Samsun, Kefe ve daha birçok doğu kolonileri vardı.\r\n" +
                " Cenovalılar (İtalyanlar) ele geçirdikleri kolonilerdeki kale duvarlarına kendi amblemlerini yerleştiriyorlardı.\r\n" +
                " Bu düşüncenin amacı, yerel halka geçmişe ait her şeyin Cenevizliler tarafından yapıldığını anlatmaktır.\r\n" +
                " Amasra Kalesi de arma yönüyle geniş bir koleksiyonu yansıtır. 1261–1460 yılları arasında Samastro adıyla anılan Amasra’da hükümranlıklarını sürdüren Cenovalılar, bu dönemde Amasra yöneticilerinden konsolosları Cenova’dan, memurları ise Pera’dan (Galata) atamışlardır.\r\n" +
                " F.W.Hasluck’un tespitlerine göre Galata ve Kefe armalarında, Podesta ve Tatar Hanı blazonlarına yer verilirken, Amasra’da “Doc-Cenova-Konsolos” blazonlarını içeren taş armalara yer verilmiştir.\r\n" +
                " Blazonlar, üç figürden oluşan bir settir. Bunlardan ortadaki genellikle Cenova şehrini sembolize eden “Haç”tan ibaret olup, bunun sağında Cenova’yı yöneten Doc’un aile amblemi, sol tarafında ise Amasra’da Cenova yönetiminin temsilcisi olan konsolosun aile arması yer alır.\r\n" +
                " Bir Cenova Doc’u olan Simone Boccanegra’ya ait ve iki ayrı dönemi içeren [(1339–1344), (1361– 1363)] Cenova arması ile birlikte iki blazonluk bir arma oluşturan taş içkalede olup, Amasra armalarının en eskisi olarak kabul edilir.\r\n" +
                " Samastro armaları arasında Cenova’yı işgal eden Milano Dukası Visconti’nin yılanlı armaları ile ünlü D’auria ailesini temsil eden kartallı blazonlar da görülür.\r\n" +
                " Bazı amblemlerde kazınma işlemi vardır. Bu durum F.W. Hasluck’un söylediği gibi “Türklük Duygusu”ndan değil; Cenova’nın Fransızlar tarafından 1393–1413 yılları arasındaki işgaline bir tepkiden kaynaklanmıştır.\r\n" +
                " Armalarda, Cenova yönetiminde bulunan Adorno, Fregoso, Poggio Doc aile blazonları ile Amasra’da konsolosluk yapan Gazano, Luxardo, De Zoagli, De Montenegro, De Ghizolfi, Malaspina, Boccanegra, D’auria ailelerinin blazonları bulunmaktadır.\r\n" +
                " Bunlardan Simone Boccanegro amblemi 1360’lı yılları işaret ettiği halde, diğerleri onbeşinci yüzyıldaki muhtelif tarihleri gösterir.";


            kemalSamancitextBox.Text = "Roma döneminde 1. yy sonlarına doğru yapılmıştır.\r\n" +
                " Amaç, kiliselerin yer aldığı Amastris şehrini yine Anadolu’daki kiliselerin bulunduğu şehirlere bağlamaktır.\r\n" +
                " Antik yol, Amasra’da başlayıp Kuşkayası Yol Anıtı’nın önünden geçerek Safranbolu ve Gerede’ye ulaştıktan sonra İpek Yolu ile kesişmektedir.\r\n" +
                " Yolun büyük bir kısmı yok olmuştur.";


            inkumutextBox.Text = "Bizans dönemine ait olan Amasra Kalesi, özelikle Ceneviz döneminde değişikliklere uğramış ve 14–15 yy.\r\n" +
                "larda Ceneviz ve Osmanlı dönemlerinde de ciddi onarımlar görmüştür.\r\n" + "Kale; iki ana kütleden oluşmaktadır.\r\n" +
                " Birisi, o zaman ada olan ve “Kemere” denilen bir köprüyle Amasra’ya bağlanan Boztepe’deki Sormagir Kalesi, diğeri Amasra’daki Zindan Kalesi’dir.\r\n" +
                " Kuzeydoğu ucunda Büyükliman Kapısı, batısında Küçükliman (Antik) Kapısı ve güneyinde Zindan Kapısı bulunmaktadır.\r\n" +
                " Sormagir Kalesine, Kemere Köprü’ye bitişik “Karanlık yer” denilen tonozlu ana kapıdan girildikten sonra Antikliman ve Hacıdenizi yönlerinde iki tali kapıdan çıkılır.\r\n" +
                " Amasra Kalesi’nin kuzeydoğu-güneydoğu arasındaki doğu surlarının uzunluğu 65 m, üzerinde 8 adet burç bulunan güney surlarının uzunluğu 300 m ve Kemere Köprü’den itibaren de büyük bölümü yıkılan kuzey surlarının uzunluğu 200 m kadardır.\r\n" +
                " Sormagir Kalesi’nin Kuzey ve kuzeybatısı denize çok dik bir yar halinde indiğinden buraya sur yapılmamıştır. Doğu, kuzeydoğu ve batısını çevreleyen surlardan çoğu yıkılmış, kapıya bitişik batı surlarının 50 m’lik bir kısmı ayaktadır.\r\n" +
                " Amasra Kaleleri, yer yer kule boşlukları, iç taksimatlar, belirli yerlere yerleştirilen Cenova armaları, eros, medusa, kartal, öküzbaşı gibi figürlerin yer aldığı taşlarla günümüzde bile bir orta çağ havası vermektedir.";
            guzelceHRltextBox.Text = "Roma Dönemine ait olup, Aya Yorgi Tepesi’nin güney yamacındadır.\r\n" +
                " Tiyatro boşluğu (Cavea) ve Sahne (Scane) bölümleri yıkılmıştır.\r\n" +
                " Yeri mezarlık olarak kullanılan tiyatronun sadece bir giriş kapısına ait kalıntılar görülebilmektedir.";
        }

        public void EnglishTranlation()
        {
            tarihVeKulturtextBox.Text = "In 1955, portable archaeological and ethnographic artefacts, which frequently appeared in and around Amasra, an ancient settlement center, were exhibited in a small hall in the Municipality building.\r\n" +
                "While the search for a museum building was continued by the Ministry of Culture in 1976, the building, which was started to be built as a Maritime School in 1884, was purchased and restored and completed in 1982.\r\n" +
                "Amasra Museum, which has been serving in its historical building since 1982 and consists of four exhibition halls; Hellenistic, Roman and Byzantine, Genoese and Ottoman works are exhibited.";
            tarihVeKulturtextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            tarihVeKulturtextBox.RightToLeft = RightToLeft.No;

            kemerTextBox.Text = "It is an old Byzantine church built in Amasra Castle in the 9th century.\r\n" +
                "It was converted into a mosque during the conquest of Amasra by Fatih Sultan Mehmet in 1460.\r\n" +
                "The Narthex(First Congregation) section and Ambon(Apsis) ledge of the building, which had all the building features of the period, later joined the place.\r\n" +
                "The mosque, which measures 19x11 m in dimensions, was removed in 1887 by the barrel vault roof covering the room and in danger of being demolished.\r\n" +
                "not encountered in Turkey and other Islamic countries \"to read the Friday sermon with a sword\" tradition is kept alive today in the Fatih Mosque.\r\n" +
                "As is known, the Prophet Muhammad (PBUH) went to Mecca in war clothes to read Friday sermon by removing the sword; for years, it was accepted as a \"sunna\" and applied in all mosques.\r\n" +
                "Although this tradition has been forgotten in the last 1400 years, it is still continuing in Amasra Fatih Mosque and attracting great attention.";
            kemerTextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            kemerTextBox.RightToLeft = RightToLeft.No;

            ayaNikolastextBox.Text =
            "In the 13th century there were Samastro of Genoa, Chios, Foca, Galata, Samsun, Kefe and many other eastern colonies.\r\n" +
                "The Genoese(Italians) placed their emblems on the fortress walls of the colonies they captured.\r\n" +
                "The purpose of this idea is to tell the local people that everything from the past was done by the Genoese.\r\n" +
                "Amasra Castle also reflects a large collection of emblems.\r\n" +
                "The Genoese, who continued to rule in Amasra, which was called Samastro between 1261 and 1460, appointed consul from Amasra rulers from Genoa and from Pera (Galata).\r\n" +
                "According to the findings of F.W.Hasluck, Podesta and Tatar Han blazons were used in Galata and Kefe coats, while stone crests containing “Doc - Genoa - Consul” blazons were used in Amasra.\r\n" +
                "Blazons are a set of three figures.The middle of these is the “Cross eden, which usually symbolizes the city of Genoa, to the right of it is the family emblem of Doc, who runs Genoa, and to the left is the emblem of the Consul, the representative of the Genoa administration in Amasra.\r\n" +
                "It belongs to Simone Boccanegra, a Genoa Doc, and it is considered to be the oldest of the Amasra coat of arms, which forms a two-blazon coat of arms with the coat of arms of Genoa(1339–1344), (1361–1363), which includes two separate periods.\r\n" +
                "Among the Samastro coats are the eagle blazons representing the D’auria family and the serpent coat of arms of Visconti, the Dukes of Milan that invaded Genoa.\r\n" +
                "Some emblems are engraved. This is F.W.As Hasluck said, değil not from the sense of Turkishness; \r\n" +
                "The coats of arms include the family blazons Adorno, Fregoso, Poggio Doc, and the blazons of Gazano, Luxardo, De Zoagli, De Montenegro, De Ghizolfi, Malaspina, Boccanegra and D’auria.\r\n" +
                "Of these, the Simone Boccanegro emblem marks the 1360s, while others show various dates in the fifteenth century.";
            ayaNikolastextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            ayaNikolastextBox.RightToLeft = RightToLeft.No;

            kemalSamancitextBox.Text = "It was built towards the end of the 1st century in Roman period.\r\n" +
                "The aim is to connect the city of Amastris, where the churches are located, to the cities where the churches are located in Anatolia.\r\n" +
                "The ancient road starts in Amasra and passes in front of the Kuşkayası Road Monument and reaches Safranbolu and Gerede and then crosses with the Silk Road.\r\n" +
                "Most of the road has disappeared.";
            kemalSamancitextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            kemalSamancitextBox.RightToLeft = RightToLeft.No;

            inkumutextBox.Text = "Amasra Castle, which belonged to the Byzantine period, underwent changes especially during the Genoese period and saw serious repairs in the Genoese and Ottoman periods in the 14th-15th centuries.\r\n" +
                "The Castle; It consists of two main masses.\r\n" +
                "One is the Sormagir Castle in Boztepe, which was then an island and connected to Amasra by a bridge called “Kemer,, and the other is the Zindan Castle in Amasra.\r\n" +
                "There are Büyükliman Gate at the northeast end, Küçükliman (Ancient) Gate to the west and Dungeon Gate to the south.\r\n" +
                "After entering the Sormagir Castle through the vaulted main gate, which is adjacent to the Kemere Bridge(Dark place), two secondary gates exit in the direction of Antikliman and Hacıdenizi.\r\n" +
                "The eastern walls of the Amasra Fortress between the northeast and southeast are 65 m long, the southern walls with 8 towers are 300 m long and the northern walls of which are mostly destroyed since Kemere Bridge are 200 m long.\r\n" +
                "Since the north and northwest of Sormagir Castle descended to the sea in a very steep slope, there was no fortification.Most of the walls surrounding the east, northeast and west have been demolished and a 50 m section of the western walls adjacent to the gate is standing.\r\n" +
                "Amasra Castles, even in places with tower gaps, internal parts, Genoa coat of arms placed in certain places, eros, medusa, eagle, ox-stone figures with figures such as the Middle Ages even today.";
            inkumutextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            inkumutextBox.RightToLeft = RightToLeft.No;

            guzelceHRltextBox.Text = "It belongs to the Roman Period and is on the southern slope of Aya Yorgi Hill.\r\n" +
                "The theater cave(Cavea) and Stage(Scane) sections were destroyed.\r\n" +
                "Only the remains of an entrance gate of the theater can be seen.";
            guzelceHRltextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            guzelceHRltextBox.RightToLeft = RightToLeft.No;


            tarihVeKulturlabel.Text = "Amasra Museum";
            tarihVeKulturlabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            inkumulabel.Text = "Amasra Castle";
            inkumulabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            ayaNikolaslabel.Text = "Cenova Armaları";
            ayaNikolaslabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            kemalSamancilabel.Text = "Antique Road";
            kemalSamancilabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            guzelceHRlabel.Text = "Antique Theater";
            guzelceHRlabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            kemerLabel.Text = "Fatih Mosque (old church)";
            kemerLabel.Font = new Font("Algerian", 14, FontStyle.Bold);


            linkLabel1.Text = "Please click hear to see Amasra's 360 photos... ";
        }

        public void ArabicTranslation()
        {
            tarihVeKulturtextBox.Text = "في عام 1955 ، تم عرض القطع الأثرية والإثنوغرافية المحمولة ، والتي ظهرت بشكل متكرر في وحول مدينة أماصرة ، وهي مركز قديم للمستوطنات ، في قاعة صغيرة في مبنى البلدية.\r\n" +
                "بينما استمرت وزارة الثقافة في البحث عن مبنى المتحف في عام 1976 ، تم شراء المبنى الذي تم إنشاؤه كمدرسة بحرية في عام 1884 ، وتم ترميمه واستكماله في عام 1982.\r\n" +
                "متحف أماصرة ، الذي يعمل في مبنى تاريخي منذ عام 1982 ويتألف من أربع قاعات عرض ؛ تعرض الأعمال الهلنستية والرومانية والبيزنطية والجنوزية والعثمانية.";
            tarihVeKulturtextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            tarihVeKulturtextBox.RightToLeft = RightToLeft.Yes;

            kemerTextBox.Text = "كنيسة بيزنطية قديمة بنيت في قلعة أماصرة في القرن التاسع.\r\n" +
                "تم تحويلها إلى مسجد خلال غزو مدينة أماصرة من قِبل فاتح السلطان محمد في عام 1460.وانضم إلى القسم النارثكس(التجمع الأول) وحافة أمبون(أبسيس) للمبنى ، الذي كان يحتوي على جميع ميزات المبنى في هذه الفترة.\r\n" +
                "المسجد ، الذي يبلغ أبعاده 19 × 11 مترًا ، تم إزالته في عام 1887 بسبب السقف المدبب الذي يغطي الغرفة وخطر التعرض للهدم.\r\n" +
                "التقليد الذي لايتم تطبيقه في اي بلد مسلم اليوم (قراءة خطبة الجمعة بالسيف) ، ظل حي اليوم في مسجد الفاتح.\r\n" +
                "كما هو معروف ، ذهب النبي محمد(صلى الله عليه وسلم) إلى مكة في ملابس الحرب لقراءة خطبة الجمعة وبيده السيف. لسنوات ، تم قبولها باعتبارها (سنة) وتطبيقها في جميع المساجد.\r\n" +
                "على الرغم من أن هذا التقليد قد نسي في السنوات ال 1400 الماضية ، فإنه لا يزال مستمراً في مسجد فاتح أماصرة ولازال يجذب الكثير من الانتباه.";
            kemerTextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            kemerTextBox.RightToLeft = RightToLeft.Yes;

            ayaNikolastextBox.Text =
            "في القرن الثالث عشر كان هناك ساماسترو من جنوة ، خيوس ، فوكا ، غلطة ، سامسون ، كيفي والعديد من المستعمرات الشرقية الأخرى.\r\n" +
                "وضع الجنوة(الإيطاليون) شعاراتهم على جدران قلعة المستعمرات التي استولوا عليها.\r\n" +
                "الغرض من هذه الفكرة هو إخبار السكان المحليين بأن كل شيء من الماضي تم بواسطة الجنوة.\r\n" +
                "تعكس قلعة  أماصرة أيضًا مجموعة كبيرة من الشعارات. قام الجنوز ، الذين استمروا في الحكم في أماسرا ، والذي كان يسمى ساماسترو بين عامي 1261 و 1460 ، بتعيين قنصل من حكام أماصرة من جنوة ومن بيرا(غلطة).\r\n" +
                "ووفقًا للنتائج التي توصلت إليها F.W.Hasluck ، استخدمت بلاطات Podesta و Tatar Han في معاطف Galata و Kefe ، بينما تم استخدام قمم حجرية تحتوي على بلاطات Doc-Genoa-Consul في Amasra.\r\n" +
                "Blazons هي مجموعة من ثلاثة أرقام. من بينها كروس إيدن ، الذي يرمز عادة إلى مدينة جنوة ، إلى اليمين منه شعار عائلة دوك ، الذي يدير جنوة ، وإلى اليسار شعار القنصل.\r\n" +
                "من بين معاطف السماسترو الحلل التي تمثل عائلة دوريا ومعطف السلاح الثائر لفيسكونتي ، دوقات ميلانو التي غزت جنوة.\r\n" +
                "تشمل معاطف الأسلحة بزات عائلة Adorno و Fregoso و Poggio Doc و blazons من Gazano و Luxardo و De Zoagli و De Montenegro و De Ghizolfi و Malaspina و Boccanegra و D'auria.\r\n" +
                "ومن بين هذه العلامات ، يمثل شعار سيمون بوكانيغرو عام 1360 ، بينما يُظهر آخرون تواريخ مختلفة في القرن الخامس عشر.";
            ayaNikolastextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            ayaNikolastextBox.RightToLeft = RightToLeft.Yes;

            kemalSamancitextBox.Text = "\r\n" + "تم بناؤه في نهاية القرن الأول في الفترة الرومانيةتم بناؤه في نهاية القرن الأول في الفترة الرومانية.\r\n" +
                "الهدف من ذلك هو ربط مدينة أماسترس ، حيث توجد الكنائس ، بالمدن التي توجد بها الكنائس في الأناضول.\r\n" +
                "  يبدأ الطريق القديم في أماصرة ويمر أمام طريق Kuşkayası.\r\n" +
                "اختفى معظم الطريق.";
            kemalSamancitextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            kemalSamancitextBox.RightToLeft = RightToLeft.Yes;

            inkumutextBox.Text = "خضعت قلعة أماصرة ، التي كانت تنتمي إلى الفترة البيزنطية ، لتغييرات خاصة خلال فترة الجنوة وشهدت إصلاحات جدية في العصور الجينية والعثمانية في القرنين الرابع عشر والخامس عشر.\r\n" +
                "القلعة؛ وهي تتألف من قسمين.\r\n" +
                "أحدهما هو قلعة Sormagir في Boztepe ، التي كانت آنذاك جزيرة ومتصلة بأماسرا بواسطة جسر يُطلق عليه Kemere ، والآخر هو قلعة Zindan في أماصرة .\r\n" +
                "توجد بوابة Büyükliman في الطرف الشمالي الشرقي ، وبوابة Küçükliman القديمة إلى الغرب وبوابة الأبراج المحصنة من الجنوب.\r\n" +
                "بعد دخول قلعة Sormagir من خلال البوابة الرئيسية المقببة ، المتاخمة لجسر Kemere(مكان مظلم) ، يخرج بوابتان ثانويتان في اتجاه Antikliman و Hacıdenizi.\r\n" +
                "يبلغ طول الجدران الشرقية لقلعة أماسرا بين الشمال الشرقي والجنوب الشرقي 65 متراً ، والجدران الجنوبية التي تضم 8 أبراج طولها 300 متر ، والجدران الشمالية التي دمرت معظمها منذ جسر كيمير بطول 200 متر.\r\n" +
                "نظرًا لأن شمال وشمال غرب قلعة Sormagir ينحدر إلى البحر في منحدر شديد الانحدار ، لم يكن هناك إغناء. تم هدم معظم الجدران المحيطة بالشرق والشمال الشرقي والغربي وقسم 50 مترًا من الجدران الغربية المجاورة للبوابة.\r\n" +
                "قلاع أماصرة ، حتى في الأماكن التي بها ثغرات في البرج ، والأجزاء الداخلية ، وغطاء Genoa للأسلحة الموضوعة في أماكن معينة ، وإيروس ، وميدوسا ، ونسر ، وشخصيات من حجر الثور بأشكال مثل العصور الوسطى حتى اليوم.";
            inkumutextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            inkumutextBox.RightToLeft = RightToLeft.Yes;

            guzelceHRltextBox.Text = "\r\n" + "ينتمي إلى العصر الروماني ويقع على المنحدر الجنوبي من تل آية يورجي.\r\n" +
                "تم تدمير أقسام الكهف و المسرح \r\n" +
                "ولا يمكن رؤية سوى بقايا بوابة المدخل";
            guzelceHRltextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            guzelceHRltextBox.RightToLeft = RightToLeft.Yes;


            tarihVeKulturlabel.Text = "متحف أماصرة";
            tarihVeKulturlabel.Font = new Font("Arial", 14, FontStyle.Bold);
            inkumulabel.Text = "قلعة أماصرة";
            inkumulabel.Font = new Font("Arial", 14, FontStyle.Bold);
            ayaNikolaslabel.Text = "Cenova Armaları";
            ayaNikolaslabel.Font = new Font("Arial", 14, FontStyle.Bold);
            kemalSamancilabel.Text = "الطريق القديم";
            kemalSamancilabel.Font = new Font("Arial", 14, FontStyle.Bold);
            guzelceHRlabel.Text = "المسرح القديم";
            guzelceHRlabel.Font = new Font("Arial", 14, FontStyle.Bold);
            kemerLabel.Text = "جامع الفاتح_الكنيسة القديمة";
            kemerLabel.Font = new Font("Arial", 14, FontStyle.Bold);


            linkLabel1.Text = "...يرجى النقر هنا لمشاهدة صور مدينة أماسرا بخاصية 360 درجة ";
        }

        private void ARButton_Click(object sender, EventArgs e)
        {
            homeForm.language = 1;
            ArabicTranslation();
            linkLabel1.Text = "...يرجى النقر هنا لمشاهدة صور مدينة أماسرا بخاصية 360 درجة ";
        }

        private void TRButton_Click(object sender, EventArgs e)
        {
            homeForm.language = 0;
            TurkishTranslation();
        }

        private void ENButton_Click(object sender, EventArgs e)
        {
            homeForm.language = 2;
            EnglishTranlation();
        }
    }
}

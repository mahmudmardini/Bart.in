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
    public partial class sehir_bartin : Form
    {
        int firstSize = 0;
        public sehir_bartin()
        {
            
            InitializeComponent();
            soundFunc();
            if (homeForm.language == 0) TurkishTranslation();
            if (homeForm.language == 1) ArabicTranslation(); 
            if (homeForm.language == 2) EnglishTranlation();


        }
        private int imageNum = 52;

        private void LoadNextImage()
        {
            if (imageNum == 55)
            {
                imageNum = 51;
            }
            BartinMainpicture.ImageLocation = string.Format(@"images/{0}.jpg", imageNum);
            imageNum++;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }


        private void ARButton_Click(object sender, EventArgs e)
        {
            homeForm.language = 1;
            ArabicTranslation();
        }
        
        

        private void backButton_Click(object sender, EventArgs e)
        {
            sehirForm sehirForm = new sehirForm();
            sehirForm.Show();
            Hide();
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
















        public void EnglishTranlation() {
            tarihVeKulturlabel.Text = "History and Culture";
            tarihVeKulturlabel.Font = new Font("Algerian", 14, FontStyle.Bold);

            tarihVeKulturtextBox.Text = "The source of Bartin name: \r\n" +
                "Parthenios, the ancient name of the Bartin River; In Greek mythology, the God of the Gods is one of the hundreds of gods who are children of OKENAUS and the God of Waters. \r\n" +
                "In short, the name of Bartın means Muhteşem Water is Divine or Magnificent Flowing Water Kıs.\r\n" +
                "It is understood from the written sources that the city of Bartin, which was established on the edge of the Bartin River, was called as PARTHENIA in ancient times and that this name changed to Bartin over time.\r\n" +
                "Bartin In The Old Ages\r\n" +
                "The first owners of Bartın, BC. 14th century Gaskas and BC.It is accepted that there were Hittites in the 13th century and later it was known that the Paflagonians who had settled in Bolu Havali and the Paflagonians who ruled in Kastamonu West extended their borders to Parthenios and thus the Bartın lands were within the boundaries of these two sovereignty.\r\n" +
                "the Phrygians in the Bithynie District in the Bithynie District, the Phoenicians of the Amasra in the Paplagonie District, the Phoenicians; Amasra (Sesamos), Eregli (Heraklia), Sinop (Sinope) and Tekkeönü (china) formed the first Sayda Colonies.\r\n" +
                "With the deterioration of the balance of power in the Mediterranean, the Phoenicians and their partners left the Carians Amasra and Kromna. Bartin and its surroundings, BC 7.yy.da Cimmerians, BC. In the 6th century, the Lydians entered the sovereignty of the Persians. During the period of 216 years, the Black Sea Colonies maintained their status for a long time thanks to the friendship of Perslon.\r\n" +
                "B.C. In 334, the Macedonian King Alexander put an end to the Persians' sovereignty and became the owner of the region. Bartin and the administration of the nation \"General Eumenes\", the administration of Amasra and Tekkeönü'nın left the Saturn said. However, Amasra administration of BC. Between the years 302-286 began to be handled by Queen Amastris." +
                "B.C. The city, which was called Sesamos since the 12th century, was named after the Queen Amastris for 16 years. In this period; Kromna (Tekkeönü), Tios (Filyos-Hisarönü) and Kyteros (Gideros) sites consisting of the Union of Symoikismos Siteler Union. When the Queen Amastris was killed by the immigration of the ship which had been carried by his sons in 44 BC, the city was re-directed by Eumenes. Amasra and Bartın region around the region after the war in M.Ö.279 BC was dominated by the kingdom of Pontus.";
            tarihVeKulturtextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            tarihVeKulturtextBox.RightToLeft = RightToLeft.No;

            inkumulabel.Text = "Inkumu";
            inkumulabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            inkumutextBox.Text = "\r\nInkumu Beach is a paradise region hidden in the black sea where 2.5 kilometers long meets the green and blue.\r\n Located 45 minutes away from Amasra, there are restaurants and markets where you can meet all your needs.";
            inkumutextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            inkumutextBox.RightToLeft = RightToLeft.No;

            ayaNikolaslabel.Text = "Aya Nikola Church";
            ayaNikolaslabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            ayaNikolastextBox.Text = "\r\nThis historical building, which was built in 1319 in the center of Bartın and used as a power plant for a while from 1936,\r\n was restored in 1955 and opened as a cultural house.";
            ayaNikolastextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            ayaNikolastextBox.RightToLeft = RightToLeft.No;

            kemalSamancilabel.Text = "Kemal Samanci Oğlu Museum";
            kemalSamancilabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            kemalSamancitextBox.Text = "Kemal Samancıoğlu Born in Bartın and was the president of the muinicipality for 24 years, rased in the historical wooden house where he was born and served as Ethnography Museum today.\r\n" +
                "In addition to the belongings of Kemal Samancıoğlu, there are about 700 ethnographic works donated by Bartın families.\r\n" +
                "The museum consists of a total of eight rooms and a hall on three floors; On the first and second floors, there is the daily living room and study room of Kemal Samancıoğlu.\r\n" +
                " On the first floor there is the room and hall where the handicraft products are exhibited, the bride room on the second floor and the hall where the ethnographic pieces belonging to the Ottoman period are displayed.";
            kemalSamancitextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            kemalSamancitextBox.RightToLeft = RightToLeft.No;

            guzelceHRlabel.Text = "Güzelce Hisar";
            guzelceHRlabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            guzelceHRltextBox.Text = "Located at only 2 places in the world (US and Turkey) remaining from millions of years ago \"Lava Rocks\" has the Guzelcehisar village yes it is a very special place that you are reading the wrong Güzelcehis.\r\nThe name comes from this beauty.\r\n" +
                "Natural beauty and the Mediterranean climate in some regions, mandarin and lemon trees and the Mediterranean Sea between the Black Sea is a unique paradise to live.";
            guzelceHRltextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            guzelceHRltextBox.RightToLeft = RightToLeft.No;

            kemerLabel.Text = "The Arch Bridge";
            kemerLabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            kemerTextBox.Text = "It was built by Çalıkoğlu Ibrahim Bey in 1872.\r\nOn three very solid feet made of lumped mortar and two pointed arches.\r\nIt is 42 meters long and 8.5 meters wide. It is said that thousands of white whites were added to make the mortar stronger during construction.";
            kemerTextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            kemerTextBox.RightToLeft = RightToLeft.No;
            
            orduYerilabel.Text = "Orduyeri Bridge";
            orduYerilabel.Font = new Font("Algerian", 14, FontStyle.Bold);
            orduYeritextBox.Font = new Font("Georgia", 14, FontStyle.Bold);
            orduYeritextBox.Text = "In 1887, under the leadership of Bolu Governor Ismail Kemal Bey, it was built with the help of the people.\r\n" +
                " Kocaçay is built on five solid feet of cut stone.\r\n" +
                "The first and second legs are on the side of the sea, and the road passes through.\r\n " +
                "The third and fourth feet are in tea, and the fifth foot is in the Orduyeri neighborhood.\r\n" +
                "Half - dome - shaped projections on both sides of the feet in the tea distribute the water on both sides and prevent the eruption of the feet.\r\n" +
                " 98 m.and 7,3 m.The upper part of the wooden bridge was reconstructed in 1957 as concrete.";
            orduYeritextBox.RightToLeft = RightToLeft.No;

            linkLabel1.Text = "Please click hear to see Amasra's 360 photos... ";

        }

        public void ArabicTranslation()
        {


            tarihVeKulturlabel.Text = "التاريخ والثقافة";
            tarihVeKulturlabel.Font = new Font("Arial", 15, FontStyle.Bold);

            tarihVeKulturtextBox.Text = "مصدر اسم بارتين:\r\n" +
                "مصدر اسم الذي تحول من \"PARTHENİA\" الى \"Bartın\" هو \"PARTHENİOS\".\r\n" +
                "وهو الاسم القديم لنهر بارتين, الذي يذكر في الأساطير الاغريقية أنه كانو يصفونه ب \"اله الماء\".\r\n" +
                "باختصار, اسم بارتين يأتي بمعنى \"اله الماء\" أو \"الماء المتدفقة الرائعة\". \r\n \r\n" + 
                "وتبلغ مساحتها 1,960 كم مربع ويبلغ عدد سكانها 184,178 نسمة، وعاصمتها مدينة \"بارتين \" التي تقع على بعد 14 كيلومترا من نهر \"بارتين \" الذي يعد مركزا لملاحة السفن التركية على ساحل البحر الأسود كما أنها على بعد 80 كم شرق \"زونجولداك\" \r\n \r\n"
                + "يعود تاريخ هذه المدينة إلى 1200 قبل الميلاد ووقعت تحت سيطرة الحثيين، والبهريغيانس، السيمريين، والليديين، والفرس، والمقدونيين. وأصبحت فيما بعد جزءا من الإمبراطورية الرومانية ثم البيزنطية إلى أن سقطت في أيدي الأتراك السلاجقة بين القرنين الحادي عشر والثالث عشر، حيث غزاها السلطان العثماني بايزيد الأول عام 1392. \r\n" +
                "واليوم \"بارتين \" هي عضو في الرابطة الأوروبية القائمة على المدن والمناطق التاريخية، وتضم معالم سياحية مميزة منها عدد هائل من المنازل الخشبية الفريدة التي تعرض فن العمارة الذي كان سائدا عبر تلك الحضارات التي توافدت على أرضها، هذه المنازل لا تتواجد بهذه الكمية وبهذا الترتيب إلا في \"بارتين \"، بالإضافة إلى وجود القلعة ، والأسواق، ونصب \"Kuskayasi\" الفريد من نوعه في العالم، والذي بني تكريما للإمبراطور الروماني الذي يحمل الاسم نفسه، وكان يدعو للسلام وتفادي الحروب، وعلى هذا النصب نقشت رسائل عديدة تحمل ذات الدعوة وموجودة حتى اليوم.\r\n \r\n" +
                "كما يوجد في المدينة كهف \" inziva\"، وقصر المجلس، وطريق الشرف والمسرح وجبانة (مقبرة) تحت الأرض. وكنيسة \"نيكولاس\" التي بنيت عام 1319 من قبل الطائفة اليونانية.";
            tarihVeKulturtextBox.Font = new Font("Arial", 15, FontStyle.Bold);
            tarihVeKulturtextBox.RightToLeft = RightToLeft.Yes;

            inkumulabel.Text = "شاطئ إنكومو";
            inkumulabel.Font = new Font("Arial", 14, FontStyle.Bold);
            inkumutextBox.Text = "\r\nشاطئ Inkumu هو منطقة جنة مخبأة في البحر الأسود حيث يلتقي 2.5 كم من اللونين الأخضر والأزرق.\r\n يقع على بعد 45 دقيقة من Amasra ، وهناك المطاعم والأسواق حيث يمكنك تلبية جميع احتياجاتك.";
            inkumutextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            inkumutextBox.RightToLeft = RightToLeft.Yes;

            ayaNikolaslabel.Text = "كنسية آية نيكولاس";
            ayaNikolaslabel.Font = new Font("Arial", 15, FontStyle.Bold);
            ayaNikolastextBox.Text = "\r\n تم بناء هذه الكنيسة التاريخية عام 1319 في وسط مدينة بارتين, وتم استخدامها كمحطة كهرباء لفترة اعتيارا من عام 1936 ، في عام 1955 تم افتتاحها كمنزل ثقافي.";
            ayaNikolastextBox.Font = new Font("Arial", 15, FontStyle.Bold);
            ayaNikolastextBox.RightToLeft = RightToLeft.Yes;

            kemalSamancilabel.Text =  "متحف كمال سامانجي أوغلو";
            kemalSamancilabel.Font = new Font("Arial", 14, FontStyle.Bold);
            kemalSamancitextBox.Text = "\r\n" + "وُلد كمال Samancıoğlu في بارتين وقد قام برئاسة البلدية لمدة 24 عامًا ، وعاش في  منزل خشبي تاريخي حيث أصبح متحف إثنوغرافي اليوم.\r\n" +
                "بالإضافة إلى ممتلكات كمال سامانشوغلو ، هناك حوالي 700 عمل إثنوغرافي تبرعت بها عائلات بارتين.\r\nيتكون المتحف من ثماني غرف وقاعة في ثلاثة طوابق.في الطابقين الأول والثاني ، توجد غرفة المعيشة اليومية وغرفة الدراسة في Kemal Samancıoğlu. \r\n" + 
                "وفي باقي الغرف يمكنكم رؤية الفنون اليدوية التي انتجوها أهل بارتن وبعض الاثار الاثنوغرافية العائدة للعصر العثماني.";
            kemalSamancitextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            kemalSamancitextBox.RightToLeft = RightToLeft.Yes;

            guzelceHRlabel.Text = "كوزيلجة هيسار";
            guzelceHRlabel.Font = new Font("Arial", 14, FontStyle.Bold);
            guzelceHRltextBox.Text = "\r\n\r\n"+"كوزيلجة هيسار هي منطقة ساحلية يوجد فيها \"الصخور الحممية التي بقيت من ملايين السنين ولا توجد إلا في مكانين في العالم فقط وهما(تركيا والولايات المتحدة الأمريكية)\".\r\n\r\n " +
                "اسمها يأتي من جمالها وسحر طبيعتها، فاسمها يعني\"القلعة الجميلة\".\r\n" +
                "وهية جنّة بالمساحات الخضراء الواسعة التي تغطيها, وبإطلالتها  على بعض مناطق اقليم البحر الأسود الرائعة, وبغناها بأشجار فواكه الليمون والماندلينا. \r\n";
            guzelceHRltextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            guzelceHRltextBox.RightToLeft = RightToLeft.Yes;

            kemerLabel.Text =  "جسر القوس (كمر كوبرو)";
            kemerLabel.Font = new Font("Arial", 15, FontStyle.Bold);
            kemerTextBox.Text = "\r\n" + "تم بناؤه من قبل Çalıkoğlu إبراهيم بيك في عام 1872. \r\nعلى ثلاثة أقدام صلبة جدا مصنوعة من حجر الهاون المقطوع واثنين من الأقواس المدببة.\r\nيبلغ طوله 42 مترًا وعرضه 8.5 متر\r\n. يقال إن الآلاف من بياض البيض أضيفت لجعل الهاون أقوى أثناء البناء. ";
            kemerTextBox.Font = new Font("Arial", 15, FontStyle.Bold);
            kemerTextBox.RightToLeft = RightToLeft.Yes;
            
            orduYerilabel.Text = "Orduyeri جسر";
            orduYerilabel.Font = new Font("Arial", 14, FontStyle.Bold);
            orduYeritextBox.Font = new Font("Arial", 14, FontStyle.Bold);
            orduYeritextBox.Text = "تم بناؤه  في عام 1887 تحت قيادة الحاكم بولو إسماعيل كمال بيك وبمساعدة الشعب. وتم تشييده في منطقة كوجاتشاي على خمسة أقدام صلبة من قطع الحجر." + "\r\n"+
                "الساقان الأولى والثانية من طرف منطقة يالي ، ومن بينهم يمر طريق." + "\r\n" +
                "أما الساقان الثالثة والرابعة في منطقة تشاي، والساق الخامسة في حي أوردو يري (أرض الجيش)." + "\r\n" +
                "تتشكل الاسقاطات التي في الساقان اللتان في طرف منطقة تشاي على شكل نصف قبة, وتوزع المياه على كلا الطرفين لمنع تآكل الطرف السفلي من الساقان." + "\r\n" +
                "وقد تم ترميم القسم الأعلى من هذا الجسر الذي طوله 98 م وعرضه 7,3 م بالاسمنت في عام 1957 الذي هو بالأساس مصنوع من الخشب.";
            orduYeritextBox.RightToLeft = RightToLeft.Yes;


            linkLabel1.Text = "...يرجى النقر هنا لمشاهدة صور مدينة بارتن بخاصية 360 درجة ";
        }



        public void TurkishTranslation()
        {
            tarihVeKulturtextBox.Text = "Bartın Adının Kaynağı \r\n " +
               "“PARTHENİA”dan Bartın’a dönüşen adın kaynağı “PARTHENİOS”tur.Bartın Irmağı’nın antik çağdaki adı olan Parthenios; Yunan mitolojisinde, Tanrıların Babası OKENAUS’un çocukları olan yüzlerce tanrıdan birisi ve “Sular Tanrısı”dır.\r\n" +
               "Kısacası Bartın ismi “Sular İlahı veya Muhteşem Akan Su” anlamlarına gelir." +
               "\r\nAntik çağda Parthenios adı verilen Bartın Irmağı’nın kenarında kurulan Bartın Kentinin PARTHENİA adıyla anıldığı ve bu ismin zamanla Bartın’a dönüştüğü yazılı kaynaklardan anlaşılmaktadır."
               + "Eski Çağlarda Bartın \r\n"
               + ".yy’da Hititler olduğu kabul edilmekte, daha sonra Bolu Havalisine yerleşen Bitinyalılar ile Kastamonu Havalisinde hüküm süren Paflagonyalıların, sınırlarını Parthenios’a kadar genişlettikleri böylece Bartın topraklarının bu iki egemenliğin sınırları içinde yer aldığı bilinmektedir.\r\n"
               + "M.Ö.12.yy. sonlarında Bithynie Bölgesindeki Bartın Friglerin, Paplagonie Bölgesindeki Amasra Fenikelilerin eline geçmiş, Fenikeliler; Amasra (Sesamos), Ereğli (Heraklia), Sinop (Sinope) ve Tekkeönü’nde (Kromna) ilk Sayda Kolonilerini oluşturmuşlardır.\r\n"
               + "M.Ö. 9.yy.da Akdeniz’deki güç dengelerinin bozulmasıyla Fenikeliler ve ortakları Karyalılar Amasra ve Kromna’yı terkettiler. Bartın ve çevresi, M.Ö. 7.yy. sonlarında Kimmerlerin, M.Ö. 6. yy.da Lidyalıların, M.Ö.547 yılında da Perslerin hakimiyetine girdi. 216 yıllık Pers döneminde Karadeniz Kolonileri Perslon dostluğu sayesinde uzun süre bu statülerini korudular.\r\n"
               + "M.Ö. 334 yılında, Makedonya Kralı İskender, Perslerin hakimiyetine son vererek bölgenin sahibi oldu.\r\n" +
               "Bartın ve Ulus’un yönetimini “General Eumenes”, Amasra ve Tekkeönü’nün yönetimini de Fridya Satrabına bıraktı. Ancak, Amasra yönetimi M.Ö. 302-286 yılları arasında el değiştirerek Kraliçe Amastris tarafından yönetilmeye başlandı. M.Ö. 12. yy’dan beri Sesamos adıyla anılan kent 16 yıllık Kraliçe Amastris Döneminden sonra kraliçenin adını aldı. \r\n" +
               "Bu dönemde; Kromna (Tekkeönü), Tios (Filyos-Hisarönü) ve Kyteros (Gideros) sitelerinden oluşan Symoikismos Siteler Birliğine Başkent oldu. \r|\n" +
               "M.Ö.286 yılında Kraliçe Amastris, oğulları tarafından bindiği gemi batırılmak suretiyle öldürülünce kent yeniden Eumenes’ce yönetilmeye başlandı. Amasra ve Bartın çevresi yöredeki savaşlar sonrasında M.Ö.279 yılında Pontus Krallığının egemenliğine girdi."
               + "CUMHURİYET DÖNEMİNDE BARTIN\r\n"
               + "1920 yılında Zonguldak Mutasarrıflığı’na bağlanan Bartın; 1924 yılında Zonguldak ilinin ilçesi oldu.\r\n" +
               "Bartın, 07 Eylül 1991 tarihinde 28.08.1991 tarih ve 3760 sayılı yasayla İL statüsüne kavuştu.\r\n" +
               "Bartın İlinin Merkez, Amasra, Ulus ve Kurucaşile olmak üzere 4 ilçesi; Kozcağız, Arıt, Hasankadı,Kumluca ve Abdipaşa olmak üzere 5 beldesi ve 262 köyü vardır.";

            kemerTextBox.Text = "1872 yılında Çalıkoğlu İbrahim Bey tarafından yaptırılmıştır. \r\nKocanazçayı üzerinde, kesme taştan harçla yapılan çok sağlam üç ayak ve iki sivri kemer üzerine kurulmuştur. \r\nBoyu 42 m, genişliği 8.5 m'dir. \r\nİnşaat sırasında harcın daha güçlü olmasını sağlamak için içerisine binlerce yumurta akı katıldığı söylenmektedir.";

            ayaNikolastextBox.Text = "\r\n1319 yılında Bartın merkezinde yaptırılan ve 1936 yılından itibaren bir süre elektrik santralı olarak kullanılan bu tarihi yapı, 1955 yılında restore edilmiş olup, kültür evi olarak hizmete açılmıştır.";

            kemalSamancitextBox.Text = "Bartın’da 24 yıl Belediye Başkanlığı yapan Kemal Samancıoğlu’nun doğup yaşadığı tarihi ahşap ev,günümüzde Etnografya Müzesi olarak hizmet vermektedir\r\n" +
                "Kemal Samancıoğlu’nun eşyalarının yanı sıraBartın’lı ailelerin bağışladığı yaklaşık 700 etnoğrafik eser barındırmaktadır. " +
                "\r\nMüze, üç katta toplam sekiz oda ve salondan oluşmakta; birinci ve ikinci katlarda Kemal Samancıoğlu’nun günlük yaşam odası ve çalışma odası yer almaktadır.\r\n" +
                " Giriş katta yönetim odası ve mutfak, birinci katta Bartın kadınlarının üretkenliğini yansıtan el sanatları ürünlerinin sergilendiği oda ve salon, ikinci katta gelin odası ve Osmanlı dönemlerine ait etnografik eserlerin sergilendiği salon bulunmaktadır.";

            orduYeritextBox.Text = "1887 yılında Bolu Mutasarrıfı İsmail Kemal Bey’in önderliğinde, halkın yardımıyla yapılmıştır. Kocaçay üzerinde, kesme taştan beş sağlam ayak üzerine kurulmuştur\r\n" +
                "Birinci ve ikinci ayaklar Yalı tarafında olup,arasından yol geçmektedir.\r\n" +
                " Üçüncü ve dördüncü ayaklar çay içinde, beşinci ayak ise Orduyeri Mahallesi tarafındadır. Çay içindeki ayakların iki tarafında yarım kubbe şeklindeki çıkıntılar, suları iki tarafa dağıtmakta ve ayakların dibinin aşınmasını önlemektedir\r\n" +
                " 98 m. boyunda ve 7,3 m. genişliğindeki köprünün ahşap olan üst kısmı 1957 yılında beton olarak yeniden yapılmıştır";

            inkumutextBox.Text = "\r\nİnkumu Plajı 2.5 kilometre uzunluğunda yeşilin ve mavinin buluştuğu karadenizde saklı kalmış bir cennet bölgesidir.\r\n Amasra’dan 45dk sürüş uzaklığında bulunan İnkumu sahilinde dilediğiniz tüm ihtiyaçları karşılayabileceğiniz restoran ve marketler bulunmaktadır.";
            guzelceHRltextBox.Text = "Dünya’da sadece 2 yerde bulunan (ABD ve Türkiye) milyonlarca yıl öncesinden kalan “Lav Kayaları”na sahiptir Güzelcehisar köyü evet yanlış okumadınız yani çok özel bir yerdir Güzelcehisar. \r\nİsmide bu güzelliğinden gelmektedir aslında. \r\nDoğal güzellikleri ve bazı bölgelerinde görülen akdeniz  " +
                "iklimi, mandalina ve limon ağaçlarıyla Karadeniz’in yeşilliklerinin arasında Akdeniz havasını yaşatan eşsiz bir cennet.";

        }

        public void goToBrowser()
        {
            maps map = new maps();
            map.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            maps.mapLink = "https://maps.app.goo.gl/JiNzv4fMtPjrvYqQ9";
            goToBrowser();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            maps.mapLink = "https://goo.gl/maps/E27JGcus8FnqeeaN6";
            goToBrowser();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            maps.mapLink = "https://goo.gl/maps/Ypio5bgDQHSTxSsp9";
            goToBrowser();
        }
        private void inkumupictureBox_Click(object sender, EventArgs e)
        {
            maps.mapLink = "https://goo.gl/maps/gLrZwAZ3aZa5obxo9";
            goToBrowser();
        }

        private void guzelceHRlpictureBox_Click(object sender, EventArgs e)
        {
            maps.mapLink = "https://goo.gl/maps/7x9xNGZXM1Ka475n6";
            goToBrowser();
        }

        private void orduYeripictureBox_Click(object sender, EventArgs e)
        {
            maps.mapLink = "https://goo.gl/maps/VUpenT6J6Asy1EKv8";
            goToBrowser();
        }

        private void kemerPictureBox_Click(object sender, EventArgs e)
        {
            maps.mapLink = "https://goo.gl/maps/fmyweRtCY5pmtJpn6";
            goToBrowser();
        }

        private void sehir_bartin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        

        private void sehir_bartin_SizeChanged(object sender, EventArgs e)
        {
            
            if (firstSize != 0) {
                if (Width >= 1500)
                {
                    button122.Height += 700;
                } else if (Width < 949)
                {
                    button122.Height -= 700;
                }
            }
            firstSize++;
        }
        
        private void sehir_bartin_Load(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("http://www.bartinsanaltur.com/");
        }
    }




}

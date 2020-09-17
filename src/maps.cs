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
    public partial class maps : Form
    {
        public static string mapLink = "";
        public maps()
        {
            InitializeComponent();
            //homeForm.mapsOpend++; Daha Sonra yapacağım...
        }

        private void maps_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(mapLink);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

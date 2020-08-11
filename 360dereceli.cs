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
    public partial class _360dereceli : Form
    {
        public static string foto360 = "";

        public _360dereceli()
        {
            InitializeComponent();
        }

        private void maps_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(foto360);
        }
    }
}

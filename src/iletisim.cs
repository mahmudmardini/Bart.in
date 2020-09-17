using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Bartin
{
    public partial class iletisim : Form 
    {
        public iletisim()
        {
            InitializeComponent();
            groupBox1.Hide();
        }

        OleDbConnection Con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\mahmo\\source\\repos\\Bartin\\Bartin\\bin\\Debug\\DataBase\\yorumlar.mdb");
        OleDbConnection Con2 = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\mahmo\\source\\repos\\Bartin\\Bartin\\bin\\Debug\\DataBase\\iletisim.mdb");

        int count = 0;

        private void iletisim_Load(object sender, EventArgs e)
        {
            groupBox1.Hide();
        }

        private void KaydetButton_Click(object sender, EventArgs e)
        {
            Con.Open();
            OleDbCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into kullanicilar values('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            Con.Close();

            Con2.Open();
            OleDbCommand cmd2 = Con2.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "insert into kullanicilar values('" + textBox1.Text + "','" + textBox3.Text + "')";
            cmd2.ExecuteNonQuery();
            Con2.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            MessageBox.Show("kaydedildi");
        }

        private void GosterButton_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            OleDbCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kullanicilar";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Con.Close();
        }



        private void SilButton_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            OleDbCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from kullanicilar where Ad='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            Con.Close();

            Con2.Open();
            OleDbCommand cmd2 = Con2.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "delete from kullanicilar where Ad='" + textBox1.Text + "'";
            cmd2.ExecuteNonQuery();
            Con2.Close();

            MessageBox.Show("Islem tamamlandi");
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                groupBox1.Show();
            else
                groupBox1.Hide();
        }

        private void GuncelButton_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            OleDbCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update kullanicilar set Yorum='" + textBox2.Text + "' where Ad='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Işlem tamamlandı");
        }

        private void AraButton_Click(object sender, EventArgs e)
        {
            count = 0;
            Con.Open();
            OleDbCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kullanicilar where Ad='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;
            Con.Close();

            if (count == 0)
                MessageBox.Show("bulunmadi");
        }

        private void HepsiSilButton_Click_1(object sender, EventArgs e)
        {
            Con.Open();
            OleDbCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete * from kullanicilar";
            cmd.ExecuteNonQuery();
            Con.Close();

            Con2.Open();
            OleDbCommand cmd2 = Con2.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "delete * from kullanicilar";
            cmd2.ExecuteNonQuery();
            Con2.Close();

            MessageBox.Show("Islem tamamlandi");
        }

        
    }
}

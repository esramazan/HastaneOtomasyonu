using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastahane
{
    public partial class BölEkle : Form
    {
        public BölEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form btab = new BölTab();
            btab.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=CASPER_NIRVANA\\SQLEXPRESS;Initial Catalog=Hastahane;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("insert into Bolum(Bolum_id,Bolum_adi) values (@Bolum_id,@Bolum_adi)", baglanti);

            cmd.Parameters.Add(new SqlParameter("@Bolum_id", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@Bolum_adi", textBox2.Text));

            baglanti.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yeni bölüm kaydedilmiştir.");
            baglanti.Close();

        }
    }
}

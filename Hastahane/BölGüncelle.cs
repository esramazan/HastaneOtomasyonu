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
    public partial class BölGüncelle : Form
    {
        public BölGüncelle()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form bölt = new BölTab();
            bölt.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=CASPER_NIRVANA\\SQLEXPRESS;Initial Catalog=Hastahane;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("update Bolum set Bolum_adi=@Bolum_adi where Bolum_id=@Bolum_id", baglanti);

            cmd.Parameters.Add(new SqlParameter("@Bolum_id", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@Bolum_adi", textBox2.Text));

            baglanti.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Bölüm adı değiştirilmiştir.");
            baglanti.Close();


        }

        private void BölGüncelle_Load(object sender, EventArgs e)
        {

        }
    }
}

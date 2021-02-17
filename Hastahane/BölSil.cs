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
    public partial class BölSil : Form
    {
        public BölSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Bölümü Silmek İstediğinizden Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=CASPER_NIRVANA\\SQLEXPRESS;Initial Catalog=Hastahane;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("sp_BolumSil @Bolum_id", baglanti);
                cmd.Parameters.Add(new SqlParameter("@Bolum_id", textBox1.Text));

                baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Bölüm Silinmiştir.");
                baglanti.Close();
            }
            else if (cevap == DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form bta = new BölTab();
            bta.Visible = true;
        }
    }
}

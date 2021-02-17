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
    public partial class Randevu_Sil : Form
    {
        public Randevu_Sil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Randevunuzu Silmek İstediğinizden Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=CASPER_NIRVANA\\SQLEXPRESS;Initial Catalog=Hastahane;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("sp_RandevuSil @tc", baglanti);
                cmd.Parameters.Add(new SqlParameter("@tc", maskedTextBox1.Text));

                baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Randevunuz İptal Edilmiştir Sağlıklı Günler Dileriz");
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
    }
}

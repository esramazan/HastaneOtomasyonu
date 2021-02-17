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
    public partial class doksil : Form
    {
        public doksil()
        {
            InitializeComponent();
        }

        private void doksil_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastahaneDataSet10.Doktor' table. You can move, or remove it, as needed.
            this.doktorTableAdapter.Fill(this.hastahaneDataSet10.Doktor);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Doktoru Silmek İstediğinizden Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection("Data Source=CASPER_NIRVANA\\SQLEXPRESS;Initial Catalog=Hastahane;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("sp_DoktorSil @Doktor_id", baglanti);
                cmd.Parameters.Add(new SqlParameter("@Doktor_id", textBox1.Text));

                baglanti.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşleminiz gerçekleştirilmiştir.");
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

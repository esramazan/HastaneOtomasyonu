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
    public partial class Randevu_Al : Form
    {
        public Randevu_Al()
        {
            InitializeComponent();
        }

        private void Randevu_Al_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastahaneDataSet4.Doktor' table. You can move, or remove it, as needed.
            this.doktorTableAdapter.Fill(this.hastahaneDataSet4.Doktor);
            // TODO: This line of code loads data into the 'hastahaneDataSet3.Bolum' table. You can move, or remove it, as needed.
            this.bolumTableAdapter.Fill(this.hastahaneDataSet3.Bolum);


            label10.Visible = false;
            dataGridView1.Visible = false;
            comboBox1.Text = "Seçiniz...";
            comboBox2.Text = "Seçiniz...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            dataGridView1.Visible = true;

            SqlConnection baglanti = new SqlConnection("Data Source=CASPER_NIRVANA\\SQLEXPRESS;Initial Catalog=Hastahane;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select Doktor_id,Ad,Cinsiyet from Doktor where Bolum_id=@Bolum_id", baglanti);
            cmd.Parameters.Add(new SqlParameter("@Bolum_id", comboBox1.SelectedValue));

            baglanti.Open();
            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            baglanti.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=CASPER_NIRVANA\\SQLEXPRESS;Initial Catalog=Hastahane;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("insert into Hasta_kayit(Hasta_id,Tc,Adi,Soyadi,Cinsiyet,Randevu_tarihi,Cep_Nu,Doktor_id,Bolum_id) values (@Hasta_id,@Tc,@Adi,@Soyadi,@Cinsiyet,@Randevu_tarihi,@Cep_Nu,@Doktor_id,@Bolum_id)", baglanti);
           
            cmd.Parameters.Add(new SqlParameter("@Hasta_id", textBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@Tc", maskedTextBox1.Text));
            cmd.Parameters.Add(new SqlParameter("@Adi", textBox2.Text));
            cmd.Parameters.Add(new SqlParameter("@Soyadi", textBox3.Text));
            cmd.Parameters.Add(new SqlParameter("@Cinsiyet", textBox4.Text));
            cmd.Parameters.Add(new SqlParameter("@Randevu_tarihi", maskedTextBox3.Text));
            cmd.Parameters.Add(new SqlParameter("@Cep_Nu", textBox5.Text));
            cmd.Parameters.Add(new SqlParameter("@Doktor_id", comboBox2.SelectedValue)); 
            cmd.Parameters.Add(new SqlParameter("@Bolum_id", comboBox1.SelectedValue));


            baglanti.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kaydınız Tamamlanmıştır. Randevu Saatinden Yarım Saat Önce Gelmeyi Unutmayınız.");
            baglanti.Close();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hastahane
{
    public partial class Hastahane_yonetim : Form
    {
        public Hastahane_yonetim()
        {
            InitializeComponent();
        }

        private void Hastahane_yonetim_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastahaneDataSet7.Hasta_kayit' table. You can move, or remove it, as needed.
            this.hasta_kayitTableAdapter.Fill(this.hastahaneDataSet7.Hasta_kayit);
            button3.Visible = true;
            button4.Visible = true;
            button6.Visible = true;

            button1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;

            hasta_kayitBindingNavigator.Visible = false;
            hasta_kayitDataGridView.Visible = false;

        }

        private void dOKTORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = true;
            button5.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            button6.Visible = false;
            hasta_kayitBindingNavigator.Visible = false;
            hasta_kayitDataGridView.Visible = false;

        }

        private void hASTAKAYITBİLGİLERİNİGÜNCELLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button6.Visible = false;

            hasta_kayitBindingNavigator.Visible = true;
            hasta_kayitDataGridView.Visible = true;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button3.Visible = true;
            button4.Visible = true;
            button6.Visible = true;

            button1.Visible = false;
            button2.Visible = false;
            button5.Visible = false;
            hasta_kayitBindingNavigator.Visible = false;
            hasta_kayitDataGridView.Visible = false;
        }

        private void hasta_kayitBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hasta_kayitBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hastahaneDataSet7);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ekle = new DokEkle();
            ekle.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form bölekle = new BölEkle();
            bölekle.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form doksil = new doksil();
            doksil.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form dkgncll = new DokGüncelle();
            dkgncll.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form bölsil = new BölSil();
            bölsil.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form blgn = new BölGüncelle();
            blgn.Visible = true;
        }


    }
}

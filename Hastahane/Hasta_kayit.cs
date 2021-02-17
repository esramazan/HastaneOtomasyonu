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
    public partial class Hasta_kayit : Form
    {
        public Hasta_kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form randal = new Randevu_Al();
            randal.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form randsil = new Randevu_Sil();
            randsil.Visible = true;
        }
    }
}

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
    public partial class DokGüncelle : Form
    {
        public DokGüncelle()
        {
            InitializeComponent();
        }

        private void doktorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doktorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hastahaneDataSet7);

        }

        private void DokGüncelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastahaneDataSet7.Doktor' table. You can move, or remove it, as needed.
            this.doktorTableAdapter.Fill(this.hastahaneDataSet7.Doktor);

        }
    }
}

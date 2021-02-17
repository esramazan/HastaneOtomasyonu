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
    public partial class BölTab : Form
    {
        public BölTab()
        {
            InitializeComponent();
        }

        private void bolumBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bolumBindingSource.EndEdit();

        }

        private void BölTab_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hastahaneDataSet9.Bolum' table. You can move, or remove it, as needed.
            this.bolumTableAdapter.Fill(this.hastahaneDataSet9.Bolum);

        }
    }
}

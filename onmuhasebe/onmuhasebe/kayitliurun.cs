using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace onmuhasebe
{
    public partial class kayitliurun : Form
    {
        public kayitliurun()
        {
            InitializeComponent();
        }

        private void kayitliurun_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebedataDataSet3.urun' table. You can move, or remove it, as needed.
            this.urunTableAdapter.Fill(this.onmuhasebedataDataSet3.urun);

        }
    }
}

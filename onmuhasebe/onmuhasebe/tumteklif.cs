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
    public partial class tumteklif : Form
    {
        public tumteklif()
        {
            InitializeComponent();
        }

        private void tumteklif_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebedataDataSet8.alinanteklifler' table. You can move, or remove it, as needed.
            this.alinantekliflerTableAdapter.Fill(this.onmuhasebedataDataSet8.alinanteklifler);

        }
    }
}

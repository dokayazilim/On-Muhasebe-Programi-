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
    public partial class tumsenet : Form
    {
        public tumsenet()
        {
            InitializeComponent();
        }

        private void tumsenet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebedataDataSet7.alinansenetler' table. You can move, or remove it, as needed.
            this.alinansenetlerTableAdapter.Fill(this.onmuhasebedataDataSet7.alinansenetler);

        }
    }
}

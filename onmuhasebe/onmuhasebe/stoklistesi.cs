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
    public partial class stoklistesi : Form
    {
        public stoklistesi()
        {
            InitializeComponent();
        }

        private void stoklistesi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebedataDataSet2.yenistok' table. You can move, or remove it, as needed.
            this.yenistokTableAdapter.Fill(this.onmuhasebedataDataSet2.yenistok);

        }
    }
}

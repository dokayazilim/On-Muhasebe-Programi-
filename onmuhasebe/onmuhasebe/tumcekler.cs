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
    public partial class tumcekler : Form
    {
        public tumcekler()
        {
            InitializeComponent();
        }

        private void tumcekler_Load(object sender, EventArgs e)
        {
           
            
            // TODO: This line of code loads data into the 'onmuhasebedataDataSet4.alinancekler' table. You can move, or remove it, as needed.
            this.alinanceklerTableAdapter.Fill(this.onmuhasebedataDataSet4.alinancekler);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class stokalis : Form
    {
        public stokalis()
        {
            InitializeComponent();
        }

        private void stokalis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet14.yenistok' table. You can move, or remove it, as needed.
            this.yenistokTableAdapter1.Fill(this.onmuhasebesmartdataDataSet14.yenistok);
            label2.Visible = false;
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (label2.Text == "alisislemi")
            {
                alisislemi frm2 = (alisislemi)Application.OpenForms["alisislemi"];
                frm2.unvani.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.stokadetlabel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                
                this.Hide();
            }

            if (label2.Text == "satisislemi")
            {
                satisislemi frm2 = (satisislemi)Application.OpenForms["satisislemi"];
                frm2.unvani.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.stokadetlabel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                
                this.Hide();
            }

            if (label2.Text == "alisislemitaksit")
            {
                alisislemi frm2 = (alisislemi)Application.OpenForms["alisislemi"];
                frm2.unvanitaksit.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.stokadetlabel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                
                this.Hide();
            }

            if (label2.Text == "alisislemipesin")
            {
                alisislemi frm2 = (alisislemi)Application.OpenForms["alisislemi"];
                frm2.unvanipesin.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.stokadetlabel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                
                this.Hide();
            }

            if (label2.Text == "satisislemitaksit")
            {
                satisislemi frm2 = (satisislemi)Application.OpenForms["satisislemi"];
                frm2.unvanitaksit.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.stokadetlabel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                
                this.Hide();
            }

            if (label2.Text == "satisislemipesin")
            {
                satisislemi frm2 = (satisislemi)Application.OpenForms["satisislemi"];
                frm2.unvanipesin.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm2.stokadetlabel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(stokkodu.Checked) 
            {
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = dataGridView1.DataSource;

                sr2.Filter = "stokkodu like '%" + ara.Text + "%'";
                dataGridView1.DataSource = sr2;
            }
            if (stokadi.Checked)
            {
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = dataGridView1.DataSource;

                sr2.Filter = "stokadi like '%" + ara.Text + "%'";
                dataGridView1.DataSource = sr2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stokkodu.Checked = false;
            stokadi.Checked = false;
            ara.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

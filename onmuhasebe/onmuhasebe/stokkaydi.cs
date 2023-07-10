using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;

namespace onmuhasebe
{
    public partial class stokkaydi : Form
    {
        public stokkaydi()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void stokkaydi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet15.yenistok' table. You can move, or remove it, as needed.
            this.yenistokTableAdapter1.Fill(this.onmuhasebesmartdataDataSet15.yenistok);
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

                double sonuc = Convert.ToDouble(alisfiyati.Text);
                int kdv = int.Parse(kdvoranialis.Text);
                double carpim;
                carpim = (kdv * sonuc) / 100 + (sonuc);
                alisfiyati.Text = carpim.ToString("c");

                double sonuc2 = Convert.ToDouble(satisfiyati.Text);
                int kdv2 = int.Parse(kdvoranisatis.Text);
                double carpim2;
                carpim2 = (kdv2 * sonuc2) / 100 + (sonuc2);
                satisfiyati.Text = carpim2.ToString("c");

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into yenistok(stokkodu,stokadi,birimi,alisfiyatitl,kdvoranialis,karorani,satisfiyatitl,kdvoranisatis) values ('" + stokkodu.Text + "','" + stokadi.Text + "','" + birimi.Text + "','" + alisfiyati.Text + "','" + kdvoranialis.Text + "','" + karorani.Text + "','" + satisfiyati.Text + "','" + kdvoranisatis.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    stokkodu.Clear();
                    stokadi.Clear();
                    birimi.SelectedIndex = -1;
                    alisfiyati.Clear();
                    kdvoranialis.SelectedIndex = -1;
                    karorani.Clear();
                    satisfiyati.Clear();
                    kdvoranisatis.SelectedIndex = -1;
                    


                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }
        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from yenistok", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stokkodu.Clear();
            stokadi.Clear();
            birimi.SelectedIndex = -1;
            alisfiyati.Clear();
            kdvoranialis.SelectedIndex = -1;
            karorani.Clear();
            satisfiyati.Clear();
            kdvoranisatis.SelectedIndex = -1;

        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stokkodu.Clear();
            stokadi.Clear();
            birimi.SelectedIndex = -1;
            alisfiyati.Clear();
            kdvoranialis.SelectedIndex = -1;
            karorani.Clear();
            satisfiyati.Clear();
            kdvoranisatis.SelectedIndex = -1;
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

                double sonuc = Convert.ToDouble(alisfiyati.Text);
                alisfiyati.Text = sonuc.ToString("c");
                double sonuc2 = Convert.ToDouble(satisfiyati.Text);
                satisfiyati.Text = sonuc2.ToString("c");

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into yenistok(stokkodu,stokadi,birimi,alisfiyatitl,kdvoranialis,karorani,satisfiyatitl,kdvoranisatis) values ('" + stokkodu.Text + "','" + stokadi.Text + "','" + birimi.Text + "','" + alisfiyati.Text + "','" + kdvoranialis.Text + "','" + karorani.Text + "','" + satisfiyati.Text + "','" + kdvoranisatis.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    stokkodu.Clear();
                    stokadi.Clear();
                    birimi.SelectedIndex = -1;
                    alisfiyati.Clear();
                    kdvoranialis.SelectedIndex = -1;
                    karorani.Clear();
                    satisfiyati.Clear();
                    kdvoranisatis.SelectedIndex = -1;



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (rdstokkodu.Checked)
            {
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = dataGridView1.DataSource;

                sr2.Filter = "stokkodu like '%" + ara.Text + "%'";
                dataGridView1.DataSource = sr2;
            }
            if (rdstokadi.Checked)
            {
                BindingSource sr2 = new BindingSource();
                sr2.DataSource = dataGridView1.DataSource;

                sr2.Filter = "stokadi like '%" + ara.Text + "%'";
                dataGridView1.DataSource = sr2;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydınız silinecek! Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebedata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("delete from yenistok where stokkodu='" + stokkodu.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    stokkodu.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Create string to draw.
            String drawString = "Rapor";

            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont2 = new Font("Arial", 8);
            SolidBrush drawBrush2 = new SolidBrush(Color.Black);

            // Create rectangle for drawing.
            float x = 50.0F;
            float y = 50.0F;
            float width = 700.0F;
            float height = 30.0F;
            RectangleF drawRect = new RectangleF(x, y, width, height);

            // Draw rectangle to screen.
            Pen blackPen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            StringFormat drawFormat2 = new StringFormat();
            drawFormat2.Alignment = StringAlignment.Near;

            //yazı draw string...

            String drawyazi = "Stok Kodu : " + stokkodu.Text;
            String drawyazi2 = "Stok Adı : " + stokadi.Text;
            String drawyazi3 = "Birimi : " + birimi.Text;
            String drawyazi4 = "Sayısı : " + karorani.Text;
            String drawyazi5 = "Alış Fiyatı : " + alisfiyati.Text;
            String drawyazi6 = "Satış Fiyatı : " + satisfiyati.Text;


            // Create font and brush.
            Font drawFon = new Font("Arial", 12);
            SolidBrush drawfirca = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(50.0F, 90.0F);
            PointF drawPoint2 = new PointF(50.0F, 120.0F);
            PointF drawPoint3 = new PointF(50.5F, 150.0F);
            PointF drawPoint4 = new PointF(590.0F, 90.0F);
            PointF drawPoint5 = new PointF(590.0F, 120.0F);
            PointF drawPoint6 = new PointF(590.0F, 150.0F);


            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawRect, drawFormat);
            e.Graphics.DrawString(drawyazi, drawFon, drawBrush, drawPoint, drawFormat2);
            e.Graphics.DrawString(drawyazi2, drawFon, drawBrush, drawPoint2, drawFormat2);
            e.Graphics.DrawString(drawyazi3, drawFon, drawBrush, drawPoint3, drawFormat2);
            e.Graphics.DrawString(drawyazi4, drawFon, drawBrush, drawPoint4, drawFormat2);
            e.Graphics.DrawString(drawyazi5, drawFon, drawBrush, drawPoint5, drawFormat2);
            e.Graphics.DrawString(drawyazi6, drawFon, drawBrush, drawPoint6, drawFormat2);
        }
    }
}

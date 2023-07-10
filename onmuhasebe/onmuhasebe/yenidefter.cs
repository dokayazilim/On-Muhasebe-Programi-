using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace onmuhasebe
{
    public partial class yenidefter : Form
    {
        public yenidefter()
        {
            InitializeComponent();
        }

        private void yenidefter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet22.gidersayfasi' table. You can move, or remove it, as needed.
            this.gidersayfasiTableAdapter1.Fill(this.onmuhasebesmartdataDataSet22.gidersayfasi);
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet21.gelirsayfasi' table. You can move, or remove it, as needed.
            this.gelirsayfasiTableAdapter1.Fill(this.onmuhasebesmartdataDataSet21.gelirsayfasi);
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                if (belgeno.Text == "")
                {
                    MessageBox.Show("Lütfen Belge No alanını boş geçmeyiniz!", "Uyarı");
                }
                else
                {
                    try
                    {
                        OleDbConnection baglanti;
                        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                        baglanti.Open();

                        OleDbCommand kayit = new OleDbCommand();
                        kayit.CommandText = "INSERT INTO gelirsayfasi(tarih,belgeno)VALUES('" + tarih.Text + "','" + belgeno.Text + "')";
                        kayit.Connection = baglanti;
                        kayit.ExecuteNonQuery();
                        baglanti.Close();
                        listele();


                    }
                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
               }
            
        }
        public void listele()
        {
            OleDbConnection baglanti;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=onmuhasebesmartdata.accdb");
            DataTable tablo = new DataTable();
            tablo.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select * from gelirsayfasi", baglanti);
            adpt.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

                if (belgeno.Text == "")
                {
                    MessageBox.Show("Lütfen Belge No alanını boş geçmeyiniz!", "Uyarı");
                }
                else
                {
                    try
                    {
                        OleDbConnection baglanti;
                        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                        baglanti.Open();

                        OleDbCommand kayit = new OleDbCommand();
                        kayit.CommandText = "INSERT INTO gelirsayfasi(tarih,belgeno)VALUES('" + tarih.Text + "','" + belgeno.Text + "')";
                        kayit.Connection = baglanti;
                        kayit.ExecuteNonQuery();
                        baglanti.Close();
                        listele();


                    }
                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string col2, col3, col4, col5, col6, col7, col8;

            col2 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
            col3 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
            col4 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem...
            col5 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // kdv...
            col6 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fiyat...
            col7 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
            col8 = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...

            int cl1 = int.Parse(col5);
            int cl2 = int.Parse(col6);

            int kdvsi = (cl1 * cl2) / 100;
            int toplam = cl2 + kdvsi;

            

            double sonuctpl = Convert.ToDouble(col6);
            int kdv = int.Parse(col5);
            double carpim;
            carpim = (kdv * sonuctpl) / 100 + (sonuctpl);
            col8 = carpim.ToString("c");


            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "Update gelirsayfasi set belgeno='" + belgeno.Text + "', aciklama='" + Convert.ToString(col2) + "', miktar='" + Convert.ToString(col3) + "', islem='" + Convert.ToString(col4) + "', kdv='" + Convert.ToString(col5) + "', kdvsiztutar='" + Convert.ToString(col6) + "', kdvlitutar='" + Convert.ToString(kdvsi) + "', toplamtutar='" + Convert.ToString(toplam) + "' Where belgeno='" + belgeno.Text + "'";
                string kmt = "Select sum(toplamtutar) from gelirsayfasi";
                string kmt2 = "Select sum(kdvsiztutar) from gelirsayfasi";
                string kmt3 = "Select sum(kdvlitutar) from gelirsayfasi";
                string kmt4 = "Select sum(kdvlitutar) from gelirsayfasi";
                OleDbCommand komutsatir = new OleDbCommand(komut, con);


                komutsatir.ExecuteNonQuery();
                OleDbCommand kmtsatir = new OleDbCommand(kmt, con);
                double sonuc = Convert.ToDouble(kmtsatir.ExecuteScalar());
                geneltoplam.Text = sonuc.ToString("c");
                kmtsatir.ExecuteNonQuery();
                OleDbCommand kmtsatir2 = new OleDbCommand(kmt2, con);
                double sonuc2 = Convert.ToDouble(kmtsatir2.ExecuteScalar());
                toplamtutari.Text = sonuc2.ToString("c");
                kmtsatir2.ExecuteNonQuery();
                OleDbCommand kmtsatir3 = new OleDbCommand(kmt3, con);
                double sonuc3 = Convert.ToDouble(kmtsatir3.ExecuteScalar());
                kdvtoplami.Text = sonuc3.ToString("c");
                kmtsatir3.ExecuteNonQuery();
                OleDbCommand kmtsatir4 = new OleDbCommand(kmt4, con);
                double sonuc4 = Convert.ToDouble(kmtsatir4.ExecuteScalar());
                hasilatkdv.Text = sonuc4.ToString("c");
                kmtsatir4.ExecuteNonQuery();
                con.Close();
                oncekidonemtoplami.Text = "0,00 TL";
                listele();

                MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Kayıt İşlemi");



            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string col2, col3, col4, col5, col6, col7, col8;

            col2 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
            col3 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
            col4 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem...
            col5 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // kdv...
            col6 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fiyat...
            col7 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
            col8 = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar..

            Microsoft.Office.Interop.Excel._Application exc = new Microsoft.Office.Interop.Excel.Application();
            exc.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook kitap = exc.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet shee = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range ran;
            ran = shee.get_Range("B2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Tarih");
            ran = shee.get_Range("C2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "BelgeNo");
            ran = shee.get_Range("D2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Açıklama");
            ran = shee.get_Range("E2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Miktar");
            ran = shee.get_Range("F2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "İşlem");
            ran = shee.get_Range("B4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "KDV");
            ran = shee.get_Range("C4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Fiyat");
            ran = shee.get_Range("D4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "KDVsi");
            ran = shee.get_Range("E4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "ToplamTutar");
            ran = shee.get_Range("B3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, tarih.Text);
            ran = shee.get_Range("C3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, belgeno.Text);
            ran = shee.get_Range("D3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col2);
            ran = shee.get_Range("E3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col3);
            ran = shee.get_Range("F3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col4);
            ran = shee.get_Range("B5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col5);
            ran = shee.get_Range("C5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col6);
            ran = shee.get_Range("D5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col7);
            ran = shee.get_Range("E5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col8);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

                if (belgenogider.Text == "")
                {
                    MessageBox.Show("Lütfen Belge No alanını boş geçmeyiniz!", "Uyarı");
                }
                else
                {

                    try
                    {
                        OleDbConnection baglanti;
                        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                        baglanti.Open();

                        OleDbCommand kayit = new OleDbCommand();
                        kayit.CommandText = "INSERT INTO gidersayfasi(tarih,belgeno)VALUES('" + tarihgider.Text + "','" + belgenogider.Text + "')";
                        kayit.Connection = baglanti;
                        kayit.ExecuteNonQuery();
                        baglanti.Close();
                        listele2();



                    }
                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
                }
            
        }
        public void listele2()
        {
            OleDbConnection baglanti;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=onmuhasebesmartdata.accdb");
            DataTable tablo = new DataTable();
            tablo.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select * from gidersayfasi", baglanti);
            adpt.Fill(tablo);
            dataGridView2.DataSource = tablo;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string col2, col3, col4, col5, col6, col7, col8;

            col2 = dataGridView2[2, dataGridView2.CurrentCell.RowIndex].Value.ToString(); // açıklama..
            col3 = dataGridView2[3, dataGridView2.CurrentCell.RowIndex].Value.ToString(); // miktar...
            col4 = dataGridView2[4, dataGridView2.CurrentCell.RowIndex].Value.ToString(); // işlem...
            col5 = dataGridView2[5, dataGridView2.CurrentCell.RowIndex].Value.ToString();  // kdv...
            col6 = dataGridView2[6, dataGridView2.CurrentCell.RowIndex].Value.ToString(); // fiyat...
            col7 = dataGridView2[7, dataGridView2.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
            col8 = dataGridView2[8, dataGridView2.CurrentCell.RowIndex].Value.ToString(); // toplam tutar...

            int cl1 = int.Parse(col5);
            int cl2 = int.Parse(col6);

            int kdvsi = (cl1 * cl2) / 100;
            int toplam = cl2 + kdvsi;



            try
            {
                OleDbConnection con = new OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;";
                con.Open();

                string komut = "Update gidersayfasi set belgeno='" + belgenogider.Text + "', aciklama='" + Convert.ToString(col2) + "', miktar='" + Convert.ToString(col3) + "', islem='" + Convert.ToString(col4) + "', kdv='" + Convert.ToString(col5) + "', kdvsiztutar='" + Convert.ToString(col6) + "', kdvlitutar='" + Convert.ToString(kdvsi) + "', toplamtutar='" + Convert.ToString(toplam) + "' Where belgeno='" + belgenogider.Text + "'";
                string kmt = "Select sum(toplamtutar) from gidersayfasi";
                string kmt2 = "Select sum(kdvsiztutar) from gidersayfasi";
                string kmt3 = "Select sum(kdvlitutar) from gidersayfasi";
                string kmt4 = "Select sum(kdvlitutar) from gidersayfasi";

                OleDbCommand komutsatir = new OleDbCommand(komut, con);
                komutsatir.ExecuteNonQuery();
                OleDbCommand kmtsatir = new OleDbCommand(kmt, con);
                double sonuc = Convert.ToDouble(kmtsatir.ExecuteScalar());
                geneltoplamgider.Text = sonuc.ToString("c");
                kmtsatir.ExecuteNonQuery();
                OleDbCommand kmtsatir2 = new OleDbCommand(kmt2, con);
                double sonuc2 = Convert.ToDouble(kmtsatir2.ExecuteScalar());
                toplamtutarigider.Text = sonuc2.ToString("c");
                kmtsatir2.ExecuteNonQuery();
                OleDbCommand kmtsatir3 = new OleDbCommand(kmt3, con);
                double sonuc3 = Convert.ToDouble(kmtsatir3.ExecuteScalar());
                kdvtoplamigider.Text = sonuc3.ToString("c");
                kmtsatir3.ExecuteNonQuery();
                OleDbCommand kmtsatir4 = new OleDbCommand(kmt4, con);
                double sonuc4 = Convert.ToDouble(kmtsatir4.ExecuteScalar());
                hasilatkdvgider.Text = sonuc4.ToString("c");
                kmtsatir4.ExecuteNonQuery();
                con.Close();
                oncekidonemgider.Text = "0,00 TL";
                listele2();

                MessageBox.Show("Başarıyla kaydedildi ve aktarıldı!", "Kayıt İşlemi");





            }

            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string col2, col3, col4, col5, col6, col7, col8;

            col2 = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // açıklama..
            col3 = dataGridView1[3, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // miktar...
            col4 = dataGridView1[4, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // işlem...
            col5 = dataGridView1[5, dataGridView1.CurrentCell.RowIndex].Value.ToString();  // kdv...
            col6 = dataGridView1[6, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // fiyat...
            col7 = dataGridView1[7, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // kdvsi...
            col8 = dataGridView1[8, dataGridView1.CurrentCell.RowIndex].Value.ToString(); // toplam tutar..

            Microsoft.Office.Interop.Excel._Application exc = new Microsoft.Office.Interop.Excel.Application();
            exc.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook kitap = exc.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet shee = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range ran;
            ran = shee.get_Range("B2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Tarih");
            ran = shee.get_Range("C2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "BelgeNo");
            ran = shee.get_Range("D2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Açıklama");
            ran = shee.get_Range("E2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Miktar");
            ran = shee.get_Range("F2", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "İşlem");
            ran = shee.get_Range("B4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "KDV");
            ran = shee.get_Range("C4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "Fiyat");
            ran = shee.get_Range("D4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "KDVsi");
            ran = shee.get_Range("E4", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, "ToplamTutar");
            ran = shee.get_Range("B3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, tarih.Text);
            ran = shee.get_Range("C3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, belgeno.Text);
            ran = shee.get_Range("D3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col2);
            ran = shee.get_Range("E3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col3);
            ran = shee.get_Range("F3", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col4);
            ran = shee.get_Range("B5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col5);
            ran = shee.get_Range("C5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col6);
            ran = shee.get_Range("D5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col7);
            ran = shee.get_Range("E5", System.Reflection.Missing.Value);
            ran.set_Value(System.Reflection.Missing.Value, col8);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            belgenogider.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void tarihgider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void belgenogider_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button2.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void tarih_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void belgeno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                button1.PerformClick();
            }

            else if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            belgeno.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void kaydetGiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                if (belgenogider.Text == "")
                {
                    MessageBox.Show("Lütfen Belge No alanını boş geçmeyiniz!", "Uyarı");
                }
                else
                {

                    try
                    {
                        OleDbConnection baglanti;
                        baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                        baglanti.Open();

                        OleDbCommand kayit = new OleDbCommand();
                        kayit.CommandText = "INSERT INTO gidersayfasi(tarih,belgeno)VALUES('" + tarihgider.Text + "','" + belgenogider.Text + "')";
                        kayit.Connection = baglanti;
                        kayit.ExecuteNonQuery();
                        baglanti.Close();
                        listele2();



                    }
                    catch (OleDbException ex)
                    {

                        MessageBox.Show(ex.Message);

                    }
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

        private void hesapMakineisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void gelirSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydınız silinecek! Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("delete from gelirsayfasi where belgeno='" + belgeno.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    belgeno.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void giderSayfasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydınız silinecek! Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("delete from gidersayfasi where belgeno='" + belgenogider.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    belgenogider.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}

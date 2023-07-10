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
    public partial class yenipersonel : Form
    {
        public yenipersonel()
        {
            InitializeComponent();
        }

        private void yenipersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'onmuhasebesmartdataDataSet24.personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter2.Fill(this.onmuhasebesmartdataDataSet24.personel);
           
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if ((maas.Text == "") && (avans.Text == ""))
            {
                MessageBox.Show("Maaş ve Avans alanlarını boş geçmeyiniz! Eğer yoksa '0(sıfır)' giriniz!", "Uyarı");
            }
            else
            {


                float para = float.Parse(maas.Text);
                float avns = float.Parse(avans.Text);

                float sonsonuc = para - avns;




                double sonuc = Convert.ToDouble(sonsonuc);
                maas.Text = sonuc.ToString("c");
                double sonuc2 = Convert.ToDouble(avans.Text);
                avans.Text = sonuc2.ToString("c");




                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("insert into personel(adisoyadi,bolum,gorevi,isegiristarihi,sicilno,durumu,maas,avans,evtelefonu,ceptelefonu,adres,notu,seri,nosu,tckimlikno,babaadi,anaadi,dogumyeri,dogumtarihi,cinsiyeti,medenihali,kangrubu,il,ilce,mahalle,ciltno,ailesirano,sirano,verildigiyer,verilisnedeni,kayitno,verilistarihi) values ('" + adisoyadi.Text + "','" + calistigibolum.Text + "','" + gorevi.Text + "','" + isegiristarihi.Text + "','" + sicilno.Text + "','" + durumu.Text + "','" + maas.Text + "','" + avans.Text + "','" + evtelefonu.Text + "','" + ceptelefonu.Text + "','" + adres.Text + "','" + notlar.Text + "','" + seri.Text + "','" + no.Text + "','" + tckimlikno.Text + "','" + babaadi.Text + "','" + anaadi.Text + "','" + dogumyeri.Text + "','" + dogumtarihi.Text + "','" + cinsiyeti.Text + "','" + medenihali.Text + "','" + kangrubu.Text + "','" + il.Text + "','" + ilce.Text + "','" + mahalle.Text + "','" + ciltno.Text + "','" + ailesirano.Text + "','" + sirano.Text + "','" + verildigiyer.Text + "','" + verilisnedeni.Text + "','" + kayitno.Text + "','" + verilistarihi.Text + "')");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                    adisoyadi.Clear();
                    calistigibolum.Clear();
                    gorevi.Clear();
                    isegiristarihi.Clear();
                    sicilno.Clear();
                    durumu.SelectedIndex = -1;
                    maas.Clear();
                    avans.Clear();
                    evtelefonu.Clear();
                    ceptelefonu.Clear();
                    adres.Clear();
                    notlar.Clear();
                    seri.Clear();
                    no.Clear();
                    tckimlikno.Clear();
                    babaadi.Clear();
                    anaadi.Clear();
                    dogumyeri.Clear();
                    dogumtarihi.Clear();
                    cinsiyeti.SelectedIndex = -1;
                    medenihali.SelectedIndex = -1;
                    kangrubu.SelectedIndex = -1;
                    il.Clear();
                    ilce.Clear();
                    mahalle.Clear();
                    ciltno.Clear();
                    ailesirano.Clear();
                    sirano.Clear();
                    verildigiyer.Clear();
                    verilisnedeni.SelectedIndex = -1;
                    kayitno.Clear();
                    verilistarihi.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adisoyadi.Clear();
            calistigibolum.Clear();
            gorevi.Clear();
            isegiristarihi.Clear();
            sicilno.Clear();
            durumu.SelectedIndex = -1;
            maas.Clear();
            avans.Clear();
            evtelefonu.Clear();
            ceptelefonu.Clear();
            adres.Clear();
            notlar.Clear();
            seri.Clear();
            no.Clear();
            tckimlikno.Clear();
            babaadi.Clear();
            anaadi.Clear();
            dogumyeri.Clear();
            dogumtarihi.Clear();
            cinsiyeti.SelectedIndex = -1;
            medenihali.SelectedIndex = -1;
            kangrubu.SelectedIndex = -1;
            il.Clear();
            ilce.Clear();
            mahalle.Clear();
            ciltno.Clear();
            ailesirano.Clear();
            sirano.Clear();
            verildigiyer.Clear();
            verilisnedeni.SelectedIndex = -1;
            kayitno.Clear();
            verilistarihi.Clear();
            
        }

        public void listele()
        {


            OleDbConnection con = new OleDbConnection();
            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
            DataTable dt = new DataTable();
            dt.Clear();

            OleDbDataAdapter adpt = new OleDbDataAdapter("Select*from personel", con);
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kayıtlarınız kaydedilmemiş olabilir. Yine de çıkmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Close();
            }
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            float para = float.Parse(maas.Text);
            float avns = float.Parse(avans.Text);

            float sonsonuc = para - avns;




            double sonuc = Convert.ToDouble(sonsonuc);
            maas.Text = sonuc.ToString("c");
            double sonuc2 = Convert.ToDouble(avans.Text);
            avans.Text = sonuc2.ToString("c");



            try
            {
                OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                baglan.Open();
                OleDbCommand komut = new OleDbCommand("insert into personel(adisoyadi,bolum,gorevi,isegiristarihi,sicilno,durumu,maas,avans,evtelefonu,ceptelefonu,adres,notu,seri,nosu,tckimlikno,babaadi,anaadi,dogumyeri,dogumtarihi,cinsiyeti,medenihali,kangrubu,il,ilce,mahalle,ciltno,ailesirano,sirano,verildigiyer,verilisnedeni,kayitno,verilistarihi) values ('" + adisoyadi.Text + "','" + calistigibolum.Text + "','" + gorevi.Text + "','" + isegiristarihi.Text + "','" + sicilno.Text + "','" + durumu.Text + "','" + maas.Text + "','" + avans.Text + "','" + evtelefonu.Text + "','" + ceptelefonu.Text + "','" + adres.Text + "','" + notlar.Text + "','" + seri.Text + "','" + no.Text + "','" + tckimlikno.Text + "','" + babaadi.Text + "','" + anaadi.Text + "','" + dogumyeri.Text + "','" + dogumtarihi.Text + "','" + cinsiyeti.Text + "','" + medenihali.Text + "','" + kangrubu.Text + "','" + il.Text + "','" + ilce.Text + "','" + mahalle.Text + "','" + ciltno.Text + "','" + ailesirano.Text + "','" + sirano.Text + "','" + verildigiyer.Text + "','" + verilisnedeni.Text + "','" + kayitno.Text + "','" + verilistarihi.Text + "')");
                komut.Connection = baglan;
                komut.ExecuteNonQuery();
                baglan.Close();
                listele();
                MessageBox.Show("Kaydınız başarıyla gerçekleşti!", "Kayıt İşlemi");
                adisoyadi.Clear();
                calistigibolum.Clear();
                gorevi.Clear();
                isegiristarihi.Clear();
                sicilno.Clear();
                durumu.SelectedIndex = -1;
                maas.Clear();
                avans.Clear();
                evtelefonu.Clear();
                ceptelefonu.Clear();
                adres.Clear();
                notlar.Clear();
                seri.Clear();
                no.Clear();
                tckimlikno.Clear();
                babaadi.Clear();
                anaadi.Clear();
                dogumyeri.Clear();
                dogumtarihi.Clear();
                cinsiyeti.SelectedIndex = -1;
                medenihali.SelectedIndex = -1;
                kangrubu.SelectedIndex = -1;
                il.Clear();
                ilce.Clear();
                mahalle.Clear();
                ciltno.Clear();
                ailesirano.Clear();
                sirano.Clear();
                verildigiyer.Clear();
                verilisnedeni.SelectedIndex = -1;
                kayitno.Clear();
                verilistarihi.Clear();



            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
            
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adisoyadi.Clear();
            calistigibolum.Clear();
            gorevi.Clear();
            isegiristarihi.Clear();
            sicilno.Clear();
            durumu.SelectedIndex = -1;
            maas.Clear();
            avans.Clear();
            evtelefonu.Clear();
            ceptelefonu.Clear();
            adres.Clear();
            notlar.Clear();
            seri.Clear();
            no.Clear();
            tckimlikno.Clear();
            babaadi.Clear();
            anaadi.Clear();
            dogumyeri.Clear();
            dogumtarihi.Clear();
            cinsiyeti.SelectedIndex = -1;
            medenihali.SelectedIndex = -1;
            kangrubu.SelectedIndex = -1;
            il.Clear();
            ilce.Clear();
            mahalle.Clear();
            ciltno.Clear();
            ailesirano.Clear();
            sirano.Clear();
            verildigiyer.Clear();
            verilisnedeni.SelectedIndex = -1;
            kayitno.Clear();
            verilistarihi.Clear();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Kaydınız silinecek! Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {

                try
                {
                    OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\\onmuhasebesmartdata.accdb; Persist Security Info=False;");
                    baglan.Open();
                    OleDbCommand komut = new OleDbCommand("delete from personel where adisoyadi='" + adisoyadi.Text + "'");
                    komut.Connection = baglan;
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    listele();
                    MessageBox.Show("Kaydınız silindi!", "Silme İşlemi");
                    adisoyadi.Clear();



                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            adisoyadi.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BindingSource sr2 = new BindingSource();
            sr2.DataSource = dataGridView1.DataSource;

            sr2.Filter = "evrakno like '%" + personelara.Text + "%'";
            dataGridView1.DataSource = sr2;
        }
    }
}

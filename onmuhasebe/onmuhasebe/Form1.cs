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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((admin.Text != "admin") && (admin.Text != "Admin"))
            {
                MessageBox.Show("Kullanıcı adı yanlış veya eksik girildi! Lütfen tekrar kontrol ediniz!","Uyarı");
            }
            else if ((sifre.Text != "234623") && (sifre.Text != "a34bvd"))
            {
                MessageBox.Show("Şifre yanlış veya eksik girildi! Lütfen tekrar kontrol ediniz!", "Uyarı");
            }
            else 
            {
                kayitlifirma a = new kayitlifirma();
                a.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkış yapmak istediğinizden emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sonuc == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

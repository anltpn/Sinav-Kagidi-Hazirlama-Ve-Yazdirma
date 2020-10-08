using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kitapcik1920
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Giris_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new
                SqlDataAdapter(@"select * from Kullanici
                                    where KullaniciAdi=@KullaniciAdi and
                                          Sifre=@Sifre",Vt.baglanti);

            da.SelectCommand.Parameters.AddWithValue("KullaniciAdi", textBox1.Text);
            da.SelectCommand.Parameters.AddWithValue("Sifre", textBox2.Text);

            DataTable dt = new DataTable();

            da.Fill(dt);//Data Adapter Üzerindeki Kodu Çaliştir. Gelen Verileri Dt Dosyasına Doldur.

            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show(dt.Rows[0]["AdSoyad"].ToString());
                AnaForm frm = new AnaForm();
                this.Hide();
                frm.LblAktifKullanici.Text = "Aktif Kullanıcı : " + dt.Rows[0]["AdSoyad"].ToString();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Giriş Hatalı", "Uyari");
            }

        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;//Veritabani İşlemlerinde Kullanılır.

namespace Kitapcik1920
{
    public partial class Birim : Form
    {
        public Birim()
        {
            InitializeComponent();
        }

        private void Birim_Load(object sender, EventArgs e)
        {//kayit çekme - connetiona gerek yok
            SqlDataAdapter da = new SqlDataAdapter("select * from Birim", Vt.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            güncelle.Enabled = false;
            sil.Enabled = false;
            textBox1.Text = "";

        }

        private void birimekle_Click(object sender, EventArgs e)
        {//kayit ekleme - connetiona gerek var
            if (Vt.con.State != ConnectionState.Open)
               Vt.con.Open();

            SqlCommand kod = new SqlCommand(@"insert into Birim (BirimAdi)
                                                values (@BirimAdi)", Vt.con);

            kod.Parameters.AddWithValue("BirimAdi",textBox1.Text);

            kod.ExecuteNonQuery();

            Birim_Load(sender, e);

        }

        int BirimID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int deger = dataGridView1.CurrentCell.RowIndex;

             BirimID = int.Parse(dataGridView1.Rows[deger].Cells["BirimID"].Value.ToString());
            textBox1.Text=dataGridView1.Rows[deger].Cells["BirimAdi"].Value.ToString();
            güncelle.Enabled = true;
            sil.Enabled = true;
        }

        private void güncelle_Click(object sender, EventArgs e)
        {//Güncelleme
            DialogResult sonuc = MessageBox.Show("Güncellemek İstiyormusunuz?", "Uyari", MessageBoxButtons.YesNo);
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
                if (Vt.con.State != ConnectionState.Open)
                    Vt.con.Open();

                SqlCommand kod = new SqlCommand(@"update Birim
                                              set BirimAdi=@BirimAdi
                                              where BirimID=@BirimID", Vt.con);
                kod.Parameters.AddWithValue("BirimID", BirimID);
                kod.Parameters.AddWithValue("BirimAdi", textBox1.Text);
                kod.ExecuteNonQuery();
                Birim_Load(sender, e);
            }

        }

        private void sil_Click(object sender, EventArgs e)
        {//silme
            DialogResult sonuc = MessageBox.Show("Silmek İstiyormusunuz?", "Uyari", MessageBoxButtons.YesNo);
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
            if (Vt.con.State != ConnectionState.Open)
            Vt.con.Open();

            SqlCommand kod = new SqlCommand(@"delete from Birim
                                              where BirimID=@BirimID", Vt.con);
            kod.Parameters.AddWithValue("BirimID", BirimID);
            kod.ExecuteNonQuery();
            Birim_Load(sender, e);
            }

        }

    }
}

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
    public partial class Sinav : Form
    {
        public Sinav()
        {
            InitializeComponent();
        }

        private void Sinav_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Sinav", Vt.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            sil.Enabled = false;
            güncelle.Enabled = false;
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (Vt.con.State != ConnectionState.Open)
                Vt.con.Open();

            SqlCommand kod = new SqlCommand(@"insert into Sinav (SinavAdi,SinavTarihi)
                                                values (@SinavAdi,@SinavTarihi)", Vt.con);

            kod.Parameters.AddWithValue("SinavAdi", txtSinavAdi.Text);
            kod.Parameters.AddWithValue("SinavTarihi", dateTimePicker1.Text);

            txtSinavAdi.Text = "";
            kod.ExecuteNonQuery();
            Sinav_Load(sender, e);
        }

        int SinavID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int deger = dataGridView1.CurrentCell.RowIndex;

            SinavID = int.Parse(dataGridView1.Rows[deger].Cells["SinavID"].Value.ToString());
            txtSinavAdi.Text = dataGridView1.Rows[deger].Cells["SinavAdi"].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[deger].Cells["SinavTarihi"].Value.ToString();

            güncelle.Enabled = true;
            sil.Enabled = true;
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Güncellemek İstiyormusunuz?", "Uyari", MessageBoxButtons.YesNo);
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
                if (Vt.con.State != ConnectionState.Open)
                    Vt.con.Open();

                SqlCommand kod = new SqlCommand(@"update Sinav
                                              set SinavAdi=@SinavAdi, SinavTarihi=@SinavTarihi
                                              where SinavID=@SinavID", Vt.con);
                kod.Parameters.AddWithValue("SinavAdi", txtSinavAdi.Text);
                kod.Parameters.AddWithValue("SinavID", SinavID);
                kod.Parameters.AddWithValue("SinavTarihi", dateTimePicker1.Text);

                kod.ExecuteNonQuery();
                txtSinavAdi.Text = "";
                dateTimePicker1.Text = "";
                Sinav_Load(sender, e);
            }

        }

        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Silmek İstiyormusunuz?", "Uyari", MessageBoxButtons.YesNo);
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
                if (Vt.con.State != ConnectionState.Open)
                    Vt.con.Open();

                SqlCommand kod = new SqlCommand(@"delete from Sinav where SinavID=@SinavID", Vt.con);

                kod.Parameters.AddWithValue("SinavID", SinavID);

                kod.ExecuteNonQuery();
                txtSinavAdi.Text = "";
                dateTimePicker1.Text = "";
                Sinav_Load(sender, e);
                
            }
        }
        

    }
}

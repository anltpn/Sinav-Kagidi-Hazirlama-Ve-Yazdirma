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
    public partial class Sorular : Form
    {
        public Sorular()
        {
            InitializeComponent();
        }

        private void Sorular_Load(object sender, EventArgs e)
        {
            cbBirim.SelectedIndexChanged -= new System.EventHandler(cbBirim_SelectedIndexChanged);
            SqlDataAdapter da = new SqlDataAdapter("select * from Birim", Vt.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cbBirim.DataSource = dt;
                cbBirim.DisplayMember = "BirimAdi";
                cbBirim.ValueMember = "BirimID";
                cbBirim.SelectedIndexChanged += new System.EventHandler(cbBirim_SelectedIndexChanged);
                cbBirim_SelectedIndexChanged(sender, e);
            }

        }

        private void cbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = " ";
            cbProgram.SelectedIndexChanged -= new System.EventHandler(cbProgram_SelectedIndexChanged);
            cbProgram.Text = "";
            SqlDataAdapter da = new SqlDataAdapter(@"select * from Program where BirimID=@BirimID", Vt.baglanti);

            da.SelectCommand.Parameters.AddWithValue("BirimID", cbBirim.SelectedValue.ToString());
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cbProgram.DataSource = dt;
                cbProgram.DisplayMember = "ProgramAdi";
                cbProgram.ValueMember = "ProgramID";
                cbProgram.SelectedIndexChanged += new System.EventHandler(cbProgram_SelectedIndexChanged);
                cbProgram_SelectedIndexChanged(sender, e);
            }

        }

        private void cbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDers.SelectedIndexChanged -= new System.EventHandler(cbDers_SelectedIndexChanged);
            cbDers.Text = "";
            SqlDataAdapter da = new SqlDataAdapter(@"select * from Ders where ProgramID=@ProgramID", Vt.baglanti);

            da.SelectCommand.Parameters.AddWithValue("ProgramID", cbProgram.SelectedValue.ToString());
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                cbDers.DataSource = dt;
                cbDers.DisplayMember = "DersAdi";
                cbDers.ValueMember = "DersID";
                cbDers.SelectedIndexChanged += new System.EventHandler(cbDers_SelectedIndexChanged);
                cbDers_SelectedIndexChanged(sender, e);
            }
        }

        private void cbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"select * from Sorular where DersID=@DersID", Vt.baglanti);

            da.SelectCommand.Parameters.AddWithValue("DersID", cbDers.SelectedValue.ToString());
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            güncelle.Enabled = false;
            sil.Enabled = false;
            
        }
        void Temizle()
        {
            txtSoru.Text = " ";
            txtCevapA.Text = " ";
            txtCevapB.Text = " ";
            txtCevapC.Text = " ";
            txtCevapD.Text = " ";
            txtCevapE.Text = " ";
            cbDogruCevap.Text = "Seçiniz..";
            cbZorluk.Text = "Seçiniz..";
            cbKategori.Text = "Seçiniz..";
        }
        private void ekle_Click(object sender, EventArgs e)
        {

            if (Vt.con.State != ConnectionState.Open)
                Vt.con.Open();

            SqlCommand kod = new SqlCommand(@"insert into Sorular (DersID, Soru, CevapA, CevapB, CevapC, CevapD, CevapE, DogruCevap, Zorluk, Kategori) values
                (@DersID, @Soru, @CevapA, @CevapB, @CevapC, @CevapD, @CevapE, @DogruCevap, @Zorluk, @Kategori)", Vt.con);

            kod.Parameters.AddWithValue("DersID", cbDers.SelectedValue.ToString());
            kod.Parameters.AddWithValue("Soru", txtSoru.Text);
            kod.Parameters.AddWithValue("CevapA", txtCevapA.Text);
            kod.Parameters.AddWithValue("CevapB", txtCevapB.Text);
            kod.Parameters.AddWithValue("CevapC", txtCevapC.Text);
            kod.Parameters.AddWithValue("CevapD", txtCevapD.Text);
            kod.Parameters.AddWithValue("CevapE", txtCevapE.Text);
            kod.Parameters.AddWithValue("DogruCevap", cbDogruCevap.Text);
            kod.Parameters.AddWithValue("Zorluk", cbZorluk.Text);
            kod.Parameters.AddWithValue("Kategori", cbKategori.Text);

            
            kod.ExecuteNonQuery();
            cbDers_SelectedIndexChanged(sender, e);
            Temizle();
            
        }

        int SoruID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int deger = dataGridView1.CurrentCell.RowIndex;

            SoruID = int.Parse(dataGridView1.Rows[deger].Cells["SoruID"].Value.ToString());
            txtSoru.Text = dataGridView1.Rows[deger].Cells["Soru"].Value.ToString();
            txtCevapA.Text = dataGridView1.Rows[deger].Cells["CevapA"].Value.ToString();
            txtCevapB.Text = dataGridView1.Rows[deger].Cells["CevapB"].Value.ToString();
            txtCevapC.Text = dataGridView1.Rows[deger].Cells["CevapC"].Value.ToString();
            txtCevapD.Text = dataGridView1.Rows[deger].Cells["CevapD"].Value.ToString();
            txtCevapE.Text = dataGridView1.Rows[deger].Cells["CevapE"].Value.ToString();
            cbDogruCevap.Text = dataGridView1.Rows[deger].Cells["DogruCevap"].Value.ToString();
            cbZorluk.Text = dataGridView1.Rows[deger].Cells["Zorluk"].Value.ToString();
            cbKategori.Text = dataGridView1.Rows[deger].Cells["Kategori"].Value.ToString();

            güncelle.Enabled = true;
            sil.Enabled = true;
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Silmek İstiyormusunuz?", "Uyari", MessageBoxButtons.YesNo);
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
                if (Vt.con.State != ConnectionState.Open)
                    Vt.con.Open();

                SqlCommand kod = new SqlCommand(@"delete from Sorular where SoruID=@SoruID", Vt.con);

                kod.Parameters.AddWithValue("SoruID", SoruID);

                kod.ExecuteNonQuery();
                cbDers_SelectedIndexChanged(sender, e);
                Temizle();
            }
        }

        private void güncelle_Click(object sender, EventArgs e)
        {
            if (Vt.con.State != ConnectionState.Open)
                Vt.con.Open();

            DialogResult sonuc = MessageBox.Show("Güncellemek İstiyormusunuz?", "Uyari", MessageBoxButtons.YesNo);
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
                SqlCommand kod = new SqlCommand(@"update Sorular set DersID=@DersID, Soru=@Soru, CevapA=@CevapA, CevapB=@CevapB, CevapC=@CevapC, CevapD=@CevapD, CevapE=@CevapE, DogruCevap=@DogruCevap, Zorluk=@Zorluk, Kategori=@Kategori
                                            where SoruID=@SoruID", Vt.con);

                kod.Parameters.AddWithValue("SoruID", SoruID);
                kod.Parameters.AddWithValue("DersID", cbDers.SelectedValue.ToString());
                kod.Parameters.AddWithValue("Soru", txtSoru.Text);
                kod.Parameters.AddWithValue("CevapA", txtCevapA.Text);
                kod.Parameters.AddWithValue("CevapB", txtCevapB.Text);
                kod.Parameters.AddWithValue("CevapC", txtCevapC.Text);
                kod.Parameters.AddWithValue("CevapD", txtCevapD.Text);
                kod.Parameters.AddWithValue("CevapE", txtCevapE.Text);
                kod.Parameters.AddWithValue("DogruCevap", cbDogruCevap.Text);
                kod.Parameters.AddWithValue("Zorluk", cbZorluk.Text);
                kod.Parameters.AddWithValue("Kategori", cbKategori.Text);


                kod.ExecuteNonQuery();
                cbDers_SelectedIndexChanged(sender, e);
                Temizle();
            }

        }

    }
}

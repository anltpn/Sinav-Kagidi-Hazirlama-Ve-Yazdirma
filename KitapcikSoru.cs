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
    public partial class KitapcikSoru : Form
    {
        public KitapcikSoru()
        {
            InitializeComponent();
        }

        private void KitapcikSoru_Load(object sender, EventArgs e)
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

            cbSinavAdi.SelectedIndexChanged -= new System.EventHandler(cbSinavAdi_SelectedIndexChanged);
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Sinav", Vt.baglanti);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            if (dt1.Rows.Count > 0)
            {
                cbSinavAdi.DataSource = dt1;
                cbSinavAdi.DisplayMember = "SinavAdi";
                cbSinavAdi.ValueMember = "SinavID";
                cbSinavAdi.SelectedIndexChanged += new System.EventHandler(cbSinavAdi_SelectedIndexChanged);
                cbSinavAdi_SelectedIndexChanged(sender, e);

            }
        }

        private void cbBirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProgram.SelectedIndexChanged -= new System.EventHandler(cbProgram_SelectedIndexChanged);
            SqlDataAdapter da = new SqlDataAdapter(@"select * from Program
                                                     where BirimID=@BirimID", Vt.baglanti);

            da.SelectCommand.Parameters.AddWithValue("BirimID", cbBirim.SelectedValue.ToString());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbProgram.Text = "";
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
            SqlDataAdapter da = new SqlDataAdapter(@"select * from Ders 
                                                     where ProgramID=@ProgramID", Vt.baglanti);

            da.SelectCommand.Parameters.AddWithValue("ProgramID", cbProgram.SelectedValue.ToString());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbDers.Text = "";
            cbDers.DataSource = dt;
            cbDers.DisplayMember = "DersAdi";
            cbDers.ValueMember = "DersID";
        }

        private void cbSinavAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKitapcikAdi.SelectedIndexChanged -= new System.EventHandler(cbKitapcikAdi_SelectedIndexChanged);

            SqlDataAdapter da = new SqlDataAdapter(@"select * from Kitapcik
                                                      where SinavID=@SinavID", Vt.baglanti);
            da.SelectCommand.Parameters.AddWithValue("SinavID", cbSinavAdi.SelectedValue.ToString());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbKitapcikAdi.Text = "";
            dataGridView1.DataSource = "";
            if (dt.Rows.Count > 0)
            {
                cbKitapcikAdi.DataSource = dt;
                cbKitapcikAdi.DisplayMember = "KitapcikAdi";
                cbKitapcikAdi.ValueMember = "KitapcikID";
                cbKitapcikAdi.SelectedIndexChanged += new System.EventHandler(cbKitapcikAdi_SelectedIndexChanged);
                cbKitapcikAdi_SelectedIndexChanged(sender, e);
            }
        }


        private void cbKitapcikAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlDataAdapter da = new SqlDataAdapter(@"select k.KitapcikAdi,ks.SoruNo, ks.SoruID, s.Soru from KitapcikSoru ks
                                                     inner join Sorular s on ks.SoruID=s.SoruID
                                                     inner join Kitapcik k on k.KitapcikID=ks.KitapcikID
                                                     where ks.KitapcikID=@KitapcikID", Vt.baglanti);
            
            da.SelectCommand.Parameters.AddWithValue("KitapcikID", cbKitapcikAdi.SelectedValue.ToString());
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            dataGridView1.DataSource = dt;
            //dataGridView1.Columns["KitapcikID"].Visible = false; --> Sütün Gizleme
        }

        private void btnKitapcikTemizle_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Silmek İstiyormusunuz?", "Uyari", MessageBoxButtons.YesNo);
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
                if (Vt.con.State != ConnectionState.Open)
                    Vt.con.Open();

                SqlCommand kod = new SqlCommand(@"delete from KitapcikSoru
                                              where KitapcikID=@KitapcikID", Vt.con);
                kod.Parameters.AddWithValue("KitapcikID", cbKitapcikAdi.SelectedValue.ToString());
                //kod.Parameters.AddWithValue("KitapcikID", dataGridView1.Rows[0].Cells["KitapcikID"].Value.ToString());
                kod.ExecuteNonQuery();
                cbKitapcikAdi_SelectedIndexChanged(sender, e);
            }
        }

        private void btnSonEkle_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("[pSoruAta]", Vt.baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("KitapcikID", cbKitapcikAdi.SelectedValue.ToString());
            da.SelectCommand.Parameters.AddWithValue("DersID", cbDers.SelectedValue.ToString());
            da.SelectCommand.Parameters.AddWithValue("SoruSayisi", txtSonEklenen.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);
            txtSonEklenen.Text = "";

            cbKitapcikAdi_SelectedIndexChanged(sender, e);
        }

        private void btnKarısık_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("[pKarisikSoruAta]", Vt.baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("KitapcikID", cbKitapcikAdi.SelectedValue.ToString());
            da.SelectCommand.Parameters.AddWithValue("DersID", cbDers.SelectedValue.ToString());

            da.SelectCommand.Parameters.AddWithValue("VizeKolay", txtVizeKolay.Text);
            da.SelectCommand.Parameters.AddWithValue("VizeOrta", txtVizeOrta.Text);
            da.SelectCommand.Parameters.AddWithValue("VizeZor", txtVizeZor.Text);
            da.SelectCommand.Parameters.AddWithValue("FinalKolay", txtFinalKolay.Text);
            da.SelectCommand.Parameters.AddWithValue("FinalOrta", txtFinalOrta.Text);
            da.SelectCommand.Parameters.AddWithValue("FinalZor", txtFinalZor.Text);

            DataTable dt = new DataTable();
            da.Fill(dt);
            txtSonEklenen.Text = "";

            cbKitapcikAdi_SelectedIndexChanged(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

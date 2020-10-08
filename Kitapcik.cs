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
    public partial class Kitapcik : Form
    {
        public Kitapcik()
        {
            InitializeComponent();
        }

        private void Kitapcik_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged -= new System.EventHandler(comboBox1_SelectedIndexChanged);
            
            SqlDataAdapter da = new SqlDataAdapter(@"select * from Sinav", Vt.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "SinavAdi";
                comboBox1.ValueMember = "SinavID";
                comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
                comboBox1_SelectedIndexChanged(sender, e);

                sil.Enabled = false;
                güncelle.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"select * from Kitapcik
                                                     where SinavID=@SinavID", Vt.baglanti);
            da.SelectCommand.Parameters.AddWithValue("SinavID", comboBox1.SelectedValue.ToString());
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (Vt.con.State != ConnectionState.Open)
                Vt.con.Open();

            SqlCommand kod = new SqlCommand(@"insert into Kitapcik (SinavID, KitapcikAdi, KitapcikTuru)
                                                values (@SinavID,@KitapcikAdi,@KitapcikTuru)", Vt.con);

            kod.Parameters.AddWithValue("SinavID", comboBox1.SelectedValue.ToString());
            kod.Parameters.AddWithValue("KitapcikAdi", textBox1.Text);
            kod.Parameters.AddWithValue("KitapcikTuru", comboBox2.Text);

            kod.ExecuteNonQuery();
            Kitapcik_Load(sender, e);
        }

        int KitapcikID;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int deger = dataGridView1.CurrentCell.RowIndex;

            KitapcikID = int.Parse(dataGridView1.Rows[deger].Cells["KitapcikID"].Value.ToString());
            textBox1.Text = dataGridView1.Rows[deger].Cells["KitapcikAdi"].Value.ToString();
            comboBox2.Text = dataGridView1.Rows[deger].Cells["KitapcikTuru"].Value.ToString();

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

                 SqlCommand kod = new SqlCommand(@"update Kitapcik
                                              set SinavID=@SinavID, KitapcikAdi=@KitapcikAdi, KitapcikTuru=@KitapcikTuru
                                              where KitapcikID=@KitapcikID", Vt.con);

                 kod.Parameters.AddWithValue("KitapcikID", KitapcikID);
                 kod.Parameters.AddWithValue("SinavID", comboBox1.SelectedValue.ToString());
                 kod.Parameters.AddWithValue("KitapcikAdi", textBox1.Text);
                 kod.Parameters.AddWithValue("KitapcikTuru", comboBox2.Text);

                 kod.ExecuteNonQuery();
                 comboBox1.Text = "";
                 textBox1.Text = "";
                 comboBox2.Text = "";
                 Kitapcik_Load(sender, e);
             }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Silmek İstiyormusunuz?", "Uyari", MessageBoxButtons.YesNo);
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
                if (Vt.con.State != ConnectionState.Open)
                    Vt.con.Open();

                SqlCommand kod = new SqlCommand(@"delete from Kitapcik where KitapcikID=@KitapcikID", Vt.con);

                kod.Parameters.AddWithValue("KitapcikID", KitapcikID);

                kod.ExecuteNonQuery();
                textBox1.Text = "";
                comboBox2.Text = "";
                Kitapcik_Load(sender, e);

            }
        }
    }
}

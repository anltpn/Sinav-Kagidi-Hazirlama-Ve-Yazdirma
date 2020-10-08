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
    public partial class Ders : Form
    {
        private object ProgramID;
        public Ders()
        {
            InitializeComponent();
        }

        private void Ders_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged -= new System.EventHandler(comboBox1_SelectedIndexChanged);
            SqlDataAdapter da = new SqlDataAdapter("select * from Birim", Vt.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "BirimAdi";
            comboBox1.ValueMember = "BirimID";
            comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
            comboBox1_SelectedIndexChanged(sender, e);
            güncelle.Enabled = false;
            sil.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndexChanged -= new System.EventHandler(comboBox2_SelectedIndexChanged);
            comboBox2.Text = "";
            SqlDataAdapter da = new SqlDataAdapter(@"select * from Program where BirimID=@BirimID", Vt.baglanti);

            da.SelectCommand.Parameters.AddWithValue("BirimID", comboBox1.SelectedValue.ToString());
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "ProgramAdi";
            comboBox2.ValueMember = "ProgramID";
            comboBox2.SelectedIndexChanged += new System.EventHandler(comboBox2_SelectedIndexChanged);
            comboBox2_SelectedIndexChanged(sender, e);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter(@"select d.DersID, d.DersAdi, p.ProgramAdi from Ders d inner join 
                                                    Program p on d.ProgramID=p.ProgramID
                                                    where p.ProgramID=@ProgramID", Vt.baglanti);

            da.SelectCommand.Parameters.AddWithValue("ProgramID", comboBox2.SelectedValue.ToString());
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (Vt.con.State != ConnectionState.Open)
                Vt.con.Open();

            SqlCommand kod = new SqlCommand(@"insert into Ders (DersAdi,ProgramID)
                                                values (@DersAdi,@ProgramID)", Vt.con);

            kod.Parameters.AddWithValue("DersAdi", textBox1.Text);
            kod.Parameters.AddWithValue("ProgramID", comboBox2.SelectedValue.ToString());

            textBox1.Text = "";
            kod.ExecuteNonQuery();
            comboBox2_SelectedIndexChanged(sender, e);
        }

        int DersID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int deger = dataGridView1.CurrentCell.RowIndex;

            DersID = int.Parse(dataGridView1.Rows[deger].Cells["DersID"].Value.ToString());
            textBox1.Text = dataGridView1.Rows[deger].Cells["DersAdi"].Value.ToString();

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

                SqlCommand kod = new SqlCommand(@"update Ders
                                              set DersAdi=@DersAdi
                                              where DersID=@DersID", Vt.con);
                kod.Parameters.AddWithValue("DersAdi", textBox1.Text);
                kod.Parameters.AddWithValue("DersID", DersID);

                kod.ExecuteNonQuery();
                textBox1.Text = "";
                comboBox2_SelectedIndexChanged(sender, e);
            }
        }
        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Silmek İstiyormusunuz?", "Uyari", MessageBoxButtons.YesNo);
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
                if (Vt.con.State != ConnectionState.Open)
                    Vt.con.Open();

                SqlCommand kod = new SqlCommand(@"delete from Ders
                                              where DersID=@DersID", Vt.con);
                kod.Parameters.AddWithValue("DersID",DersID);
                kod.ExecuteNonQuery();
                textBox1.Text = "";
                comboBox1_SelectedIndexChanged(sender, e);
            }
        }

      
    }
        
}

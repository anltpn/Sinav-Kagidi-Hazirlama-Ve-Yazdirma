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
    public partial class FProgram : Form
    {
        public FProgram()
        {
            InitializeComponent();
        }

        private void FProgram_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged -= new System.EventHandler(comboBox1_SelectedIndexChanged);
            SqlDataAdapter da = new SqlDataAdapter("select * from Birim", Vt.baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboBox1.DataSource = dt;
            comboBox1.ValueMember = "BirimID";
            comboBox1.DisplayMember = "BirimAdi";
            comboBox1.SelectedIndexChanged += new System.EventHandler(comboBox1_SelectedIndexChanged);
            comboBox1_SelectedIndexChanged(sender, e);
            textBox1.Text = "";
            sil.Enabled= false ;
            güncelle.Enabled= false ; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da1 = new SqlDataAdapter("select p.ProgramID,p.ProgramAdi,b.BirimAdi from Program p inner join Birim b on p.BirimID=b.BirimID where b.BirimID=@BirimID ", Vt.baglanti);

            da1.SelectCommand.Parameters.AddWithValue("BirimID", comboBox1.SelectedValue.ToString());
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            dataGridView1.DataSource = dt1;
        }

        private void birimekle_Click(object sender, EventArgs e)
        {
            if (Vt.con.State != ConnectionState.Open)
                Vt.con.Open();

            SqlCommand kod = new SqlCommand(@"insert into Program (ProgramAdi,BirimID)
                                                values (@ProgramAdi,@BirimID)", Vt.con);

            kod.Parameters.AddWithValue("ProgramAdi", textBox1.Text);
            kod.Parameters.AddWithValue("BirimID", comboBox1.SelectedValue.ToString());
            textBox1.Text = "";
            kod.ExecuteNonQuery();
            comboBox1_SelectedIndexChanged(sender, e);
        }
   
        int ProgramID;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int deger = dataGridView1.CurrentCell.RowIndex;

            ProgramID = int.Parse(dataGridView1.Rows[deger].Cells["ProgramID"].Value.ToString());
            textBox1.Text=dataGridView1.Rows[deger].Cells["ProgramAdi"].Value.ToString();
            
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

                 SqlCommand kod = new SqlCommand(@"update Program
                                              set ProgramAdi=@ProgramAdi
                                              where ProgramID=@ProgramID", Vt.con);
                 kod.Parameters.AddWithValue("ProgramAdi", textBox1.Text);
                 kod.Parameters.AddWithValue("ProgramID", ProgramID);
                 
                 kod.ExecuteNonQuery();
                 textBox1.Text = "";
                 comboBox1_SelectedIndexChanged(sender, e);
             }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Silmek İstiyormusunuz?", "Uyari", MessageBoxButtons.YesNo);
            if (sonuc == System.Windows.Forms.DialogResult.Yes)
            {
                if (Vt.con.State != ConnectionState.Open)
                    Vt.con.Open();

                SqlCommand kod = new SqlCommand(@"delete from Program
                                              where ProgramID=@ProgramID", Vt.con);
                kod.Parameters.AddWithValue("ProgramID", ProgramID);
                kod.ExecuteNonQuery();
                textBox1.Text = "";
                comboBox1_SelectedIndexChanged(sender, e);
            }
        }

        
    }
}

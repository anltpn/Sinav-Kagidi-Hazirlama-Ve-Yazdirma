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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            cbSinavAdi.SelectedIndexChanged -= new System.EventHandler(cbSinavAdi_SelectedIndexChanged);
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Sinav order by SinavID desc", Vt.baglanti);
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

        private void cbSinavAdi_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlDataAdapter da = new SqlDataAdapter(@"select * from Kitapcik
                                                      where SinavID=@SinavID", Vt.baglanti);
            da.SelectCommand.Parameters.AddWithValue("SinavID", cbSinavAdi.SelectedValue.ToString());
            DataTable dt = new DataTable();
            da.Fill(dt);
            cbKitapcikAdi.Text = "";
            cbKitapcikAdi.DataSource = dt;
            cbKitapcikAdi.DisplayMember = "KitapcikAdi";
            cbKitapcikAdi.ValueMember = "KitapcikID";
               
        }

        private void cevapanaktarial_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("[spCevapAnaktariAl]", Vt.baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("SinavID", cbSinavAdi.SelectedValue.ToString());
            da.SelectCommand.Parameters.AddWithValue("KitapcikID", cbKitapcikAdi.SelectedValue.ToString());

            DataTable dt = new DataTable();
            da.Fill(dt);
            txtcevapanaktari.Text = dt.Rows[0]["CevapAnaktari"].ToString();
            
        }

        private void raporal_Click(object sender, EventArgs e)
        {


            SqlDataAdapter da = new SqlDataAdapter("[spKitapcikOlustur]", Vt.baglanti);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.AddWithValue("SinavID", cbSinavAdi.SelectedValue.ToString());
            da.SelectCommand.Parameters.AddWithValue("KitapcikID", cbKitapcikAdi.SelectedValue.ToString());

            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.TableName = "Sorular";

            Stimulsoft.Report.StiReport report = new Stimulsoft.Report.StiReport();
            report.Load("raporlar/kitapcik.mrt");
            report.RegData(dt);

            if (cbTasarim.Checked)
            {
                report.Design();
            }
            else
            {
                report.Render(false);
                report.Show();
            }
            report.ClearAllStates();
        }

    }
}

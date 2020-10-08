using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kitapcik1920
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void BirimBtn_Click(object sender, EventArgs e)
        {
            Birim frm = new Birim();
            frm.ShowDialog();
        }

        private void program_Click(object sender, EventArgs e)
        {
            FProgram frm = new FProgram();
            frm.ShowDialog();
        }

        private void ders_Click(object sender, EventArgs e)
        {
            Ders frm = new Ders();
            frm.ShowDialog();
        }

        private void sorular_Click(object sender, EventArgs e)
        {
            Sorular frm = new Sorular();
            frm.ShowDialog();
        }

        private void sinav_Click(object sender, EventArgs e)
        {
            Sinav frm = new Sinav();
            frm.ShowDialog();
        }

        private void kitapcik_Click(object sender, EventArgs e)
        {
            Kitapcik frm = new Kitapcik();
            frm.ShowDialog();
        }

        private void kitapciksoru_Click(object sender, EventArgs e)
        {
            KitapcikSoru frm = new KitapcikSoru();
            frm.ShowDialog();
        }

        private void rapor_Click(object sender, EventArgs e)
        {
            Rapor frm = new Rapor();
            frm.ShowDialog();
        }

       
    }
}

namespace Kitapcik1920
{
    partial class Sorular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBirim = new System.Windows.Forms.ComboBox();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDers = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbDogruCevap = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbZorluk = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.güncelle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.txtCevapA = new System.Windows.Forms.TextBox();
            this.txtCevapB = new System.Windows.Forms.TextBox();
            this.txtCevapC = new System.Windows.Forms.TextBox();
            this.txtCevapD = new System.Windows.Forms.TextBox();
            this.txtCevapE = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 318);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Birim :";
            // 
            // cbBirim
            // 
            this.cbBirim.FormattingEnabled = true;
            this.cbBirim.Location = new System.Drawing.Point(92, 23);
            this.cbBirim.Name = "cbBirim";
            this.cbBirim.Size = new System.Drawing.Size(304, 21);
            this.cbBirim.TabIndex = 2;
            this.cbBirim.SelectedIndexChanged += new System.EventHandler(this.cbBirim_SelectedIndexChanged);
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(92, 60);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(304, 21);
            this.cbProgram.TabIndex = 4;
            this.cbProgram.SelectedIndexChanged += new System.EventHandler(this.cbProgram_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Program  :";
            // 
            // cbDers
            // 
            this.cbDers.FormattingEnabled = true;
            this.cbDers.Location = new System.Drawing.Point(92, 96);
            this.cbDers.Name = "cbDers";
            this.cbDers.Size = new System.Drawing.Size(304, 21);
            this.cbDers.TabIndex = 6;
            this.cbDers.SelectedIndexChanged += new System.EventHandler(this.cbDers_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ders :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soru";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "A Şıkkı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "B Şıkkı :";
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(92, 141);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(304, 143);
            this.txtSoru.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "C Şıkkı :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(438, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "D Şıkkı :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "E Şıkkı :";
            // 
            // cbDogruCevap
            // 
            this.cbDogruCevap.FormattingEnabled = true;
            this.cbDogruCevap.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cbDogruCevap.Location = new System.Drawing.Point(490, 188);
            this.cbDogruCevap.Name = "cbDogruCevap";
            this.cbDogruCevap.Size = new System.Drawing.Size(283, 21);
            this.cbDogruCevap.TabIndex = 20;
            this.cbDogruCevap.Text = "Seçiniz..";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(408, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Dogru Cevap :";
            // 
            // cbZorluk
            // 
            this.cbZorluk.FormattingEnabled = true;
            this.cbZorluk.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cbZorluk.Location = new System.Drawing.Point(490, 215);
            this.cbZorluk.Name = "cbZorluk";
            this.cbZorluk.Size = new System.Drawing.Size(283, 21);
            this.cbZorluk.TabIndex = 22;
            this.cbZorluk.Text = "Seçiniz..";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(408, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Zorluk :";
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Items.AddRange(new object[] {
            "Vize",
            "Final"});
            this.cbKategori.Location = new System.Drawing.Point(490, 242);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(283, 21);
            this.cbKategori.TabIndex = 24;
            this.cbKategori.Text = "Seçiniz..";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(408, 250);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Kategori :";
            // 
            // güncelle
            // 
            this.güncelle.Location = new System.Drawing.Point(691, 283);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(82, 29);
            this.güncelle.TabIndex = 27;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(585, 283);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(86, 29);
            this.sil.TabIndex = 26;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(481, 283);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(89, 29);
            this.ekle.TabIndex = 25;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // txtCevapA
            // 
            this.txtCevapA.Location = new System.Drawing.Point(491, 19);
            this.txtCevapA.Name = "txtCevapA";
            this.txtCevapA.Size = new System.Drawing.Size(282, 20);
            this.txtCevapA.TabIndex = 28;
            // 
            // txtCevapB
            // 
            this.txtCevapB.Location = new System.Drawing.Point(491, 47);
            this.txtCevapB.Name = "txtCevapB";
            this.txtCevapB.Size = new System.Drawing.Size(282, 20);
            this.txtCevapB.TabIndex = 29;
            // 
            // txtCevapC
            // 
            this.txtCevapC.Location = new System.Drawing.Point(491, 77);
            this.txtCevapC.Name = "txtCevapC";
            this.txtCevapC.Size = new System.Drawing.Size(282, 20);
            this.txtCevapC.TabIndex = 30;
            // 
            // txtCevapD
            // 
            this.txtCevapD.Location = new System.Drawing.Point(491, 104);
            this.txtCevapD.Name = "txtCevapD";
            this.txtCevapD.Size = new System.Drawing.Size(282, 20);
            this.txtCevapD.TabIndex = 31;
            // 
            // txtCevapE
            // 
            this.txtCevapE.Location = new System.Drawing.Point(491, 130);
            this.txtCevapE.Name = "txtCevapE";
            this.txtCevapE.Size = new System.Drawing.Size(282, 20);
            this.txtCevapE.TabIndex = 32;
            // 
            // Sorular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 565);
            this.Controls.Add(this.txtCevapE);
            this.Controls.Add(this.txtCevapD);
            this.Controls.Add(this.txtCevapC);
            this.Controls.Add(this.txtCevapB);
            this.Controls.Add(this.txtCevapA);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbZorluk);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbDogruCevap);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBirim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sorular";
            this.Text = "Sorular";
            this.Load += new System.EventHandler(this.Sorular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBirim;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbDogruCevap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbZorluk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.TextBox txtCevapA;
        private System.Windows.Forms.TextBox txtCevapB;
        private System.Windows.Forms.TextBox txtCevapC;
        private System.Windows.Forms.TextBox txtCevapD;
        private System.Windows.Forms.TextBox txtCevapE;
    }
}
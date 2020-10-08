namespace Kitapcik1920
{
    partial class KitapcikSoru
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbSinavAdi = new System.Windows.Forms.ComboBox();
            this.cbKitapcikAdi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBirim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKarısık = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVizeZor = new System.Windows.Forms.TextBox();
            this.txtVizeOrta = new System.Windows.Forms.TextBox();
            this.txtVizeKolay = new System.Windows.Forms.TextBox();
            this.txtFinalKolay = new System.Windows.Forms.TextBox();
            this.txtFinalOrta = new System.Windows.Forms.TextBox();
            this.txtFinalZor = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSonEkle = new System.Windows.Forms.Button();
            this.txtSonEklenen = new System.Windows.Forms.TextBox();
            this.btnKitapcikTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinav Adi :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbSinavAdi
            // 
            this.cbSinavAdi.FormattingEnabled = true;
            this.cbSinavAdi.Location = new System.Drawing.Point(73, 6);
            this.cbSinavAdi.Name = "cbSinavAdi";
            this.cbSinavAdi.Size = new System.Drawing.Size(235, 21);
            this.cbSinavAdi.TabIndex = 1;
            this.cbSinavAdi.SelectedIndexChanged += new System.EventHandler(this.cbSinavAdi_SelectedIndexChanged);
            // 
            // cbKitapcikAdi
            // 
            this.cbKitapcikAdi.FormattingEnabled = true;
            this.cbKitapcikAdi.Location = new System.Drawing.Point(73, 35);
            this.cbKitapcikAdi.Name = "cbKitapcikAdi";
            this.cbKitapcikAdi.Size = new System.Drawing.Size(235, 21);
            this.cbKitapcikAdi.TabIndex = 3;
            this.cbKitapcikAdi.SelectedIndexChanged += new System.EventHandler(this.cbKitapcikAdi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitapçik Adi :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbBirim
            // 
            this.cbBirim.FormattingEnabled = true;
            this.cbBirim.Location = new System.Drawing.Point(382, 6);
            this.cbBirim.Name = "cbBirim";
            this.cbBirim.Size = new System.Drawing.Size(235, 21);
            this.cbBirim.TabIndex = 5;
            this.cbBirim.SelectedIndexChanged += new System.EventHandler(this.cbBirim_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Birim :";
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(382, 35);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(235, 21);
            this.cbProgram.TabIndex = 7;
            this.cbProgram.SelectedIndexChanged += new System.EventHandler(this.cbProgram_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Program :";
            // 
            // cbDers
            // 
            this.cbDers.FormattingEnabled = true;
            this.cbDers.Location = new System.Drawing.Point(382, 64);
            this.cbDers.Name = "cbDers";
            this.cbDers.Size = new System.Drawing.Size(235, 21);
            this.cbDers.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ders :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 209);
            this.dataGridView1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKarısık);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtVizeZor);
            this.groupBox1.Controls.Add(this.txtVizeOrta);
            this.groupBox1.Controls.Add(this.txtVizeKolay);
            this.groupBox1.Controls.Add(this.txtFinalKolay);
            this.groupBox1.Controls.Add(this.txtFinalOrta);
            this.groupBox1.Controls.Add(this.txtFinalZor);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 183);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Karışık Soru Bölümü ";
            // 
            // btnKarısık
            // 
            this.btnKarısık.Location = new System.Drawing.Point(175, 42);
            this.btnKarısık.Name = "btnKarısık";
            this.btnKarısık.Size = new System.Drawing.Size(75, 105);
            this.btnKarısık.TabIndex = 12;
            this.btnKarısık.Text = "Tüm Sorulardan Karıştır Ata";
            this.btnKarısık.UseVisualStyleBackColor = true;
            this.btnKarısık.Click += new System.EventHandler(this.btnKarısık_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Final - Zor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Final - Orta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Final - Kolay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Vize - Zor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Vize - Orta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Vize - Kolay";
            // 
            // txtVizeZor
            // 
            this.txtVizeZor.Location = new System.Drawing.Point(78, 75);
            this.txtVizeZor.Name = "txtVizeZor";
            this.txtVizeZor.Size = new System.Drawing.Size(79, 20);
            this.txtVizeZor.TabIndex = 5;
            // 
            // txtVizeOrta
            // 
            this.txtVizeOrta.Location = new System.Drawing.Point(78, 49);
            this.txtVizeOrta.Name = "txtVizeOrta";
            this.txtVizeOrta.Size = new System.Drawing.Size(79, 20);
            this.txtVizeOrta.TabIndex = 4;
            // 
            // txtVizeKolay
            // 
            this.txtVizeKolay.Location = new System.Drawing.Point(78, 23);
            this.txtVizeKolay.Name = "txtVizeKolay";
            this.txtVizeKolay.Size = new System.Drawing.Size(79, 20);
            this.txtVizeKolay.TabIndex = 3;
            // 
            // txtFinalKolay
            // 
            this.txtFinalKolay.Location = new System.Drawing.Point(78, 101);
            this.txtFinalKolay.Name = "txtFinalKolay";
            this.txtFinalKolay.Size = new System.Drawing.Size(79, 20);
            this.txtFinalKolay.TabIndex = 2;
            // 
            // txtFinalOrta
            // 
            this.txtFinalOrta.Location = new System.Drawing.Point(78, 127);
            this.txtFinalOrta.Name = "txtFinalOrta";
            this.txtFinalOrta.Size = new System.Drawing.Size(79, 20);
            this.txtFinalOrta.TabIndex = 1;
            // 
            // txtFinalZor
            // 
            this.txtFinalZor.Location = new System.Drawing.Point(78, 153);
            this.txtFinalZor.Name = "txtFinalZor";
            this.txtFinalZor.Size = new System.Drawing.Size(79, 20);
            this.txtFinalZor.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSonEkle);
            this.groupBox2.Controls.Add(this.txtSonEklenen);
            this.groupBox2.Location = new System.Drawing.Point(307, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 103);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Son Eklenen Soru Bölümü";
            // 
            // btnSonEkle
            // 
            this.btnSonEkle.Location = new System.Drawing.Point(6, 54);
            this.btnSonEkle.Name = "btnSonEkle";
            this.btnSonEkle.Size = new System.Drawing.Size(304, 39);
            this.btnSonEkle.TabIndex = 5;
            this.btnSonEkle.Text = "Son Eklenen Sorulardan Karıştır Ata";
            this.btnSonEkle.UseVisualStyleBackColor = true;
            this.btnSonEkle.Click += new System.EventHandler(this.btnSonEkle_Click);
            // 
            // txtSonEklenen
            // 
            this.txtSonEklenen.Location = new System.Drawing.Point(6, 27);
            this.txtSonEklenen.Name = "txtSonEklenen";
            this.txtSonEklenen.Size = new System.Drawing.Size(304, 20);
            this.txtSonEklenen.TabIndex = 4;
            // 
            // btnKitapcikTemizle
            // 
            this.btnKitapcikTemizle.Location = new System.Drawing.Point(307, 228);
            this.btnKitapcikTemizle.Name = "btnKitapcikTemizle";
            this.btnKitapcikTemizle.Size = new System.Drawing.Size(310, 39);
            this.btnKitapcikTemizle.TabIndex = 13;
            this.btnKitapcikTemizle.Text = "Kitapçılığı Temizle";
            this.btnKitapcikTemizle.UseVisualStyleBackColor = true;
            this.btnKitapcikTemizle.Click += new System.EventHandler(this.btnKitapcikTemizle_Click);
            // 
            // KitapcikSoru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 496);
            this.Controls.Add(this.btnKitapcikTemizle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbDers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbProgram);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBirim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbKitapcikAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSinavAdi);
            this.Controls.Add(this.label1);
            this.Name = "KitapcikSoru";
            this.Text = "KitapcikSoru";
            this.Load += new System.EventHandler(this.KitapcikSoru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSinavAdi;
        private System.Windows.Forms.ComboBox cbKitapcikAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVizeZor;
        private System.Windows.Forms.TextBox txtVizeOrta;
        private System.Windows.Forms.TextBox txtVizeKolay;
        private System.Windows.Forms.TextBox txtFinalKolay;
        private System.Windows.Forms.TextBox txtFinalOrta;
        private System.Windows.Forms.TextBox txtFinalZor;
        private System.Windows.Forms.Button btnKarısık;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSonEkle;
        private System.Windows.Forms.TextBox txtSonEklenen;
        private System.Windows.Forms.Button btnKitapcikTemizle;
    }
}
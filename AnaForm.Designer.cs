namespace Kitapcik1920
{
    partial class AnaForm
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
            this.LblAktifKullanici = new System.Windows.Forms.Label();
            this.BirimBtn = new System.Windows.Forms.Button();
            this.program = new System.Windows.Forms.Button();
            this.ders = new System.Windows.Forms.Button();
            this.sorular = new System.Windows.Forms.Button();
            this.sinav = new System.Windows.Forms.Button();
            this.kitapcik = new System.Windows.Forms.Button();
            this.kitapciksoru = new System.Windows.Forms.Button();
            this.rapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAktifKullanici
            // 
            this.LblAktifKullanici.AutoSize = true;
            this.LblAktifKullanici.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LblAktifKullanici.Location = new System.Drawing.Point(23, 13);
            this.LblAktifKullanici.Name = "LblAktifKullanici";
            this.LblAktifKullanici.Size = new System.Drawing.Size(70, 13);
            this.LblAktifKullanici.TabIndex = 0;
            this.LblAktifKullanici.Text = "Kullanici Adi :";
            // 
            // BirimBtn
            // 
            this.BirimBtn.Location = new System.Drawing.Point(28, 50);
            this.BirimBtn.Name = "BirimBtn";
            this.BirimBtn.Size = new System.Drawing.Size(128, 61);
            this.BirimBtn.TabIndex = 1;
            this.BirimBtn.Text = "Birim";
            this.BirimBtn.UseVisualStyleBackColor = true;
            this.BirimBtn.Click += new System.EventHandler(this.BirimBtn_Click);
            // 
            // program
            // 
            this.program.Location = new System.Drawing.Point(174, 50);
            this.program.Name = "program";
            this.program.Size = new System.Drawing.Size(125, 61);
            this.program.TabIndex = 2;
            this.program.Text = "Program";
            this.program.UseVisualStyleBackColor = true;
            this.program.Click += new System.EventHandler(this.program_Click);
            // 
            // ders
            // 
            this.ders.Location = new System.Drawing.Point(319, 50);
            this.ders.Name = "ders";
            this.ders.Size = new System.Drawing.Size(121, 61);
            this.ders.TabIndex = 3;
            this.ders.Text = "Ders";
            this.ders.UseVisualStyleBackColor = true;
            this.ders.Click += new System.EventHandler(this.ders_Click);
            // 
            // sorular
            // 
            this.sorular.Location = new System.Drawing.Point(458, 50);
            this.sorular.Name = "sorular";
            this.sorular.Size = new System.Drawing.Size(114, 61);
            this.sorular.TabIndex = 4;
            this.sorular.Text = "Sorular";
            this.sorular.UseVisualStyleBackColor = true;
            this.sorular.Click += new System.EventHandler(this.sorular_Click);
            // 
            // sinav
            // 
            this.sinav.Location = new System.Drawing.Point(28, 137);
            this.sinav.Name = "sinav";
            this.sinav.Size = new System.Drawing.Size(128, 55);
            this.sinav.TabIndex = 5;
            this.sinav.Text = "Sinav";
            this.sinav.UseVisualStyleBackColor = true;
            this.sinav.Click += new System.EventHandler(this.sinav_Click);
            // 
            // kitapcik
            // 
            this.kitapcik.Location = new System.Drawing.Point(174, 137);
            this.kitapcik.Name = "kitapcik";
            this.kitapcik.Size = new System.Drawing.Size(125, 55);
            this.kitapcik.TabIndex = 6;
            this.kitapcik.Text = "Kitapcik";
            this.kitapcik.UseVisualStyleBackColor = true;
            this.kitapcik.Click += new System.EventHandler(this.kitapcik_Click);
            // 
            // kitapciksoru
            // 
            this.kitapciksoru.Location = new System.Drawing.Point(319, 137);
            this.kitapciksoru.Name = "kitapciksoru";
            this.kitapciksoru.Size = new System.Drawing.Size(125, 55);
            this.kitapciksoru.TabIndex = 7;
            this.kitapciksoru.Text = "Kitapcik Soru";
            this.kitapciksoru.UseVisualStyleBackColor = true;
            this.kitapciksoru.Click += new System.EventHandler(this.kitapciksoru_Click);
            // 
            // rapor
            // 
            this.rapor.Location = new System.Drawing.Point(458, 137);
            this.rapor.Name = "rapor";
            this.rapor.Size = new System.Drawing.Size(114, 55);
            this.rapor.TabIndex = 8;
            this.rapor.Text = "Rapor Al";
            this.rapor.UseVisualStyleBackColor = true;
            this.rapor.Click += new System.EventHandler(this.rapor_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 389);
            this.Controls.Add(this.rapor);
            this.Controls.Add(this.kitapciksoru);
            this.Controls.Add(this.kitapcik);
            this.Controls.Add(this.sinav);
            this.Controls.Add(this.sorular);
            this.Controls.Add(this.ders);
            this.Controls.Add(this.program);
            this.Controls.Add(this.BirimBtn);
            this.Controls.Add(this.LblAktifKullanici);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblAktifKullanici;
        private System.Windows.Forms.Button BirimBtn;
        private System.Windows.Forms.Button program;
        private System.Windows.Forms.Button ders;
        private System.Windows.Forms.Button sorular;
        private System.Windows.Forms.Button sinav;
        private System.Windows.Forms.Button kitapcik;
        private System.Windows.Forms.Button kitapciksoru;
        private System.Windows.Forms.Button rapor;
    }
}
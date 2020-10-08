namespace Kitapcik1920
{
    partial class Rapor
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
            this.cbKitapcikAdi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSinavAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.raporal = new System.Windows.Forms.Button();
            this.cevapanaktarial = new System.Windows.Forms.Button();
            this.txtcevapanaktari = new System.Windows.Forms.TextBox();
            this.cbTasarim = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbKitapcikAdi
            // 
            this.cbKitapcikAdi.FormattingEnabled = true;
            this.cbKitapcikAdi.Location = new System.Drawing.Point(88, 41);
            this.cbKitapcikAdi.Name = "cbKitapcikAdi";
            this.cbKitapcikAdi.Size = new System.Drawing.Size(235, 21);
            this.cbKitapcikAdi.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kitapçik Adi :";
            // 
            // cbSinavAdi
            // 
            this.cbSinavAdi.FormattingEnabled = true;
            this.cbSinavAdi.Location = new System.Drawing.Point(88, 12);
            this.cbSinavAdi.Name = "cbSinavAdi";
            this.cbSinavAdi.Size = new System.Drawing.Size(235, 21);
            this.cbSinavAdi.TabIndex = 5;
            this.cbSinavAdi.SelectedIndexChanged += new System.EventHandler(this.cbSinavAdi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sinav Adi :";
            // 
            // raporal
            // 
            this.raporal.Location = new System.Drawing.Point(180, 68);
            this.raporal.Name = "raporal";
            this.raporal.Size = new System.Drawing.Size(138, 28);
            this.raporal.TabIndex = 8;
            this.raporal.Text = "Rapor Al";
            this.raporal.UseVisualStyleBackColor = true;
            this.raporal.Click += new System.EventHandler(this.raporal_Click);
            // 
            // cevapanaktarial
            // 
            this.cevapanaktarial.Location = new System.Drawing.Point(43, 111);
            this.cevapanaktarial.Name = "cevapanaktarial";
            this.cevapanaktarial.Size = new System.Drawing.Size(275, 30);
            this.cevapanaktarial.TabIndex = 9;
            this.cevapanaktarial.Text = "Cevap Anaktari Al";
            this.cevapanaktarial.UseVisualStyleBackColor = true;
            this.cevapanaktarial.Click += new System.EventHandler(this.cevapanaktarial_Click);
            // 
            // txtcevapanaktari
            // 
            this.txtcevapanaktari.Location = new System.Drawing.Point(43, 160);
            this.txtcevapanaktari.Name = "txtcevapanaktari";
            this.txtcevapanaktari.Size = new System.Drawing.Size(275, 20);
            this.txtcevapanaktari.TabIndex = 10;
            // 
            // cbTasarim
            // 
            this.cbTasarim.AutoSize = true;
            this.cbTasarim.Location = new System.Drawing.Point(52, 75);
            this.cbTasarim.Name = "cbTasarim";
            this.cbTasarim.Size = new System.Drawing.Size(93, 17);
            this.cbTasarim.TabIndex = 11;
            this.cbTasarim.Text = "Tasarım Modu";
            this.cbTasarim.UseVisualStyleBackColor = true;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 191);
            this.Controls.Add(this.cbTasarim);
            this.Controls.Add(this.txtcevapanaktari);
            this.Controls.Add(this.cevapanaktarial);
            this.Controls.Add(this.raporal);
            this.Controls.Add(this.cbKitapcikAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSinavAdi);
            this.Controls.Add(this.label1);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.Load += new System.EventHandler(this.Rapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKitapcikAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSinavAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button raporal;
        private System.Windows.Forms.Button cevapanaktarial;
        private System.Windows.Forms.TextBox txtcevapanaktari;
        private System.Windows.Forms.CheckBox cbTasarim;
    }
}
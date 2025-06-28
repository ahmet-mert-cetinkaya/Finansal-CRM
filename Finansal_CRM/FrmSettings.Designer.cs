namespace Finansal_CRM
{
    partial class FrmSettings
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
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.lbl_Kullanici_Adi = new System.Windows.Forms.Label();
            this.txt_Kullanici_Adi = new System.Windows.Forms.TextBox();
            this.btn_Bilgileri_Guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Sifre.Location = new System.Drawing.Point(103, 32);
            this.txt_Sifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(175, 22);
            this.txt_Sifre.TabIndex = 32;
            this.txt_Sifre.UseSystemPasswordChar = true;
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Sifre.ForeColor = System.Drawing.Color.White;
            this.lbl_Sifre.Location = new System.Drawing.Point(57, 35);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(40, 14);
            this.lbl_Sifre.TabIndex = 27;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // lbl_Kullanici_Adi
            // 
            this.lbl_Kullanici_Adi.AutoSize = true;
            this.lbl_Kullanici_Adi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kullanici_Adi.ForeColor = System.Drawing.Color.White;
            this.lbl_Kullanici_Adi.Location = new System.Drawing.Point(12, 9);
            this.lbl_Kullanici_Adi.Name = "lbl_Kullanici_Adi";
            this.lbl_Kullanici_Adi.Size = new System.Drawing.Size(85, 14);
            this.lbl_Kullanici_Adi.TabIndex = 23;
            this.lbl_Kullanici_Adi.Text = "Kullanıcı Adı:";
            // 
            // txt_Kullanici_Adi
            // 
            this.txt_Kullanici_Adi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Kullanici_Adi.Location = new System.Drawing.Point(103, 6);
            this.txt_Kullanici_Adi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Kullanici_Adi.Name = "txt_Kullanici_Adi";
            this.txt_Kullanici_Adi.Size = new System.Drawing.Size(175, 22);
            this.txt_Kullanici_Adi.TabIndex = 40;
            // 
            // btn_Bilgileri_Guncelle
            // 
            this.btn_Bilgileri_Guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Bilgileri_Guncelle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bilgileri_Guncelle.Location = new System.Drawing.Point(150, 61);
            this.btn_Bilgileri_Guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Bilgileri_Guncelle.Name = "btn_Bilgileri_Guncelle";
            this.btn_Bilgileri_Guncelle.Size = new System.Drawing.Size(128, 27);
            this.btn_Bilgileri_Guncelle.TabIndex = 41;
            this.btn_Bilgileri_Guncelle.Text = "Güncelle";
            this.btn_Bilgileri_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Bilgileri_Guncelle.Click += new System.EventHandler(this.btn_Bilgileri_Guncelle_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(283, 97);
            this.Controls.Add(this.btn_Bilgileri_Guncelle);
            this.Controls.Add(this.txt_Kullanici_Adi);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_Kullanici_Adi);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmSettings";
            this.Text = "Kullanici Bilgi Guncelleme";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.Label lbl_Kullanici_Adi;
        private System.Windows.Forms.TextBox txt_Kullanici_Adi;
        private System.Windows.Forms.Button btn_Bilgileri_Guncelle;
    }
}
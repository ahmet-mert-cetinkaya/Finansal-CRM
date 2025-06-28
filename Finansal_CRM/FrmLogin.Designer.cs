namespace Finansal_CRM
{
    partial class FrmLogin
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
            this.lbl_Kullanici_Adi = new System.Windows.Forms.Label();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.txt_Kullanici_Adi = new System.Windows.Forms.TextBox();
            this.btn_Giris_Yap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Kullanici_Adi
            // 
            this.lbl_Kullanici_Adi.AutoSize = true;
            this.lbl_Kullanici_Adi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kullanici_Adi.ForeColor = System.Drawing.Color.White;
            this.lbl_Kullanici_Adi.Location = new System.Drawing.Point(12, 9);
            this.lbl_Kullanici_Adi.Name = "lbl_Kullanici_Adi";
            this.lbl_Kullanici_Adi.Size = new System.Drawing.Size(85, 14);
            this.lbl_Kullanici_Adi.TabIndex = 16;
            this.lbl_Kullanici_Adi.Text = "Kullanıcı Adı:";
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Sifre.Location = new System.Drawing.Point(107, 32);
            this.txt_Sifre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(175, 22);
            this.txt_Sifre.TabIndex = 20;
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
            this.lbl_Sifre.TabIndex = 19;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // txt_Kullanici_Adi
            // 
            this.txt_Kullanici_Adi.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Kullanici_Adi.Location = new System.Drawing.Point(107, 6);
            this.txt_Kullanici_Adi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Kullanici_Adi.Name = "txt_Kullanici_Adi";
            this.txt_Kullanici_Adi.Size = new System.Drawing.Size(175, 22);
            this.txt_Kullanici_Adi.TabIndex = 39;
            // 
            // btn_Giris_Yap
            // 
            this.btn_Giris_Yap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Giris_Yap.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris_Yap.Location = new System.Drawing.Point(154, 58);
            this.btn_Giris_Yap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Giris_Yap.Name = "btn_Giris_Yap";
            this.btn_Giris_Yap.Size = new System.Drawing.Size(128, 27);
            this.btn_Giris_Yap.TabIndex = 40;
            this.btn_Giris_Yap.Text = "Giriş Yap";
            this.btn_Giris_Yap.UseVisualStyleBackColor = true;
            this.btn_Giris_Yap.Click += new System.EventHandler(this.btn_Giris_Yap_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(289, 93);
            this.Controls.Add(this.btn_Giris_Yap);
            this.Controls.Add(this.txt_Kullanici_Adi);
            this.Controls.Add(this.lbl_Kullanici_Adi);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.lbl_Sifre);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmLogin";
            this.Text = "Kullanıcı Giriş Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Kullanici_Adi;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label lbl_Sifre;
        private System.Windows.Forms.TextBox txt_Kullanici_Adi;
        private System.Windows.Forms.Button btn_Giris_Yap;
    }
}
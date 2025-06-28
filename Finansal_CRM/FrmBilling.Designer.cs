namespace Finansal_CRM
{
    partial class FrmBilling
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cikis_Yap = new System.Windows.Forms.Button();
            this.btn_Ayarlar = new System.Windows.Forms.Button();
            this.btn_Dashboard = new System.Windows.Forms.Button();
            this.btn_Giderler = new System.Windows.Forms.Button();
            this.btn_Banka_Hareketleri = new System.Windows.Forms.Button();
            this.btn_Bankalar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Odeme_Guncelle = new System.Windows.Forms.Button();
            this.btn_Odeme_Sil = new System.Windows.Forms.Button();
            this.btn_Yeni_Odeme = new System.Windows.Forms.Button();
            this.btn_Odeme_Listesi = new System.Windows.Forms.Button();
            this.txt_Period = new System.Windows.Forms.TextBox();
            this.lbl_Periyod = new System.Windows.Forms.Label();
            this.txt_Miktar = new System.Windows.Forms.TextBox();
            this.lbl_Miktar = new System.Windows.Forms.Label();
            this.txt_Baslik = new System.Windows.Forms.TextBox();
            this.lbl_Baslik = new System.Windows.Forms.Label();
            this.txt_Odeme_Id = new System.Windows.Forms.TextBox();
            this.lbl_Odeme_Id = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Odeme_Fatura_Formu = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btn_Cikis_Yap);
            this.panel1.Controls.Add(this.btn_Ayarlar);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.btn_Giderler);
            this.panel1.Controls.Add(this.btn_Banka_Hareketleri);
            this.panel1.Controls.Add(this.btn_Bankalar);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 349);
            this.panel1.TabIndex = 15;
            // 
            // btn_Cikis_Yap
            // 
            this.btn_Cikis_Yap.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cikis_Yap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cikis_Yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis_Yap.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis_Yap.ForeColor = System.Drawing.Color.White;
            this.btn_Cikis_Yap.Location = new System.Drawing.Point(3, 289);
            this.btn_Cikis_Yap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cikis_Yap.Name = "btn_Cikis_Yap";
            this.btn_Cikis_Yap.Size = new System.Drawing.Size(174, 53);
            this.btn_Cikis_Yap.TabIndex = 1;
            this.btn_Cikis_Yap.Text = "Çıkış Yap";
            this.btn_Cikis_Yap.UseVisualStyleBackColor = false;
            this.btn_Cikis_Yap.Click += new System.EventHandler(this.btn_Cikis_Yap_Click);
            // 
            // btn_Ayarlar
            // 
            this.btn_Ayarlar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ayarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ayarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ayarlar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ayarlar.ForeColor = System.Drawing.Color.White;
            this.btn_Ayarlar.Location = new System.Drawing.Point(3, 232);
            this.btn_Ayarlar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ayarlar.Name = "btn_Ayarlar";
            this.btn_Ayarlar.Size = new System.Drawing.Size(174, 53);
            this.btn_Ayarlar.TabIndex = 0;
            this.btn_Ayarlar.Text = "Ayarlar";
            this.btn_Ayarlar.UseVisualStyleBackColor = false;
            this.btn_Ayarlar.Click += new System.EventHandler(this.btn_Ayarlar_Click);
            // 
            // btn_Dashboard
            // 
            this.btn_Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.btn_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Dashboard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Dashboard.ForeColor = System.Drawing.Color.White;
            this.btn_Dashboard.Location = new System.Drawing.Point(3, 175);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(174, 53);
            this.btn_Dashboard.TabIndex = 0;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // btn_Giderler
            // 
            this.btn_Giderler.BackColor = System.Drawing.Color.Transparent;
            this.btn_Giderler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Giderler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Giderler.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giderler.ForeColor = System.Drawing.Color.White;
            this.btn_Giderler.Location = new System.Drawing.Point(2, 118);
            this.btn_Giderler.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Giderler.Name = "btn_Giderler";
            this.btn_Giderler.Size = new System.Drawing.Size(174, 53);
            this.btn_Giderler.TabIndex = 0;
            this.btn_Giderler.Text = "Giderler";
            this.btn_Giderler.UseVisualStyleBackColor = false;
            this.btn_Giderler.Click += new System.EventHandler(this.btn_Giderler_Click);
            // 
            // btn_Banka_Hareketleri
            // 
            this.btn_Banka_Hareketleri.BackColor = System.Drawing.Color.Transparent;
            this.btn_Banka_Hareketleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Banka_Hareketleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Banka_Hareketleri.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Banka_Hareketleri.ForeColor = System.Drawing.Color.White;
            this.btn_Banka_Hareketleri.Location = new System.Drawing.Point(2, 61);
            this.btn_Banka_Hareketleri.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Banka_Hareketleri.Name = "btn_Banka_Hareketleri";
            this.btn_Banka_Hareketleri.Size = new System.Drawing.Size(174, 53);
            this.btn_Banka_Hareketleri.TabIndex = 0;
            this.btn_Banka_Hareketleri.Text = "Banka Hareketleri";
            this.btn_Banka_Hareketleri.UseVisualStyleBackColor = false;
            this.btn_Banka_Hareketleri.Click += new System.EventHandler(this.btn_Banka_Hareketleri_Click);
            // 
            // btn_Bankalar
            // 
            this.btn_Bankalar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Bankalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Bankalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bankalar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Bankalar.ForeColor = System.Drawing.Color.White;
            this.btn_Bankalar.Location = new System.Drawing.Point(0, 4);
            this.btn_Bankalar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Bankalar.Name = "btn_Bankalar";
            this.btn_Bankalar.Size = new System.Drawing.Size(174, 53);
            this.btn_Bankalar.TabIndex = 0;
            this.btn_Bankalar.Text = "Bankalar";
            this.btn_Bankalar.UseVisualStyleBackColor = false;
            this.btn_Bankalar.Click += new System.EventHandler(this.btn_Bankalar_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(203, 299);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(764, 230);
            this.panel4.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.btn_Odeme_Guncelle);
            this.panel3.Controls.Add(this.btn_Odeme_Sil);
            this.panel3.Controls.Add(this.btn_Yeni_Odeme);
            this.panel3.Controls.Add(this.btn_Odeme_Listesi);
            this.panel3.Controls.Add(this.txt_Period);
            this.panel3.Controls.Add(this.lbl_Periyod);
            this.panel3.Controls.Add(this.txt_Miktar);
            this.panel3.Controls.Add(this.lbl_Miktar);
            this.panel3.Controls.Add(this.txt_Baslik);
            this.panel3.Controls.Add(this.lbl_Baslik);
            this.panel3.Controls.Add(this.txt_Odeme_Id);
            this.panel3.Controls.Add(this.lbl_Odeme_Id);
            this.panel3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(203, 58);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 237);
            this.panel3.TabIndex = 17;
            // 
            // btn_Odeme_Guncelle
            // 
            this.btn_Odeme_Guncelle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Odeme_Guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Odeme_Guncelle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Odeme_Guncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Odeme_Guncelle.Location = new System.Drawing.Point(602, 193);
            this.btn_Odeme_Guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Odeme_Guncelle.Name = "btn_Odeme_Guncelle";
            this.btn_Odeme_Guncelle.Size = new System.Drawing.Size(135, 28);
            this.btn_Odeme_Guncelle.TabIndex = 11;
            this.btn_Odeme_Guncelle.Text = "Ödeme Güncelle";
            this.btn_Odeme_Guncelle.UseVisualStyleBackColor = false;
            // 
            // btn_Odeme_Sil
            // 
            this.btn_Odeme_Sil.BackColor = System.Drawing.Color.Transparent;
            this.btn_Odeme_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Odeme_Sil.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Odeme_Sil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Odeme_Sil.Location = new System.Drawing.Point(435, 193);
            this.btn_Odeme_Sil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Odeme_Sil.Name = "btn_Odeme_Sil";
            this.btn_Odeme_Sil.Size = new System.Drawing.Size(135, 28);
            this.btn_Odeme_Sil.TabIndex = 10;
            this.btn_Odeme_Sil.Text = "Ödeme Sil";
            this.btn_Odeme_Sil.UseVisualStyleBackColor = false;
            // 
            // btn_Yeni_Odeme
            // 
            this.btn_Yeni_Odeme.BackColor = System.Drawing.Color.Transparent;
            this.btn_Yeni_Odeme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Yeni_Odeme.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yeni_Odeme.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Yeni_Odeme.Location = new System.Drawing.Point(268, 193);
            this.btn_Yeni_Odeme.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Yeni_Odeme.Name = "btn_Yeni_Odeme";
            this.btn_Yeni_Odeme.Size = new System.Drawing.Size(135, 28);
            this.btn_Yeni_Odeme.TabIndex = 9;
            this.btn_Yeni_Odeme.Text = "Yeni Ödeme";
            this.btn_Yeni_Odeme.UseVisualStyleBackColor = false;
            // 
            // btn_Odeme_Listesi
            // 
            this.btn_Odeme_Listesi.BackColor = System.Drawing.Color.Transparent;
            this.btn_Odeme_Listesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Odeme_Listesi.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Odeme_Listesi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Odeme_Listesi.Location = new System.Drawing.Point(102, 193);
            this.btn_Odeme_Listesi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Odeme_Listesi.Name = "btn_Odeme_Listesi";
            this.btn_Odeme_Listesi.Size = new System.Drawing.Size(135, 28);
            this.btn_Odeme_Listesi.TabIndex = 8;
            this.btn_Odeme_Listesi.Text = "Ödeme Listesi";
            this.btn_Odeme_Listesi.UseVisualStyleBackColor = false;
            this.btn_Odeme_Listesi.Click += new System.EventHandler(this.btn_Odeme_Listesi_Click);
            // 
            // txt_Period
            // 
            this.txt_Period.BackColor = System.Drawing.Color.White;
            this.txt_Period.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Period.Location = new System.Drawing.Point(102, 151);
            this.txt_Period.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Period.Name = "txt_Period";
            this.txt_Period.Size = new System.Drawing.Size(636, 24);
            this.txt_Period.TabIndex = 7;
            // 
            // lbl_Periyod
            // 
            this.lbl_Periyod.AutoSize = true;
            this.lbl_Periyod.BackColor = System.Drawing.Color.Navy;
            this.lbl_Periyod.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Periyod.ForeColor = System.Drawing.Color.White;
            this.lbl_Periyod.Location = new System.Drawing.Point(26, 152);
            this.lbl_Periyod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Periyod.Name = "lbl_Periyod";
            this.lbl_Periyod.Size = new System.Drawing.Size(75, 18);
            this.lbl_Periyod.TabIndex = 6;
            this.lbl_Periyod.Text = "Periyod:";
            // 
            // txt_Miktar
            // 
            this.txt_Miktar.BackColor = System.Drawing.Color.White;
            this.txt_Miktar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Miktar.Location = new System.Drawing.Point(102, 104);
            this.txt_Miktar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Miktar.Name = "txt_Miktar";
            this.txt_Miktar.Size = new System.Drawing.Size(636, 24);
            this.txt_Miktar.TabIndex = 5;
            // 
            // lbl_Miktar
            // 
            this.lbl_Miktar.AutoSize = true;
            this.lbl_Miktar.BackColor = System.Drawing.Color.Navy;
            this.lbl_Miktar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Miktar.ForeColor = System.Drawing.Color.White;
            this.lbl_Miktar.Location = new System.Drawing.Point(32, 106);
            this.lbl_Miktar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Miktar.Name = "lbl_Miktar";
            this.lbl_Miktar.Size = new System.Drawing.Size(65, 18);
            this.lbl_Miktar.TabIndex = 4;
            this.lbl_Miktar.Text = "Miktar:";
            // 
            // txt_Baslik
            // 
            this.txt_Baslik.BackColor = System.Drawing.Color.White;
            this.txt_Baslik.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Baslik.Location = new System.Drawing.Point(102, 57);
            this.txt_Baslik.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Baslik.Name = "txt_Baslik";
            this.txt_Baslik.Size = new System.Drawing.Size(636, 24);
            this.txt_Baslik.TabIndex = 3;
            // 
            // lbl_Baslik
            // 
            this.lbl_Baslik.AutoSize = true;
            this.lbl_Baslik.BackColor = System.Drawing.Color.Navy;
            this.lbl_Baslik.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Baslik.ForeColor = System.Drawing.Color.White;
            this.lbl_Baslik.Location = new System.Drawing.Point(37, 58);
            this.lbl_Baslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Baslik.Name = "lbl_Baslik";
            this.lbl_Baslik.Size = new System.Drawing.Size(64, 18);
            this.lbl_Baslik.TabIndex = 2;
            this.lbl_Baslik.Text = "Başlık:";
            // 
            // txt_Odeme_Id
            // 
            this.txt_Odeme_Id.BackColor = System.Drawing.Color.White;
            this.txt_Odeme_Id.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Odeme_Id.Location = new System.Drawing.Point(102, 10);
            this.txt_Odeme_Id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Odeme_Id.Name = "txt_Odeme_Id";
            this.txt_Odeme_Id.Size = new System.Drawing.Size(636, 24);
            this.txt_Odeme_Id.TabIndex = 1;
            // 
            // lbl_Odeme_Id
            // 
            this.lbl_Odeme_Id.AutoSize = true;
            this.lbl_Odeme_Id.BackColor = System.Drawing.Color.Navy;
            this.lbl_Odeme_Id.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Odeme_Id.ForeColor = System.Drawing.Color.White;
            this.lbl_Odeme_Id.Location = new System.Drawing.Point(3, 11);
            this.lbl_Odeme_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Odeme_Id.Name = "lbl_Odeme_Id";
            this.lbl_Odeme_Id.Size = new System.Drawing.Size(98, 18);
            this.lbl_Odeme_Id.TabIndex = 0;
            this.lbl_Odeme_Id.Text = "Ödeme ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.lbl_Odeme_Fatura_Formu);
            this.panel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 49);
            this.panel2.TabIndex = 16;
            // 
            // lbl_Odeme_Fatura_Formu
            // 
            this.lbl_Odeme_Fatura_Formu.AutoSize = true;
            this.lbl_Odeme_Fatura_Formu.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Odeme_Fatura_Formu.ForeColor = System.Drawing.Color.White;
            this.lbl_Odeme_Fatura_Formu.Location = new System.Drawing.Point(9, 12);
            this.lbl_Odeme_Fatura_Formu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Odeme_Fatura_Formu.Name = "lbl_Odeme_Fatura_Formu";
            this.lbl_Odeme_Fatura_Formu.Size = new System.Drawing.Size(249, 25);
            this.lbl_Odeme_Fatura_Formu.TabIndex = 2;
            this.lbl_Odeme_Fatura_Formu.Text = "Ödeme & Fatura Formu";
            this.lbl_Odeme_Fatura_Formu.UseMnemonic = false;
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(973, 535);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBilling";
            this.Text = "Ödeme & Fatura Formu";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cikis_Yap;
        private System.Windows.Forms.Button btn_Ayarlar;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_Giderler;
        private System.Windows.Forms.Button btn_Banka_Hareketleri;
        private System.Windows.Forms.Button btn_Bankalar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Odeme_Guncelle;
        private System.Windows.Forms.Button btn_Odeme_Sil;
        private System.Windows.Forms.Button btn_Yeni_Odeme;
        private System.Windows.Forms.Button btn_Odeme_Listesi;
        private System.Windows.Forms.TextBox txt_Period;
        private System.Windows.Forms.Label lbl_Periyod;
        private System.Windows.Forms.TextBox txt_Miktar;
        private System.Windows.Forms.Label lbl_Miktar;
        private System.Windows.Forms.TextBox txt_Baslik;
        private System.Windows.Forms.Label lbl_Baslik;
        private System.Windows.Forms.TextBox txt_Odeme_Id;
        private System.Windows.Forms.Label lbl_Odeme_Id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Odeme_Fatura_Formu;
    }
}
namespace Finansal_CRM
{
    partial class FrmSpendings
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
            this.btn_Faturalar = new System.Windows.Forms.Button();
            this.btn_Banka_Hareketleri = new System.Windows.Forms.Button();
            this.btn_Bankalar = new System.Windows.Forms.Button();
            this.cmb_Kategori = new System.Windows.Forms.ComboBox();
            this.lbl_Miktar = new System.Windows.Forms.Label();
            this.txt_Miktar = new System.Windows.Forms.TextBox();
            this.lbl_Kategori = new System.Windows.Forms.Label();
            this.txt_Aciklama = new System.Windows.Forms.TextBox();
            this.lbl_Aciklama = new System.Windows.Forms.Label();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.txt_Gider_Id = new System.Windows.Forms.TextBox();
            this.lbl_Gider_Id = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblHighestSpendDesc = new System.Windows.Forms.Label();
            this.lbl_En_Yuksek_Harcama_Veri = new System.Windows.Forms.Label();
            this.lbl_En_Yuksek_Harcama = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Giderler = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLastSpendDesc = new System.Windows.Forms.Label();
            this.lbl_Son_Harcama_Veri = new System.Windows.Forms.Label();
            this.lbl_Son_Harcama = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Toplam_Gider_Veri = new System.Windows.Forms.Label();
            this.lbl_Toplam_Gider = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btn_Cikis_Yap);
            this.panel1.Controls.Add(this.btn_Ayarlar);
            this.panel1.Controls.Add(this.btn_Dashboard);
            this.panel1.Controls.Add(this.btn_Faturalar);
            this.panel1.Controls.Add(this.btn_Banka_Hareketleri);
            this.panel1.Controls.Add(this.btn_Bankalar);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(2, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 407);
            this.panel1.TabIndex = 20;
            // 
            // btn_Cikis_Yap
            // 
            this.btn_Cikis_Yap.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cikis_Yap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cikis_Yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis_Yap.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis_Yap.ForeColor = System.Drawing.Color.White;
            this.btn_Cikis_Yap.Location = new System.Drawing.Point(0, 293);
            this.btn_Cikis_Yap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cikis_Yap.Name = "btn_Cikis_Yap";
            this.btn_Cikis_Yap.Size = new System.Drawing.Size(203, 53);
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
            this.btn_Ayarlar.Location = new System.Drawing.Point(0, 236);
            this.btn_Ayarlar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ayarlar.Name = "btn_Ayarlar";
            this.btn_Ayarlar.Size = new System.Drawing.Size(203, 53);
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
            this.btn_Dashboard.Location = new System.Drawing.Point(0, 180);
            this.btn_Dashboard.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Dashboard.Name = "btn_Dashboard";
            this.btn_Dashboard.Size = new System.Drawing.Size(203, 53);
            this.btn_Dashboard.TabIndex = 0;
            this.btn_Dashboard.Text = "Dashboard";
            this.btn_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Dashboard.Click += new System.EventHandler(this.btn_Dashboard_Click);
            // 
            // btn_Faturalar
            // 
            this.btn_Faturalar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Faturalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Faturalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Faturalar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Faturalar.ForeColor = System.Drawing.Color.White;
            this.btn_Faturalar.Location = new System.Drawing.Point(0, 123);
            this.btn_Faturalar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Faturalar.Name = "btn_Faturalar";
            this.btn_Faturalar.Size = new System.Drawing.Size(203, 53);
            this.btn_Faturalar.TabIndex = 0;
            this.btn_Faturalar.Text = "Faturalar";
            this.btn_Faturalar.UseVisualStyleBackColor = false;
            this.btn_Faturalar.Click += new System.EventHandler(this.btn_Faturalar_Click);
            // 
            // btn_Banka_Hareketleri
            // 
            this.btn_Banka_Hareketleri.BackColor = System.Drawing.Color.Transparent;
            this.btn_Banka_Hareketleri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Banka_Hareketleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Banka_Hareketleri.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Banka_Hareketleri.ForeColor = System.Drawing.Color.White;
            this.btn_Banka_Hareketleri.Location = new System.Drawing.Point(0, 66);
            this.btn_Banka_Hareketleri.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Banka_Hareketleri.Name = "btn_Banka_Hareketleri";
            this.btn_Banka_Hareketleri.Size = new System.Drawing.Size(203, 53);
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
            this.btn_Bankalar.Location = new System.Drawing.Point(0, 9);
            this.btn_Bankalar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Bankalar.Name = "btn_Bankalar";
            this.btn_Bankalar.Size = new System.Drawing.Size(203, 53);
            this.btn_Bankalar.TabIndex = 0;
            this.btn_Bankalar.Text = "Bankalar";
            this.btn_Bankalar.UseVisualStyleBackColor = false;
            this.btn_Bankalar.Click += new System.EventHandler(this.btn_Bankalar_Click);
            // 
            // cmb_Kategori
            // 
            this.cmb_Kategori.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_Kategori.FormattingEnabled = true;
            this.cmb_Kategori.Location = new System.Drawing.Point(324, 274);
            this.cmb_Kategori.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_Kategori.Name = "cmb_Kategori";
            this.cmb_Kategori.Size = new System.Drawing.Size(121, 26);
            this.cmb_Kategori.TabIndex = 68;
            // 
            // lbl_Miktar
            // 
            this.lbl_Miktar.AutoSize = true;
            this.lbl_Miktar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Miktar.ForeColor = System.Drawing.Color.White;
            this.lbl_Miktar.Location = new System.Drawing.Point(273, 321);
            this.lbl_Miktar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Miktar.Name = "lbl_Miktar";
            this.lbl_Miktar.Size = new System.Drawing.Size(50, 14);
            this.lbl_Miktar.TabIndex = 67;
            this.lbl_Miktar.Text = "Miktar:";
            // 
            // txt_Miktar
            // 
            this.txt_Miktar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Miktar.Location = new System.Drawing.Point(324, 314);
            this.txt_Miktar.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Miktar.Name = "txt_Miktar";
            this.txt_Miktar.Size = new System.Drawing.Size(121, 27);
            this.txt_Miktar.TabIndex = 66;
            // 
            // lbl_Kategori
            // 
            this.lbl_Kategori.AutoSize = true;
            this.lbl_Kategori.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kategori.ForeColor = System.Drawing.Color.White;
            this.lbl_Kategori.Location = new System.Drawing.Point(257, 281);
            this.lbl_Kategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Kategori.Name = "lbl_Kategori";
            this.lbl_Kategori.Size = new System.Drawing.Size(65, 14);
            this.lbl_Kategori.TabIndex = 65;
            this.lbl_Kategori.Text = "Kategori:";
            // 
            // txt_Aciklama
            // 
            this.txt_Aciklama.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Aciklama.Location = new System.Drawing.Point(324, 235);
            this.txt_Aciklama.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Aciklama.Name = "txt_Aciklama";
            this.txt_Aciklama.Size = new System.Drawing.Size(121, 27);
            this.txt_Aciklama.TabIndex = 64;
            // 
            // lbl_Aciklama
            // 
            this.lbl_Aciklama.AutoSize = true;
            this.lbl_Aciklama.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Aciklama.ForeColor = System.Drawing.Color.White;
            this.lbl_Aciklama.Location = new System.Drawing.Point(256, 242);
            this.lbl_Aciklama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Aciklama.Name = "lbl_Aciklama";
            this.lbl_Aciklama.Size = new System.Drawing.Size(66, 14);
            this.lbl_Aciklama.TabIndex = 63;
            this.lbl_Aciklama.Text = "Açıklama:";
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guncelle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Guncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Guncelle.Location = new System.Drawing.Point(324, 507);
            this.btn_Guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(120, 33);
            this.btn_Guncelle.TabIndex = 62;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = false;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Listele
            // 
            this.btn_Listele.BackColor = System.Drawing.Color.Transparent;
            this.btn_Listele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Listele.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Listele.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Listele.Location = new System.Drawing.Point(324, 366);
            this.btn_Listele.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(120, 33);
            this.btn_Listele.TabIndex = 61;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = false;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.BackColor = System.Drawing.Color.Transparent;
            this.btn_Sil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sil.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Sil.Location = new System.Drawing.Point(324, 460);
            this.btn_Sil.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(120, 33);
            this.btn_Sil.TabIndex = 60;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = false;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ekle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ekle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Ekle.Location = new System.Drawing.Point(324, 413);
            this.btn_Ekle.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(120, 33);
            this.btn_Ekle.TabIndex = 59;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = false;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // txt_Gider_Id
            // 
            this.txt_Gider_Id.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Gider_Id.Location = new System.Drawing.Point(324, 196);
            this.txt_Gider_Id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Gider_Id.Name = "txt_Gider_Id";
            this.txt_Gider_Id.Size = new System.Drawing.Size(121, 27);
            this.txt_Gider_Id.TabIndex = 58;
            // 
            // lbl_Gider_Id
            // 
            this.lbl_Gider_Id.AutoSize = true;
            this.lbl_Gider_Id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Gider_Id.ForeColor = System.Drawing.Color.White;
            this.lbl_Gider_Id.Location = new System.Drawing.Point(259, 203);
            this.lbl_Gider_Id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Gider_Id.Name = "lbl_Gider_Id";
            this.lbl_Gider_Id.Size = new System.Drawing.Size(63, 14);
            this.lbl_Gider_Id.TabIndex = 57;
            this.lbl_Gider_Id.Text = "Gider ID:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.Location = new System.Drawing.Point(449, 196);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(667, 398);
            this.panel6.TabIndex = 56;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(667, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblHighestSpendDesc);
            this.panel4.Controls.Add(this.lbl_En_Yuksek_Harcama_Veri);
            this.panel4.Controls.Add(this.lbl_En_Yuksek_Harcama);
            this.panel4.Location = new System.Drawing.Point(523, 61);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 122);
            this.panel4.TabIndex = 55;
            // 
            // lblHighestSpendDesc
            // 
            this.lblHighestSpendDesc.AutoSize = true;
            this.lblHighestSpendDesc.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHighestSpendDesc.ForeColor = System.Drawing.Color.White;
            this.lblHighestSpendDesc.Location = new System.Drawing.Point(0, 106);
            this.lblHighestSpendDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHighestSpendDesc.Name = "lblHighestSpendDesc";
            this.lblHighestSpendDesc.Size = new System.Drawing.Size(11, 14);
            this.lblHighestSpendDesc.TabIndex = 4;
            this.lblHighestSpendDesc.Text = "-";
            // 
            // lbl_En_Yuksek_Harcama_Veri
            // 
            this.lbl_En_Yuksek_Harcama_Veri.AutoSize = true;
            this.lbl_En_Yuksek_Harcama_Veri.Font = new System.Drawing.Font("Verdana", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_En_Yuksek_Harcama_Veri.ForeColor = System.Drawing.Color.White;
            this.lbl_En_Yuksek_Harcama_Veri.Location = new System.Drawing.Point(35, 41);
            this.lbl_En_Yuksek_Harcama_Veri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_En_Yuksek_Harcama_Veri.Name = "lbl_En_Yuksek_Harcama_Veri";
            this.lbl_En_Yuksek_Harcama_Veri.Size = new System.Drawing.Size(148, 47);
            this.lbl_En_Yuksek_Harcama_Veri.TabIndex = 3;
            this.lbl_En_Yuksek_Harcama_Veri.Text = "0,00 ₺";
            // 
            // lbl_En_Yuksek_Harcama
            // 
            this.lbl_En_Yuksek_Harcama.AutoSize = true;
            this.lbl_En_Yuksek_Harcama.BackColor = System.Drawing.Color.Navy;
            this.lbl_En_Yuksek_Harcama.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_En_Yuksek_Harcama.ForeColor = System.Drawing.Color.White;
            this.lbl_En_Yuksek_Harcama.Location = new System.Drawing.Point(0, 0);
            this.lbl_En_Yuksek_Harcama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_En_Yuksek_Harcama.Name = "lbl_En_Yuksek_Harcama";
            this.lbl_En_Yuksek_Harcama.Size = new System.Drawing.Size(244, 28);
            this.lbl_En_Yuksek_Harcama.TabIndex = 1;
            this.lbl_En_Yuksek_Harcama.Text = "En Yüksek Harcama";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.lbl_Giderler);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 49);
            this.panel2.TabIndex = 52;
            // 
            // lbl_Giderler
            // 
            this.lbl_Giderler.AutoSize = true;
            this.lbl_Giderler.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Giderler.ForeColor = System.Drawing.Color.White;
            this.lbl_Giderler.Location = new System.Drawing.Point(10, 12);
            this.lbl_Giderler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Giderler.Name = "lbl_Giderler";
            this.lbl_Giderler.Size = new System.Drawing.Size(166, 25);
            this.lbl_Giderler.TabIndex = 2;
            this.lbl_Giderler.Text = "Giderler Formu";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblLastSpendDesc);
            this.panel5.Controls.Add(this.lbl_Son_Harcama_Veri);
            this.panel5.Controls.Add(this.lbl_Son_Harcama);
            this.panel5.Location = new System.Drawing.Point(828, 61);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 122);
            this.panel5.TabIndex = 54;
            // 
            // lblLastSpendDesc
            // 
            this.lblLastSpendDesc.AutoSize = true;
            this.lblLastSpendDesc.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastSpendDesc.ForeColor = System.Drawing.Color.White;
            this.lblLastSpendDesc.Location = new System.Drawing.Point(5, 106);
            this.lblLastSpendDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastSpendDesc.Name = "lblLastSpendDesc";
            this.lblLastSpendDesc.Size = new System.Drawing.Size(11, 14);
            this.lblLastSpendDesc.TabIndex = 5;
            this.lblLastSpendDesc.Text = "-";
            // 
            // lbl_Son_Harcama_Veri
            // 
            this.lbl_Son_Harcama_Veri.AutoSize = true;
            this.lbl_Son_Harcama_Veri.Font = new System.Drawing.Font("Verdana", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Son_Harcama_Veri.ForeColor = System.Drawing.Color.White;
            this.lbl_Son_Harcama_Veri.Location = new System.Drawing.Point(35, 41);
            this.lbl_Son_Harcama_Veri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Son_Harcama_Veri.Name = "lbl_Son_Harcama_Veri";
            this.lbl_Son_Harcama_Veri.Size = new System.Drawing.Size(148, 47);
            this.lbl_Son_Harcama_Veri.TabIndex = 2;
            this.lbl_Son_Harcama_Veri.Text = "0,00 ₺";
            // 
            // lbl_Son_Harcama
            // 
            this.lbl_Son_Harcama.AutoSize = true;
            this.lbl_Son_Harcama.BackColor = System.Drawing.Color.Navy;
            this.lbl_Son_Harcama.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Son_Harcama.ForeColor = System.Drawing.Color.White;
            this.lbl_Son_Harcama.Location = new System.Drawing.Point(0, 0);
            this.lbl_Son_Harcama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Son_Harcama.Name = "lbl_Son_Harcama";
            this.lbl_Son_Harcama.Size = new System.Drawing.Size(168, 28);
            this.lbl_Son_Harcama.TabIndex = 2;
            this.lbl_Son_Harcama.Text = "Son Harcama";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_Toplam_Gider_Veri);
            this.panel3.Controls.Add(this.lbl_Toplam_Gider);
            this.panel3.Location = new System.Drawing.Point(216, 61);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(288, 122);
            this.panel3.TabIndex = 53;
            // 
            // lbl_Toplam_Gider_Veri
            // 
            this.lbl_Toplam_Gider_Veri.AutoSize = true;
            this.lbl_Toplam_Gider_Veri.Font = new System.Drawing.Font("Verdana", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Toplam_Gider_Veri.ForeColor = System.Drawing.Color.White;
            this.lbl_Toplam_Gider_Veri.Location = new System.Drawing.Point(35, 41);
            this.lbl_Toplam_Gider_Veri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Toplam_Gider_Veri.Name = "lbl_Toplam_Gider_Veri";
            this.lbl_Toplam_Gider_Veri.Size = new System.Drawing.Size(148, 47);
            this.lbl_Toplam_Gider_Veri.TabIndex = 1;
            this.lbl_Toplam_Gider_Veri.Text = "0,00 ₺";
            // 
            // lbl_Toplam_Gider
            // 
            this.lbl_Toplam_Gider.AutoSize = true;
            this.lbl_Toplam_Gider.BackColor = System.Drawing.Color.Navy;
            this.lbl_Toplam_Gider.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Toplam_Gider.ForeColor = System.Drawing.Color.White;
            this.lbl_Toplam_Gider.Location = new System.Drawing.Point(0, 0);
            this.lbl_Toplam_Gider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Toplam_Gider.Name = "lbl_Toplam_Gider";
            this.lbl_Toplam_Gider.Size = new System.Drawing.Size(164, 28);
            this.lbl_Toplam_Gider.TabIndex = 0;
            this.lbl_Toplam_Gider.Text = "Toplam Gider";
            // 
            // FrmSpendings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1120, 598);
            this.Controls.Add(this.cmb_Kategori);
            this.Controls.Add(this.lbl_Miktar);
            this.Controls.Add(this.txt_Miktar);
            this.Controls.Add(this.lbl_Kategori);
            this.Controls.Add(this.txt_Aciklama);
            this.Controls.Add(this.lbl_Aciklama);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_Gider_Id);
            this.Controls.Add(this.lbl_Gider_Id);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmSpendings";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmSpendings_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cikis_Yap;
        private System.Windows.Forms.Button btn_Ayarlar;
        private System.Windows.Forms.Button btn_Dashboard;
        private System.Windows.Forms.Button btn_Faturalar;
        private System.Windows.Forms.Button btn_Banka_Hareketleri;
        private System.Windows.Forms.Button btn_Bankalar;
        private System.Windows.Forms.ComboBox cmb_Kategori;
        private System.Windows.Forms.Label lbl_Miktar;
        private System.Windows.Forms.TextBox txt_Miktar;
        private System.Windows.Forms.Label lbl_Kategori;
        private System.Windows.Forms.TextBox txt_Aciklama;
        private System.Windows.Forms.Label lbl_Aciklama;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.TextBox txt_Gider_Id;
        private System.Windows.Forms.Label lbl_Gider_Id;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblHighestSpendDesc;
        private System.Windows.Forms.Label lbl_En_Yuksek_Harcama_Veri;
        private System.Windows.Forms.Label lbl_En_Yuksek_Harcama;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Giderler;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblLastSpendDesc;
        private System.Windows.Forms.Label lbl_Son_Harcama_Veri;
        private System.Windows.Forms.Label lbl_Son_Harcama;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Toplam_Gider_Veri;
        private System.Windows.Forms.Label lbl_Toplam_Gider;
    }
}
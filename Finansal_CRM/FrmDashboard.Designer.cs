namespace Finansal_CRM
{
    partial class FrmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_Fatura_Bilgi = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_Banka_Bilgi = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_Gelen_Son_Havale_Veri = new System.Windows.Forms.Label();
            this.lbl_Gelen_Son_Havale = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Toplam_Bakiye_Veri = new System.Windows.Forms.Label();
            this.lbl_Toplam_Bakiye = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Fatura_Basligi_Veri = new System.Windows.Forms.Label();
            this.lbl_Fatura_Basligi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_Dashboard_Formu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cikis_Yap = new System.Windows.Forms.Button();
            this.btn_Ayarlar = new System.Windows.Forms.Button();
            this.btn_Giderler = new System.Windows.Forms.Button();
            this.btn_Faturalar = new System.Windows.Forms.Button();
            this.btn_Banka_Hareketleri = new System.Windows.Forms.Button();
            this.btn_Bankalar = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Navy;
            this.panel7.Controls.Add(this.lbl_Fatura_Bilgi);
            this.panel7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(581, 191);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(415, 94);
            this.panel7.TabIndex = 20;
            // 
            // lbl_Fatura_Bilgi
            // 
            this.lbl_Fatura_Bilgi.AutoSize = true;
            this.lbl_Fatura_Bilgi.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Fatura_Bilgi.ForeColor = System.Drawing.Color.White;
            this.lbl_Fatura_Bilgi.Location = new System.Drawing.Point(4, 30);
            this.lbl_Fatura_Bilgi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Fatura_Bilgi.Name = "lbl_Fatura_Bilgi";
            this.lbl_Fatura_Bilgi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Fatura_Bilgi.Size = new System.Drawing.Size(393, 26);
            this.lbl_Fatura_Bilgi.TabIndex = 1;
            this.lbl_Fatura_Bilgi.Text = "Ödenen ve ödenmesi gereken fatura tutarlarına aşağıdaki grafikten\r\nulaşabilirsini" +
    "z.\r\n";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Navy;
            this.panel6.Controls.Add(this.lbl_Banka_Bilgi);
            this.panel6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel6.Location = new System.Drawing.Point(185, 191);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(392, 94);
            this.panel6.TabIndex = 19;
            // 
            // lbl_Banka_Bilgi
            // 
            this.lbl_Banka_Bilgi.AutoSize = true;
            this.lbl_Banka_Bilgi.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Banka_Bilgi.ForeColor = System.Drawing.Color.White;
            this.lbl_Banka_Bilgi.Location = new System.Drawing.Point(4, 30);
            this.lbl_Banka_Bilgi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Banka_Bilgi.Name = "lbl_Banka_Bilgi";
            this.lbl_Banka_Bilgi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Banka_Bilgi.Size = new System.Drawing.Size(363, 26);
            this.lbl_Banka_Bilgi.TabIndex = 0;
            this.lbl_Banka_Bilgi.Text = "Bankalar ve banka hesaplarındaki para miktarlarına aşağıdaki\r\ngrafikten ulaşabili" +
    "rsiniz.\r\n";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lbl_Gelen_Son_Havale_Veri);
            this.panel5.Controls.Add(this.lbl_Gelen_Son_Havale);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(742, 57);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(254, 122);
            this.panel5.TabIndex = 17;
            // 
            // lbl_Gelen_Son_Havale_Veri
            // 
            this.lbl_Gelen_Son_Havale_Veri.AutoSize = true;
            this.lbl_Gelen_Son_Havale_Veri.Font = new System.Drawing.Font("Verdana", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Gelen_Son_Havale_Veri.ForeColor = System.Drawing.Color.White;
            this.lbl_Gelen_Son_Havale_Veri.Location = new System.Drawing.Point(30, 41);
            this.lbl_Gelen_Son_Havale_Veri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Gelen_Son_Havale_Veri.Name = "lbl_Gelen_Son_Havale_Veri";
            this.lbl_Gelen_Son_Havale_Veri.Size = new System.Drawing.Size(148, 47);
            this.lbl_Gelen_Son_Havale_Veri.TabIndex = 2;
            this.lbl_Gelen_Son_Havale_Veri.Text = "0,00 ₺";
            // 
            // lbl_Gelen_Son_Havale
            // 
            this.lbl_Gelen_Son_Havale.AutoSize = true;
            this.lbl_Gelen_Son_Havale.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Gelen_Son_Havale.ForeColor = System.Drawing.Color.White;
            this.lbl_Gelen_Son_Havale.Location = new System.Drawing.Point(0, 0);
            this.lbl_Gelen_Son_Havale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Gelen_Son_Havale.Name = "lbl_Gelen_Son_Havale";
            this.lbl_Gelen_Son_Havale.Size = new System.Drawing.Size(219, 28);
            this.lbl_Gelen_Son_Havale.TabIndex = 2;
            this.lbl_Gelen_Son_Havale.Text = "Gelen Son Havale";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lbl_Toplam_Bakiye_Veri);
            this.panel3.Controls.Add(this.lbl_Toplam_Bakiye);
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(184, 56);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 122);
            this.panel3.TabIndex = 16;
            // 
            // lbl_Toplam_Bakiye_Veri
            // 
            this.lbl_Toplam_Bakiye_Veri.AutoSize = true;
            this.lbl_Toplam_Bakiye_Veri.Font = new System.Drawing.Font("Verdana", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Toplam_Bakiye_Veri.ForeColor = System.Drawing.Color.White;
            this.lbl_Toplam_Bakiye_Veri.Location = new System.Drawing.Point(30, 41);
            this.lbl_Toplam_Bakiye_Veri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Toplam_Bakiye_Veri.Name = "lbl_Toplam_Bakiye_Veri";
            this.lbl_Toplam_Bakiye_Veri.Size = new System.Drawing.Size(148, 47);
            this.lbl_Toplam_Bakiye_Veri.TabIndex = 1;
            this.lbl_Toplam_Bakiye_Veri.Text = "0,00 ₺";
            // 
            // lbl_Toplam_Bakiye
            // 
            this.lbl_Toplam_Bakiye.AutoSize = true;
            this.lbl_Toplam_Bakiye.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Toplam_Bakiye.ForeColor = System.Drawing.Color.White;
            this.lbl_Toplam_Bakiye.Location = new System.Drawing.Point(0, 0);
            this.lbl_Toplam_Bakiye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Toplam_Bakiye.Name = "lbl_Toplam_Bakiye";
            this.lbl_Toplam_Bakiye.Size = new System.Drawing.Size(202, 28);
            this.lbl_Toplam_Bakiye.TabIndex = 0;
            this.lbl_Toplam_Bakiye.Text = "Toplam Bakiyem";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Navy;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbl_Fatura_Basligi_Veri);
            this.panel4.Controls.Add(this.lbl_Fatura_Basligi);
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(471, 56);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 122);
            this.panel4.TabIndex = 18;
            // 
            // lbl_Fatura_Basligi_Veri
            // 
            this.lbl_Fatura_Basligi_Veri.AutoSize = true;
            this.lbl_Fatura_Basligi_Veri.Font = new System.Drawing.Font("Verdana", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Fatura_Basligi_Veri.ForeColor = System.Drawing.Color.White;
            this.lbl_Fatura_Basligi_Veri.Location = new System.Drawing.Point(30, 41);
            this.lbl_Fatura_Basligi_Veri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Fatura_Basligi_Veri.Name = "lbl_Fatura_Basligi_Veri";
            this.lbl_Fatura_Basligi_Veri.Size = new System.Drawing.Size(148, 47);
            this.lbl_Fatura_Basligi_Veri.TabIndex = 3;
            this.lbl_Fatura_Basligi_Veri.Text = "0,00 ₺";
            // 
            // lbl_Fatura_Basligi
            // 
            this.lbl_Fatura_Basligi.AutoSize = true;
            this.lbl_Fatura_Basligi.Font = new System.Drawing.Font("Verdana", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Fatura_Basligi.ForeColor = System.Drawing.Color.White;
            this.lbl_Fatura_Basligi.Location = new System.Drawing.Point(0, 0);
            this.lbl_Fatura_Basligi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Fatura_Basligi.Name = "lbl_Fatura_Basligi";
            this.lbl_Fatura_Basligi.Size = new System.Drawing.Size(168, 28);
            this.lbl_Fatura_Basligi.TabIndex = 1;
            this.lbl_Fatura_Basligi.Text = "Fatura Başlığı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.lbl_Dashboard_Formu);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(995, 49);
            this.panel2.TabIndex = 15;
            // 
            // lbl_Dashboard_Formu
            // 
            this.lbl_Dashboard_Formu.AutoSize = true;
            this.lbl_Dashboard_Formu.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Dashboard_Formu.ForeColor = System.Drawing.Color.White;
            this.lbl_Dashboard_Formu.Location = new System.Drawing.Point(9, 12);
            this.lbl_Dashboard_Formu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Dashboard_Formu.Name = "lbl_Dashboard_Formu";
            this.lbl_Dashboard_Formu.Size = new System.Drawing.Size(334, 25);
            this.lbl_Dashboard_Formu.TabIndex = 2;
            this.lbl_Dashboard_Formu.Text = "Dashboard / Genel Bakış Formu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btn_Cikis_Yap);
            this.panel1.Controls.Add(this.btn_Ayarlar);
            this.panel1.Controls.Add(this.btn_Giderler);
            this.panel1.Controls.Add(this.btn_Faturalar);
            this.panel1.Controls.Add(this.btn_Banka_Hareketleri);
            this.panel1.Controls.Add(this.btn_Bankalar);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 349);
            this.panel1.TabIndex = 14;
            // 
            // btn_Cikis_Yap
            // 
            this.btn_Cikis_Yap.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cikis_Yap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cikis_Yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cikis_Yap.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Cikis_Yap.ForeColor = System.Drawing.Color.White;
            this.btn_Cikis_Yap.Location = new System.Drawing.Point(2, 292);
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
            this.btn_Ayarlar.Location = new System.Drawing.Point(2, 235);
            this.btn_Ayarlar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ayarlar.Name = "btn_Ayarlar";
            this.btn_Ayarlar.Size = new System.Drawing.Size(174, 53);
            this.btn_Ayarlar.TabIndex = 0;
            this.btn_Ayarlar.Text = "Ayarlar";
            this.btn_Ayarlar.UseVisualStyleBackColor = false;
            this.btn_Ayarlar.Click += new System.EventHandler(this.btn_Ayarlar_Click);
            // 
            // btn_Giderler
            // 
            this.btn_Giderler.BackColor = System.Drawing.Color.Transparent;
            this.btn_Giderler.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Giderler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Giderler.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giderler.ForeColor = System.Drawing.Color.White;
            this.btn_Giderler.Location = new System.Drawing.Point(2, 178);
            this.btn_Giderler.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Giderler.Name = "btn_Giderler";
            this.btn_Giderler.Size = new System.Drawing.Size(174, 53);
            this.btn_Giderler.TabIndex = 0;
            this.btn_Giderler.Text = "Giderler";
            this.btn_Giderler.UseVisualStyleBackColor = false;
            this.btn_Giderler.Click += new System.EventHandler(this.btn_Giderler_Click);
            // 
            // btn_Faturalar
            // 
            this.btn_Faturalar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Faturalar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Faturalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Faturalar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Faturalar.ForeColor = System.Drawing.Color.White;
            this.btn_Faturalar.Location = new System.Drawing.Point(2, 121);
            this.btn_Faturalar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Faturalar.Name = "btn_Faturalar";
            this.btn_Faturalar.Size = new System.Drawing.Size(174, 53);
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
            this.btn_Banka_Hareketleri.Location = new System.Drawing.Point(2, 64);
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
            this.btn_Bankalar.Location = new System.Drawing.Point(2, 7);
            this.btn_Bankalar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Bankalar.Name = "btn_Bankalar";
            this.btn_Bankalar.Size = new System.Drawing.Size(174, 53);
            this.btn_Bankalar.TabIndex = 0;
            this.btn_Bankalar.Text = "Bankalar";
            this.btn_Bankalar.UseVisualStyleBackColor = false;
            this.btn_Bankalar.Click += new System.EventHandler(this.btn_Bankalar_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Navy;
            this.chart1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(185, 293);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Bankalar";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(390, 236);
            this.chart1.TabIndex = 21;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.Navy;
            this.chart2.BackSecondaryColor = System.Drawing.Color.White;
            chartArea6.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart2.Legends.Add(legend6);
            this.chart2.Location = new System.Drawing.Point(581, 293);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series6.Legend = "Legend1";
            series6.Name = "Faturalar";
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(415, 236);
            this.chart2.TabIndex = 22;
            this.chart2.Text = "chart2";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(999, 533);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_Fatura_Bilgi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_Banka_Bilgi;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_Gelen_Son_Havale_Veri;
        private System.Windows.Forms.Label lbl_Gelen_Son_Havale;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Toplam_Bakiye_Veri;
        private System.Windows.Forms.Label lbl_Toplam_Bakiye;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_Fatura_Basligi_Veri;
        private System.Windows.Forms.Label lbl_Fatura_Basligi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_Dashboard_Formu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cikis_Yap;
        private System.Windows.Forms.Button btn_Ayarlar;
        private System.Windows.Forms.Button btn_Giderler;
        private System.Windows.Forms.Button btn_Faturalar;
        private System.Windows.Forms.Button btn_Banka_Hareketleri;
        private System.Windows.Forms.Button btn_Bankalar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Timer timer1;
    }
}
using Finansal_CRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finansal_CRM
{
    public partial class FrmSpendings : Form
    {
        private int mevcutYil;
        private int mevcutAy;
        private DateTime baslangicTarihi;
        private DateTime bitis_Tarihi;

        public FrmSpendings()
        {
            InitializeComponent();
            InitializeDates();
        }

        private void InitializeDates()
        {
            mevcutYil = DateTime.Now.Year;
            mevcutAy = DateTime.Now.Month;

            baslangicTarihi = new DateTime(mevcutYil, mevcutAy, 1);
            bitis_Tarihi = baslangicTarihi.AddMonths(1).AddDays(-1);
        }

        Finansal_CRMEntities db = new Finansal_CRMEntities();

        void HarcamaListesi()
        {
            var values = db.Spendings
                .Select(s => new
                {
                    ID = s.SpendingId,
                    Başlık = s.SpendingTitle,
                    Miktar = s.SpendingAmount,
                    Tarih = s.SpendingDate,
                    Kategori = s.Categories.CategoryName,
                })
                .ToList();
            dataGridView1.DataSource = values;
        }

        void bakiyeGuncelle()
        {
            var toplamBakiye = db.Spendings
                .Where(x => x.SpendingDate >= baslangicTarihi && x.SpendingDate <= bitis_Tarihi)
                .Sum(x => x.SpendingAmount);

            if (toplamBakiye > 0)
            {
                lbl_Toplam_Gider_Veri.Text = toplamBakiye.ToString() + " ₺";
            }
            else
            {
                lbl_Toplam_Gider_Veri.Text = "Veri bulunamadı";
            }
        }


        void enYuksekHarcama()
            {
                var enYuksekHarcama = db.Spendings
                    .Where(x => x.SpendingDate >= baslangicTarihi && x.SpendingDate <= bitis_Tarihi)
                    .OrderByDescending(x => x.SpendingAmount)
                    .FirstOrDefault();

                if (enYuksekHarcama != null)
                {
                    lbl_En_Yuksek_Harcama_Veri.Text = enYuksekHarcama.SpendingAmount.ToString() + " ₺";
                    lblHighestSpendDesc.Text = enYuksekHarcama.SpendingTitle;
                }
                else
                {
                    lbl_En_Yuksek_Harcama_Veri.Text = "Veri bulunamadı";
                    lblHighestSpendDesc.Text = "Veri bulunamadı";
                }
            }

        void sonHarcamaTutari()
        {
            var sonHarcamaTutari = db.Spendings
                .OrderByDescending(x => x.SpendingId)
                .Take(1)
                .Select(y => new { y.SpendingAmount, y.SpendingTitle })
                .FirstOrDefault();

            if (sonHarcamaTutari != null)
            {
                lbl_Son_Harcama_Veri.Text = sonHarcamaTutari.SpendingAmount.ToString() + " ₺";
                lblLastSpendDesc.Text = sonHarcamaTutari.SpendingTitle;
            }
            else
            {
                lbl_Son_Harcama_Veri.Text = "Veri bulunamadı";
                lblLastSpendDesc.Text = "Veri bulunamadı";
            }
        }


        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            enYuksekHarcama();
            sonHarcamaTutari();
            bakiyeGuncelle();
            HarcamaListesi();

            var categoryName = db.Categories
               .Select(c => new { c.CategoryId, c.CategoryName }).ToList();
            cmb_Kategori.DataSource = categoryName;
            cmb_Kategori.DisplayMember = "CategoryName";
            cmb_Kategori.ValueMember = "CategoryId";
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            enYuksekHarcama();
            sonHarcamaTutari();
            bakiyeGuncelle();
            HarcamaListesi();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            string aciklama = txt_Aciklama.Text;
            decimal miktar = decimal.Parse(txt_Miktar.Text);
            DateTime tarih = DateTime.Now;
            int kategoriAdi = int.Parse(cmb_Kategori.SelectedValue.ToString());

            Spendings s = new Spendings();
            s.SpendingTitle = aciklama;
            s.SpendingAmount = miktar;
            s.SpendingDate = tarih;
            s.CategoryId = kategoriAdi;
            db.Spendings.Add(s);
            db.SaveChanges();
            MessageBox.Show("Gider başarılı bir şekilde sisteme eklendi");

            enYuksekHarcama();
            sonHarcamaTutari();
            bakiyeGuncelle();
            HarcamaListesi();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_Gider_Id.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();

            MessageBox.Show("Gider başarılı bir şekilde sistemden silindi");

            enYuksekHarcama();
            sonHarcamaTutari();
            bakiyeGuncelle();
            HarcamaListesi();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            string aciklama = txt_Aciklama.Text;
            decimal miktar = decimal.Parse(txt_Miktar.Text);
            DateTime tarih = DateTime.Now;
            int kategoriAdi = int.Parse(cmb_Kategori.SelectedValue.ToString());
            int id = int.Parse(txt_Gider_Id.Text);

            var updatedValue = db.Spendings.Find(id);
            updatedValue.SpendingTitle = aciklama;
            updatedValue.SpendingAmount = miktar;
            updatedValue.SpendingDate = tarih;
            updatedValue.CategoryId = kategoriAdi;
            db.SaveChanges();

            MessageBox.Show("Gider başarılı bir şekilde sistemde güncellendi");

            enYuksekHarcama();
            sonHarcamaTutari();
            bakiyeGuncelle();
            HarcamaListesi();
        }

        private void btn_Bankalar_Click(object sender, EventArgs e)
        {
            FrmBanks bankalar = new FrmBanks();
            bankalar.Show();
            this.Close();
        }
        private void btn_Banka_Hareketleri_Click(object sender, EventArgs e)
        {
            FrmBankProcesses bankaHareketleri = new FrmBankProcesses();
            bankaHareketleri.Show();
            this.Close();
        }

        private void btn_Faturalar_Click(object sender, EventArgs e)
        {
            FrmBilling faturalar = new FrmBilling();
            faturalar.Show();
            this.Close();
        }

        private void btn_Giderler_Click(object sender, EventArgs e)
        {
            FrmSpendings giderler = new FrmSpendings();
            giderler.Show();
            this.Close();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard kontrolPaneli = new FrmDashboard();
            kontrolPaneli.Show();
            this.Close();
        }

        private void btn_Ayarlar_Click(object sender, EventArgs e)
        {
            FrmSettings ayarlar = new FrmSettings();
            ayarlar.Show();
            this.Close();
        }

        private void btn_Cikis_Yap_Click(object sender, EventArgs e)
        {
            FrmLogin anaSayfa = new FrmLogin();
            anaSayfa.Show();
            this.Close();
        }
    }
}

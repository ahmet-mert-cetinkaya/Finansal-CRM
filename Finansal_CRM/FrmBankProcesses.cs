using Finansal_CRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finansal_CRM
{
    public partial class FrmBankProcesses : Form
    {
        private int mevcutYil;
        private int mevcutAy;
        private DateTime baslangicTarihi;
        private DateTime bitis_Tarihi;


        public FrmBankProcesses()
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
            var values = db.BankProcesses
                .Select(bp => new
                {
                    ID = bp.BankProcessId,
                    Açıklama = bp.Description,
                    Tarih = bp.ProcessDate,
                    İşlemTürü = bp.ProcessType,
                    Miktar = bp.Amount,
                    Banka = bp.Banks.BankTitle,
                }).ToList();

            dataGridView1.DataSource = values;
        }

        void bakiyeGuncelle()
        {
            var bakiyeGuncelle = db.BankProcesses
                .Where(x => x.ProcessDate >= baslangicTarihi && x.ProcessDate <= bitis_Tarihi)
                .Sum(x => x.Amount);

            if (bakiyeGuncelle != 0)
            {
                lbl_Toplam_Bakiye_Veri.Text = bakiyeGuncelle.ToString() + " ₺";
            }
            else
            {
                lbl_Toplam_Bakiye_Veri.Text = "Veri bulunamadı";
            }
        }


        void enYuksekHarcama()
        {
            var enyuksekHarcama = db.BankProcesses
                .Where(x => x.ProcessDate >= baslangicTarihi && x.ProcessDate <= bitis_Tarihi)
                .OrderByDescending(x => x.Amount)
                .FirstOrDefault();

            if (enyuksekHarcama != null)
            {
                lbl_En_Yuksek_Gelir_Veri.Text = enyuksekHarcama.Amount.ToString() + " ₺";
                lbl_En_Yuksek_Gelir_Aciklama.Text = enyuksekHarcama.Description;
            }
            else
            {
                lbl_En_Yuksek_Gelir_Veri.Text = "Veri bulunamadı";
                lbl_En_Yuksek_Gelir_Aciklama.Text = "Veri bulunamadı";
            }
        }


        void sonHarcamaTutari()
        {
            var sonHarcamaTutari = db.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Take(1)
                .Select(y => new { y.Amount, y.Description })
                .FirstOrDefault();

            if (sonHarcamaTutari != null)
            {
                lbl_Gelen_Son_Havale_Veri.Text = sonHarcamaTutari.Amount.ToString() + " ₺";
                lbl_Son_Gelir.Text = sonHarcamaTutari.Description;
            }
            else
            {
                lbl_Gelen_Son_Havale_Veri.Text = "Veri bulunamadı";
                lbl_Son_Gelir.Text = "Veri bulunamadı";
            }
        }


        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            enYuksekHarcama();
            sonHarcamaTutari();
            bakiyeGuncelle();
            HarcamaListesi();


            var bankaIsimleri = db.Banks
                .Select(b => new { b.BankId, b.BankTitle }).ToList();
            cmb_Banka.DataSource = bankaIsimleri;
            cmb_Banka.DisplayMember = "BankTitle";
            cmb_Banka.ValueMember = "BankId";

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
            DateTime tarih = DateTime.Now;
            int bankaIsimleri = int.Parse(cmb_Banka.SelectedValue.ToString());
            string tip = txt_Islem_Turu.Text;
            decimal miktar = decimal.Parse(txt_Miktar.Text);

            BankProcesses bp = new BankProcesses();
            bp.Description = aciklama;
            bp.ProcessDate = tarih;
            bp.BankId = bankaIsimleri;
            bp.ProcessType = tip;
            bp.Amount = miktar;
            db.BankProcesses.Add(bp);
            db.SaveChanges();
            MessageBox.Show("İşlem başarılı bir şekilde sisteme eklendi");

            enYuksekHarcama();
            sonHarcamaTutari();
            bakiyeGuncelle();
            HarcamaListesi();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_Islem_Id.Text);
            var silinenDeger = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(silinenDeger);
            db.SaveChanges();

            MessageBox.Show("İşlem başarılı bir şekilde sistemden silindi");

            enYuksekHarcama();
            sonHarcamaTutari();
            bakiyeGuncelle();
            HarcamaListesi();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            string aciklama = txt_Aciklama.Text;
            DateTime tarih = DateTime.Now;
            int bankaIsimleri = int.Parse(cmb_Banka.SelectedValue.ToString());
            string tip = txt_Islem_Turu.Text;
            decimal miktar = decimal.Parse(txt_Miktar.Text);
            int id = int.Parse(txt_Islem_Id.Text);

            var guncellenenDeger = db.BankProcesses.Find(id);
            guncellenenDeger.Description = aciklama;
            guncellenenDeger.ProcessDate = tarih;
            guncellenenDeger.BankId = bankaIsimleri;
            guncellenenDeger.ProcessType = tip;
            guncellenenDeger.Amount = miktar;
            db.SaveChanges();

            MessageBox.Show("Ödeme başarılı bir şekilde sistemde güncellendi.", "Banka Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

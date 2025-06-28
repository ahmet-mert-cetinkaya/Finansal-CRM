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
        public partial class FrmBilling : Form
        {
            public FrmBilling()
            {
                InitializeComponent();
            }

        Finansal_CRMEntities db = new Finansal_CRMEntities();
            private void FrmBilling_Load(object sender, EventArgs e)
            {
                var values = db.Bills.ToList();
                dataGridView1.DataSource = values;
            }

            private void btn_Odeme_Listesi_Click(object sender, EventArgs e)
            {
                var values = db.Bills.ToList();
                dataGridView1.DataSource = values;
            }

            private void btn_Yeni_Odeme_Click(object sender, EventArgs e)
            {
                string baslik = txt_Baslik.Text;
                decimal miktar = decimal.Parse(txt_Miktar.Text);
                string periyod = txt_Period.Text;

                Bills bills = new Bills();
                bills.BillTitle = baslik;
                bills.BillAmount = miktar;
                bills.BillPeriod = periyod;
                db.Bills.Add(bills);
                db.SaveChanges();

                MessageBox.Show("Ödeme başarılı bir şekilde sisteme eklendi");

                var values = db.Bills.ToList();
                dataGridView1.DataSource = values;
            }

            private void btn_Odeme_Sil_Click(object sender, EventArgs e)
            {
                int id = int.Parse(txt_Odeme_Id.Text);
                var degerSil = db.Bills.Find(id);
                db.Bills.Remove(degerSil);
                db.SaveChanges();
                MessageBox.Show("Ödeme başarılı bir şekilde sistemden silindi");

                var values = db.Bills.ToList();
                dataGridView1.DataSource = values;
            }

            private void btn_Odeme_Guncelle_Click(object sender, EventArgs e)
            {
                string baslik = txt_Baslik.Text;
                decimal miktar = decimal.Parse(txt_Miktar.Text);
                string periyod = txt_Period.Text;
                int id = int.Parse(txt_Odeme_Id.Text);

                var guncellenenDeger = db.Bills.Find(id);
                guncellenenDeger.BillTitle = baslik;
                guncellenenDeger.BillAmount = miktar;
                guncellenenDeger.BillPeriod = periyod;
                db.SaveChanges();
                MessageBox.Show("Ödeme başarılı bir şekilde sistemde güncellendi");

                var values = db.Bills.ToList();
                dataGridView1.DataSource = values;
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
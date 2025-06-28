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
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        Finansal_CRMEntities db = new Finansal_CRMEntities();

        private void FrmBanks_Load(object sender, EventArgs e)
        {
            var ziraatBankasiBakiye = db.Banks
                .Where(x => x.BankTitle == "Ziraat Bankası")
                .Select(y => y.BankBalance)
                .FirstOrDefault();
            lbl_Ziraat_Bankasi_Veri.Text = ziraatBankasiBakiye.HasValue ? ziraatBankasiBakiye.Value.ToString() + " ₺" : "Veri bulunamadı";

            var vakifBankasiBakiye = db.Banks
                .Where(x => x.BankTitle == "VakıfBankası")
                .Select(y => y.BankBalance)
                .FirstOrDefault();
            lbl_Vakifbankasi_Veri.Text = vakifBankasiBakiye.HasValue ? vakifBankasiBakiye.Value.ToString() + " ₺" : "Veri bulunamadı";

            var isBankasiBakiye = db.Banks
                .Where(x => x.BankTitle == "İş Bankası")
                .Select(y => y.BankBalance)
                .FirstOrDefault();
            lbl_Is_Bankasi_Veri.Text = isBankasiBakiye.HasValue ? isBankasiBakiye.Value.ToString() + " ₺" : "Veri bulunamadı";

            var banka_Islemi_1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            if (banka_Islemi_1 != null)
            {
                lbl_Banka_Islemi_1.Text = banka_Islemi_1.Description + " | " + banka_Islemi_1.Amount + " ₺ | " + banka_Islemi_1.ProcessDate;
            }
            else
            {
                lbl_Banka_Islemi_1.Text = "Veri bulunamadı";
            }

            var banka_Islemi_2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            if (banka_Islemi_2 != null)
            {
                lbl_Banka_Islemi_2.Text = banka_Islemi_2.Description + " | " + banka_Islemi_2.Amount + " ₺ | " + banka_Islemi_2.ProcessDate;
            }
            else
            {
                lbl_Banka_Islemi_2.Text = "Veri bulunamadı";
            }

            var banka_Islemi_3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            if (banka_Islemi_3 != null)
            {
                lbl_Banka_Islemi_3.Text = banka_Islemi_3.Description + " | " + banka_Islemi_3.Amount + " ₺ | " + banka_Islemi_3.ProcessDate;
            }
            else
            {
                lbl_Banka_Islemi_3.Text = "Veri bulunamadı";
            }

            var banka_Islemi_4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            if (banka_Islemi_4 != null)
            {
                lbl_Banka_Islemi_4.Text = banka_Islemi_4.Description + " | " + banka_Islemi_4.Amount + " ₺ | " + banka_Islemi_4.ProcessDate;
            }
            else
            {
                lbl_Banka_Islemi_4.Text = "Veri bulunamadı";
            }

            var banka_Islemi_5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            if (banka_Islemi_5 != null)
            {
                lbl_Banka_Islemi_5.Text = banka_Islemi_5.Description + " | " + banka_Islemi_5.Amount + " ₺ | " + banka_Islemi_5.ProcessDate;
            }
            else
            {
                lbl_Banka_Islemi_5.Text = "Veri bulunamadı";
            }
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

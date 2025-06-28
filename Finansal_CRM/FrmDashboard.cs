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
using System.Windows.Forms.DataVisualization.Charting;

namespace Finansal_CRM
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        Finansal_CRMEntities db = new Finansal_CRMEntities();
        int count = 0;

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lbl_Toplam_Bakiye_Veri.Text = totalBalance.ToString() + " ₺";

            var lastIncomingAmount = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lbl_Gelen_Son_Havale_Veri.Text = lastIncomingAmount.ToString() + " ₺";

            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance,
            }).ToList();

            chart1.Series.Clear();
            var banks = chart1.Series.Add("Bankalar");
            banks.ChartType = SeriesChartType.Column;
            foreach (var item in bankData)
            {
                banks.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();

            chart2.Series.Clear();
            var bills = chart2.Series.Add("Faturalar");
            bills.ChartType = SeriesChartType.Doughnut;
            foreach (var item in billData)
            {
                bills.Points.AddXY(item.BillTitle, item.BillAmount);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count % 4 == 1)
            {
                var electric = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lbl_Fatura_Basligi.Text = "Elektrik Faturası";
                lbl_Fatura_Basligi_Veri.Text = electric.ToString() + " ₺";
            }

            if (count % 4 == 2)
            {
                var gas = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lbl_Fatura_Basligi.Text = "Doğalgaz Faturası";
                lbl_Fatura_Basligi_Veri.Text = gas.ToString() + " ₺";
            }

            if (count % 4 == 3)
            {
                var water = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lbl_Fatura_Basligi.Text = "Su Faturası";
                lbl_Fatura_Basligi_Veri.Text = water.ToString() + " ₺";
            }

            if (count % 4 == 0)
            {
                var internet = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lbl_Fatura_Basligi.Text = "İnternet Faturası";
                lbl_Fatura_Basligi_Veri.Text = internet.ToString() + " ₺";
            }
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

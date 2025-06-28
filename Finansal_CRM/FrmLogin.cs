using Finansal_CRM.Manager;
using Finansal_CRM.Models;
using Finansal_CRM.Services;
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
    public partial class FrmLogin : Form
    {
        private UserService _userService;
        public FrmLogin()
        {
            InitializeComponent();
            _userService = new UserService(new Finansal_CRMEntities()); ;
        }

        private void btn_Giris_Yap_Click(object sender, EventArgs e)
        {
            string userName = txt_Kullanici_Adi.Text;
            string password = txt_Sifre.Text;

            if (_userService.ValidateUser(userName, password))
            {
                UserManager.userLoggedIn = true;
                UserManager.Username = userName;

                FrmDashboard dashboardPage = new FrmDashboard();
                dashboardPage.Show();
                this.Hide();

                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }
        }
    }
}

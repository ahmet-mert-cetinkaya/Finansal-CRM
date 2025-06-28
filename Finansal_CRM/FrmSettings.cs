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
using System.Xml.Linq;

namespace Finansal_CRM
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        Finansal_CRMEntities db = new Finansal_CRMEntities();

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            int id = 1;
            var user = db.Users.FirstOrDefault(u=>u.UserId == id);

            if (user != null)
            {
                txt_Kullanici_Adi.Text = user.UserName;
                txt_Sifre.Text = user.Password;
            }
        }
        private void btn_Bilgileri_Guncelle_Click(object sender, EventArgs e)
        {
            int id = 1;
            string username = txt_Kullanici_Adi.Text;
            string password = txt_Sifre.Text;

            var updatedUser = db.Users.Find(id);

            updatedUser.UserName = username;
            updatedUser.Password = password;

            db.SaveChanges();
            MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.", "Kullanıcı Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

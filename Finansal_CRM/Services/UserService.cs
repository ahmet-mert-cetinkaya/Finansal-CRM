using Finansal_CRM.Manager;
using Finansal_CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finansal_CRM.Services
{
    public class UserService
    {
        private readonly Finansal_CRMEntities _db;

        public UserService(Finansal_CRMEntities db)
        {
            _db = db;
        }

        public bool ValidateUser(string userName, string password)
        {
            var user = _db.Users.FirstOrDefault(u => u.UserName == userName && u.Password == password);

            if (user != null)
            {
                UserManager.Username = userName;
                UserManager.userLoggedIn = true;
                return true;
            }
            return false;
        }
    }

}

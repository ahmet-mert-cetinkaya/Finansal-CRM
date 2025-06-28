using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finansal_CRM.Manager
{
    public class UserManager
    {
        public static bool userLoggedIn { get; set; } = false;
        public static string Username { get; set; }
    }
}

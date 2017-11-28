using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCalendar.Model
{
    public class Admin
    {
        string Login;
        string HashedPassword;
        string TempPassword;

        public Admin(string login, string pass)
        {
            HashedPassword = Tools.HashPassword(pass);
            Login = login;
        }
        public Admin()
        {
            HashedPassword = Tools.HashPassword(TempPassword);
        }
    }
}

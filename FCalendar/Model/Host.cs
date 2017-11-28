using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCalendar.Model
{
    public class Host
    {
        string CPR;
        string Name;
        string Mail;
        string TempPassword;
        string HashedPassword;
        string AdminNotes;
        bool IsVerified;
        int VerifiedEvent;
        bool IsRecomendet;
        string ShortDescription;
        
        public Host(string cpr, string name, string Mail, string password)
        {
            HashedPassword = Tools.HashPassword(password);
            CPR = cpr;
            Name = name;
        }
        public Host()
        {

            HashedPassword = Tools.HashPassword(TempPassword);
            TempPassword = null;
        }
    }
}

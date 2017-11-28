using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCalendar.Model
{
    class Host
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
        
        public Host(string CPR, string Name, string Mail, string password)
        {

        }
        public Host()
        {
            HashedPassword = TempPassword;
        }
    }
}

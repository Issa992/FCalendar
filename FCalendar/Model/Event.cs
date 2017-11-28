using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCalendar.Model
{
    class Event
    {
        private DataType EventDate;
        private string Adress;
        private string City;
        private string ShortDescription;
        private string LongDescription;
        private string URLFromHost;
        private string Category;
        private bool IsEnd;
        private bool IsLock;
        private bool RequestedDelete;

        public bool CheckIfLocked(DataType date)
        {
            return false;
        }
        public void RequestRemove(Event eventName) { }


    }
}

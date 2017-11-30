using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FCalendar.ViewModel;

namespace FCalendar.Model
{
    class Catalog : NotifyPropertyChange
    {
        private ObservableCollection<Host> HostList;
        private ObservableCollection<Admin> AdminList;
        private ObservableCollection<Event> EventList;
        private ObservableCollection<Host> FiltredHostList;
        private ObservableCollection<Host> FiltredEventList;

        

        public Catalog()
        {
          
          


        }
        
       

        public void FiltrHostByRecommended(){}
        public void FiltrHostByIsVerified(){}
        public void FiltrHostByVerifiedRecommended(){}
        public void FiltrEventByDate(DataType dataType){}
        public void FiltrEventByHost(Host host){}
        public void FiltrEventByLocked(){}
        public void FiltrEventByRequestedDel(){}
        public void FiltrEventFuture(){}
        public void FiltrEventPast(){}
        public void FiltrEventByCity(){}





    }
}

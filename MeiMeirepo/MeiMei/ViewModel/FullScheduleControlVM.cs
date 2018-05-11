using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeiMei.ViewModel.Base;

namespace MeiMei.ViewModel
{
    public class FullScheduleControlVM : BaseVM
    {
        #region Properties

        private string customer;
        public string Customer
        {
            get { return customer; }
            set { customer = value; OnPropertyChanged("Customer"); }
        }

        private string employee;
        public string Employee
        {
            get { return employee; }
            set { employee = value; OnPropertyChanged("Employee");
            }
        }

        private string service;
        public string Service
        {
            get { return service ; }
            set { service = value; OnPropertyChanged("Service");
            }
        }

        private string additional;
        public string Additional
        {
            get { return additional; }
            set { additional = value; OnPropertyChanged("Additional");
            }
        }

        private string price;
        public string Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged("Price");
            }
        }

        #endregion
    }
}

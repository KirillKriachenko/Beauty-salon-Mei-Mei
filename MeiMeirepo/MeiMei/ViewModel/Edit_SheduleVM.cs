using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MeiMei.Model;
using MeiMei.ViewModel.Base;

namespace MeiMei.ViewModel
{
    public class Edit_SheduleVM : BaseVM
    {
        public SheduleControlVM Instance;
        private EmployeeTable employeeTable;
        private Shedule shedule;


        #region Property

        private ObservableCollection<EmployeeTable> employeeCollection;
        public ObservableCollection<EmployeeTable> EmployeeCollection
        {
            get
            {
                if (employeeCollection == null)
                    employeeCollection = new ObservableCollection<EmployeeTable>(DataBaseManager.getAllEmpoyee());
                return employeeCollection;
            }
            set { employeeCollection = value; OnPropertyChanged("EmployeeCollection"); }
        }

        private ObservableCollection<Service> serviceCollection;
        public ObservableCollection<Service> ServiceCollection
        {
            get
            {
                if (serviceCollection == null)
                    serviceCollection = new ObservableCollection<Service>(DataBaseManager.getAddService());//DataBaseManager.getService());//(DataBaseManager.findeService());
                return serviceCollection;
            }
            set
            {
                serviceCollection = value;

                OnPropertyChanged("ServiceCollection");

            }

        }

        private ObservableCollection<TypeOfService> addServiceCollection;
        public ObservableCollection<TypeOfService> AddServiceCollection
        {
            get
            {
                if (addServiceCollection == null)
                    addServiceCollection = new ObservableCollection<TypeOfService>(DataBaseManager.getTypeOfService());
                return addServiceCollection;
            }
            set { addServiceCollection = value; OnPropertyChanged("AddServiceCollection"); }
        }

        private ObservableCollection<Customers> addCustomerCollection;
        public ObservableCollection<Customers> AddCustomerCollection
        {
            get
            {
                if (addCustomerCollection == null)
                    addCustomerCollection = new ObservableCollection<Customers>(DataBaseManager.getAllCustomer());
                return addCustomerCollection;
            }
            set { addCustomerCollection = value; OnPropertyChanged("AddCustomerCollection"); }
        }

        private ObservableCollection<SheduleTime> sheduleTimeCollection;
        public ObservableCollection<SheduleTime> SheduleTimeCollection
        {
            get
            {
                if (sheduleTimeCollection == null)
                    sheduleTimeCollection = new ObservableCollection<SheduleTime>(DataBaseManager.getAllTime());
                sheduleTimeCollection = new ObservableCollection<SheduleTime>(sheduleTimeCollection.OrderBy(id => id.Id));
                return sheduleTimeCollection;
            }
            set { sheduleTimeCollection = value; OnPropertyChanged("SheduleTimeCollection"); }
        }

        private SheduleTime selectedSecondTime;
        public SheduleTime SelectedSecondTime
        {
            get { return selectedSecondTime; }
            set
            {
                selectedSecondTime = value; OnPropertyChanged("SelectedSecondTime");
                SecondTime = SelectedSecondTime.Time;
            }
        }

        private SheduleTime selectedFirstTime;
        public SheduleTime SelectedFirstTime
        {
            get { return selectedFirstTime; }
            set
            {
                selectedFirstTime = value; OnPropertyChanged("SelectedFirstTime");
                FirstTime = SelectedFirstTime.Time;
            }
        }

        private Service selectedThisService;
        public Service SelectedThisService
        {
            get { return selectedThisService; }
            set
            {
                selectedThisService = value; OnPropertyChanged("SelectedThisService");
                if (selectedThisService != null)
                {
                    Price = SelectedThisService.ServicePrice;
                }

            }
        }

        private TypeOfService selectedService;
        public TypeOfService SelectedService
        {
            get { return selectedService; }
            set
            {

                selectedService = value;
                using (var db = new MeiMeiContext())
                {
                    var query = from b in db.TypeOfServices
                                join ba in db.Services on b.Id equals ba.TypeOfServiceId
                                where b.Id == SelectedService.Id && ba.TypeOfServiceId == b.Id
                                select ba;

                    if (selectedService != null)
                    {
                        serviceCollection = new ObservableCollection<Service>(query);
                        OnPropertyChanged("ServiceCollection");
                    }
                    else
                    {
                        serviceCollection = new ObservableCollection<Service>();
                    }


                }

                OnPropertyChanged("SelectedService");
            }
        }

        private Customers selectedItem;
        public Customers SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; OnPropertyChanged("SelectedItem"); }
        }

        private EmployeeTable selectedEmployee;
        public EmployeeTable SelectedEmployee
        {
            get { return selectedEmployee; }
            set { selectedEmployee = value; OnPropertyChanged("SelectedEmployee"); }
        }

        private string clientName;
        public string ClientName
        {
            get { return shedule != null ? shedule.CustomerName : String.Empty; }
            set { shedule.CustomerName = value; OnPropertyChanged("ClientName"); }
        }

        private string employye;
        public string Employye
        {
            get { return employeeTable != null ? employeeTable.FIO : String.Empty; }
            set { employeeTable.FIO = value; OnPropertyChanged("Employye"); }
        }


        private string room;
        public string Room
        {
            get { return shedule != null ? shedule.Room : String.Empty; }
            set
            {
                    shedule.Room = value; 
                OnPropertyChanged("Room");
            }
        }


        private string service;
        public string Service
        {
            get { return shedule != null ? shedule.ServiceName : String.Empty; }
            set { shedule.ServiceName = value; OnPropertyChanged("Service"); }
        }

        private DateTime mydate;
        public DateTime MyDate
        {
            get { return mydate; }
            set
            {
                mydate = value; OnPropertyChanged("MyDate");
            }
        }

        private string firstTime;
        public string FirstTime
        {
            get { return firstTime; }
            set { firstTime = value; OnPropertyChanged("FirstTime"); }
        }

        private string secondTime;
        public string SecondTime
        {
            get { return secondTime; }
            set { secondTime = value; OnPropertyChanged("SecondTime"); }
        }

        private string price;
        public string Price
        {
            get { return shedule != null ? shedule.ServicePrice : String.Empty; }
            set { shedule.ServicePrice = value; OnPropertyChanged("Price"); }
        }

        #endregion

        #region Command

        private DelegateCommand editSheduleCommand;

        public Edit_SheduleVM(EmployeeTable employeeTable1, Shedule shedule1)
        {
            employeeTable = employeeTable1;
            shedule = shedule1;
            MyDate = DateTime.Now.Date;
           
        }

        public DelegateCommand EditSheduleCommand
        {
            get { return editSheduleCommand ?? (editSheduleCommand = new DelegateCommand(EditSheduleCommandClick)); }
        }

        public EmployeeTable EmployeeTable
        {
            get { return employeeTable; }
            set { employeeTable = value; }
        }

        public Shedule Shedule
        {
            get { return shedule; }
            set { shedule = value; }
        }

        public void EditSheduleCommandClick(object obj)
        {

            if (SelectedFirstTime != null && SelectedSecondTime != null)
            {


                using (var db = new MeiMeiContext())
                {
                    var shedules = (from b in db.Shedules
                                    where b.Id == shedule.Id
                                    select b).FirstOrDefault();

                    shedules.CustomerName = ClientName;
                    shedules.Time = SelectedFirstTime.Id.ToString();
                    shedules.Size = SelectedSecondTime.Id.ToString();
                    shedules.ServiceName = Service;
                    shedules.ServicePrice = Price;
                    shedules.Data = MyDate;
                    shedules.EmployeeTable.FIO = Employye;
                    shedules.Room = shedule.Room;
                    db.SaveChanges();

                    var history = (from b in db.Histories
                                   where b.Id == shedules.Id && b.Customer.FIO == shedules.CustomerName
                                   select b).FirstOrDefault();
                    history.ServiceName = Service;
                    history.ServiceCost = Price;
                    db.SaveChanges();
                }

                ScheduleVM.Instance.FindeShedule(ShedulePage.Instance.gridShedule);
            }
            else
            {
                MessageBox.Show(Properties.Resources.FirstFill_message, "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
          

           
        }

        #endregion


    }
}

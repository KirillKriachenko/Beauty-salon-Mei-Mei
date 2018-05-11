using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using MeiMei.Model;
using MeiMei.ViewModel.Base;
using System.Windows;

namespace MeiMei.ViewModel
{
    public class Add_ScheduleVM : BaseVM
    {
        public SheduleControlVM _shedule;
        public static Add_ScheduleVM Instance;


        public Add_ScheduleVM()
        {
            Instance = this;
            MyDate = DateTime.Now;
        }

        #region Properties

        private EmployeeTable selectedEmployee;
        public EmployeeTable SelectedEmployee
        {
            get { return selectedEmployee; }
            set { selectedEmployee = value; OnPropertyChanged("SelectedEmployee"); }
        }

        private Customers selectedItem;
        public Customers SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; OnPropertyChanged("SelectedItem"); }
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

        private Service selectedThisService;
        public Service SelectedThisService
        {
            get { return selectedThisService; }
            set { selectedThisService = value; OnPropertyChanged("SelectedThisService");
                if (selectedThisService != null)
                {
                    Price = SelectedThisService.ServicePrice;
                }
            
            }
        }

        private SheduleTime selectedFirstTime;
        public SheduleTime SelectedFirstTime
        {
            get { return selectedFirstTime; }
            set { selectedFirstTime = value; OnPropertyChanged("SelectedFirstTime");
                FirstTime = SelectedFirstTime.Time;
            }
        }

        private SheduleTime selectedSecondTime;
        public SheduleTime SelectedSecondTime
        {
            get { return selectedSecondTime; }
            set { selectedSecondTime = value; OnPropertyChanged("SelectedSecondTime");
                SecondTime = SelectedSecondTime.Time;
            }
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

        private ObservableCollection<Customers> addCustomerCollection;
        public ObservableCollection<Customers> AddCustomerCollection
        {
            get
            {
                if(addCustomerCollection == null)
                    addCustomerCollection = new ObservableCollection<Customers>(DataBaseManager.getAllCustomer());
                return addCustomerCollection;
            }
            set { addCustomerCollection = value; OnPropertyChanged("AddCustomerCollection"); }
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


        private string room;
        public string Room
        {
            get { return room; }
            set { room = value; OnPropertyChanged("Room"); }
        }

        private string time;
        public string Time
        {
            get { return time; }
            set { time = value;
                OnPropertyChanged("Time");
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

        private string customer;
        public string Customer
        {
            get { return customer; }
            set { customer = value;
                OnPropertyChanged("Customers");
            }
        }
        private string service;
        public string Service
        {
            get { return service; }
            set
            {
                service = value;
                OnPropertyChanged("Service");
            }
        }

        private string price;
        public string Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged("Price"); }
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

        #endregion

        #region Command

        private DelegateCommand addSheduleCommand;

        public Add_ScheduleVM(SheduleControlVM sheduleControlVm)
        {
            _shedule = sheduleControlVm;
            MyDate = DateTime.Now;
        }

        public DelegateCommand AddSheduleCommand
        {
            get { return addSheduleCommand ?? (addSheduleCommand = new DelegateCommand(AddShedule)); }
        }

        public void AddShedule(object obj)
        {

            int size, firstNum, secondNum;

            size = SelectedSecondTime.Id - SelectedFirstTime.Id + 1;
            firstNum = SelectedFirstTime.Id;

            if (SelectedEmployee != null && SelectedFirstTime != null && 
                SelectedSecondTime != null && SelectedThisService != null && SelectedService != null)
            {
                if (SelectedItem == null)
                {
                    using (var db = new MeiMeiContext())
                    {
                        var customer = new Customers
                            {
                                FIO = Customer
                            };
                        db.Customers.Add(customer);
                        db.SaveChanges();
                    }

                    using (var db = new MeiMeiContext())
                    {
                        var shedule = new Shedule
                            {
                                CustomerName = Customer,
                                ServicePrice = SelectedThisService.ServicePrice,
                                ServiceName = SelectedThisService.ServiceName,
                                Data = MyDate.Date,
                                EmployeeTableId = SelectedEmployee.Id,
                                Time = firstNum.ToString(),
                                Size = size.ToString(),
                                Room = Room,
                                Column = (_shedule.ColumnNumber + 1).ToString()
                            };


                        var history = new History
                            {
                                CustomersId = (from b in db.Customers
                                               where b.FIO == Customer
                                               select b.Id).FirstOrDefault(),
                                Data = MyDate.Date.ToString(),
                                ServiceName = SelectedThisService.ServiceName,
                                ServiceCost = SelectedThisService.ServicePrice + " грн."
                            };

                        var employeeHistory = new EmployeeHistory
                        {
                            Cost = SelectedThisService.ServicePrice,
                            Data = MyDate.Date,
                            EmployeeTableId = SelectedEmployee.Id,
                            ServiceName = SelectedThisService.ServiceName
                        };
                        db.Shedules.Add(shedule);
                        db.SaveChanges();

                        db.Histories.Add(history);
                        db.SaveChanges();

                        db.EmployeeHistories.Add(employeeHistory);
                        db.SaveChanges();
                    }


                }
                else if(SelectedItem != null)
                {
                    using (var db = new MeiMeiContext())
                    {
                        var shedule = new Shedule
                            {
                                CustomerName = SelectedItem.FIO,
                                ServicePrice = SelectedThisService.ServicePrice,
                                ServiceName = SelectedThisService.ServiceName,
                                Data = MyDate.Date,
                                EmployeeTableId = SelectedEmployee.Id,
                                Time = firstNum.ToString(),
                                Size = size.ToString(),
                                Room = Room,
                                Column = (_shedule.ColumnNumber + 1).ToString()
                            };


                        var history = new History
                            {
                                CustomersId = SelectedItem.Id,
                                Data = MyDate.Date.ToString(),
                                ServiceName = SelectedThisService.ServiceName,
                                ServiceCost = SelectedThisService.ServicePrice + " грн."
                            };


                        var employeeHistory = new EmployeeHistory
                            {
                                Cost = SelectedThisService.ServicePrice,
                                Data = MyDate.Date,
                                EmployeeTableId = SelectedEmployee.Id,
                                ServiceName = SelectedThisService.ServiceName
                            };

                        db.Shedules.Add(shedule);
                        db.SaveChanges();

                        db.Histories.Add(history);
                        db.SaveChanges();

                        db.EmployeeHistories.Add(employeeHistory);
                        db.SaveChanges();
                    }
                }
                MessageBox.Show(Properties.Resources.Сompleted_message, "", MessageBoxButton.OK,
                                MessageBoxImage.Information);


                ScheduleVM.Instance.FindeShedule(ShedulePage.Instance.gridShedule);
            }
            else
            {
                MessageBox.Show(Properties.Resources.FirstFill_message,"",MessageBoxButton.OK,MessageBoxImage.Information);
            }

        }

        #endregion
    }
}

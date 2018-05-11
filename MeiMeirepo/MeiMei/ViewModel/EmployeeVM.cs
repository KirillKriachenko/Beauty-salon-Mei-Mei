using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using MeiMei.Model;
using MeiMei.View;
using MeiMei.ViewModel.Base;

namespace MeiMei.ViewModel
{
    public class EmployeeVM : BaseVM
    {
        public static EmployeeVM Instance;
        public EmployeeVM()
        {
            Instance = this;
            Today = DateTime.Now.Date;
        }
        #region Property

        private string saleryToday;
        public string SaleryToday
        {
            get { return saleryToday; }
            set
            {
                saleryToday = value;
                OnPropertyChanged("SaleryToday");
            }
        }

        private DateTime today;
        public DateTime Today
        {
            get { return today; }
            set { today = value; OnPropertyChanged("Today"); }
        }

        private string fio;
        public string FIO
        {
            get { return fio; }
            set { fio = value; OnPropertyChanged("FIO"); }
        }
        private string bierthday;
        public string Bierthday
        {
            get { return bierthday; }
            set { bierthday = value; OnPropertyChanged("Bierthday"); }
        }
        private string post;
        public string Post
        {
            get { return post; }
            set { post = value; OnPropertyChanged("Post"); }
        }

        public string salary;
        public string Salary
        {
            get { return salary; }
            set { salary = value; OnPropertyChanged("Salary"); }
        }
        public string telephone;
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; OnPropertyChanged("Telephone"); }
        }
        public string emaile;
        public string Emaile
        {
            get { return emaile; }
            set { emaile = value; OnPropertyChanged("Emaile"); }
        }
        public string perosnalData;
        public string PerosnalData
        {
            get { return perosnalData; }
            set { perosnalData = value; OnPropertyChanged("PerosnalData"); }
        }

        public DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; OnPropertyChanged("Data"); }
        }

        public string cost;
        public string Cost
        {
            get { return cost; }
            set { cost = value; OnPropertyChanged("Cost"); }
        }

        public string serviceName;
        public string ServiceName
        {
            get { return serviceName; }
            set { serviceName = value; OnPropertyChanged("ServiceName"); }
        }

        private BitmapImage employeePhoto;
        public BitmapImage EmployeePhoto
        {
            get { return employeePhoto; }
            set { employeePhoto = value; OnPropertyChanged("EmployeePhoto"); }
        }

        private static EmployeeTable selectedEmployee;
        public EmployeeTable SelectedEmployee
        {
            get { return selectedEmployee; }
            set
            {

                selectedEmployee = value;
                if(selectedEmployee == null)
                    return;

                SaleryToday = 0.ToString();

                FIO = SelectedEmployee.FIO;
                PerosnalData = SelectedEmployee.PersonalData;
                Bierthday = SelectedEmployee.Birthday;
                Salary = SelectedEmployee.Salary;
                Telephone = SelectedEmployee.Contacts;
                Post = SelectedEmployee.Post;
                EmployeePhoto = LoadImage(SelectedEmployee.Photo);

                for (int i = 0; i < EmployeeHistoriesCollection.Count; i++)
                {
                    int price;
                    bool isInt = Int32.TryParse(EmployeeHistoriesCollection[i].Cost, out price);

                    int salary = Convert.ToInt32(SaleryToday) + price;
                    SaleryToday = salary.ToString();
                }

                OnPropertyChanged("SelectedEmployee");
                OnPropertyChanged("EmployeeHistoriesCollection");
                OnPropertyChanged("SaleryToday");
            }
        }

        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }

        private ObservableCollection<EmployeeHistory> employeeHistoriesCollection;
        public ObservableCollection<EmployeeHistory> EmployeeHistoriesCollection
        {
            get
            {
                employeeHistoriesCollection = DataBaseManager.getEmployeeHistory();
                return employeeHistoriesCollection;
            }
            set { employeeHistoriesCollection = value; OnPropertyChanged("EmployeeHistoriesCollection"); }
        }

        private ObservableCollection<EmployeeTable> employeeFIOCollection;
        public ObservableCollection<EmployeeTable> EmployeeFIOCollection
        {
            get
            {
                    employeeFIOCollection = DataBaseManager.getAllEmpoyee(); 
                return employeeFIOCollection;
            }
            set { employeeFIOCollection = value; OnPropertyChanged("EmployeeFIOCollection"); }
        }

        private ObservableCollection<EmployeeVM> employeeCollection; 
        public ObservableCollection<EmployeeVM> EmployeeCollection
        {
            get
            {
                    employeeCollection = new ObservableCollection<EmployeeVM>();
                return employeeCollection;

            }
            set { employeeCollection = value; OnPropertyChanged("EmployeeCollection"); }
        }

        #endregion

        #region Command

        private DelegateCommand editEmployeeCommand;
        public DelegateCommand EditEmployeeCommand
        {
            get { return editEmployeeCommand ?? (editEmployeeCommand = new DelegateCommand(EditEmployeeOpen)); }
        }

        public void EditEmployeeOpen(object obj)
        {
            if (SelectedEmployee != null)
            {
                Edit_Employee editEmployee = new Edit_Employee(this);
                editEmployee.ShowDialog();
            }
            else
            {
                MessageBox.Show(Properties.Resources.FirstSelectObject_message,Properties.Resources.Attention_message, MessageBoxButton.OK,MessageBoxImage.Information);
            }
        }

        private DelegateCommand addEmployeeCommand;
        public  DelegateCommand AddEmployeeCommand
        {
            get { return addEmployeeCommand ?? (addEmployeeCommand = new DelegateCommand(EmployeeOpen)); }

        }
        public void EmployeeOpen(object obj)
        {
            Add_Employee addEmployee= new Add_Employee(this);
            addEmployee.ShowDialog();
            OnPropertyChanged("EmployeeFIOCollection");
        }

        private DelegateCommand removeEmployeeCommand;
        public DelegateCommand RemoveEmployeeCommand
        {
            get { return removeEmployeeCommand ?? (removeEmployeeCommand = new DelegateCommand(RemoveCommand)); }
        }

        public void RemoveCommand(object obj)
        {
            if (SelectedEmployee != null)
            {
                using (var db = new MeiMeiContext())
                {
                    while (db.EmployeeHistories.Count() != null)
                    {
                        var history = (from b in db.EmployeeHistories
                                       join ba in db.EmployeeTables on b.EmployeeTableId equals ba.Id
                                       where b.EmployeeTableId == SelectedEmployee.Id
                                       select b).FirstOrDefault();
                        if (history != null)
                        {
                            db.EmployeeHistories.Remove(history);
                            db.SaveChanges();
                        }
                        else
                        {
                            break;
                            
                        }
                        
                    }

                    while (db.Shedules.Count() != null)
                    {
                        var shedule = (from b in db.Shedules
                                       join ba in db.EmployeeTables on b.EmployeeTableId equals ba.Id
                                       where b.EmployeeTableId == SelectedEmployee.Id
                                       select b).FirstOrDefault();
                        if (shedule != null)
                        {
                            db.Shedules.Remove(shedule);
                            db.SaveChanges();
                        }
                        else
                        {
                            break;
                        }
                    }
                    var employee = (from b in db.EmployeeTables
                                    where b.FIO == SelectedEmployee.FIO && b.Id == SelectedEmployee.Id
                                    select b).FirstOrDefault();
                    db.EmployeeTables.Remove(employee);
                    db.SaveChanges();
                    OnPropertyChanged("EmployeeFIOCollection");
                }
               
            }
            else
            {
                MessageBox.Show(Properties.Resources.FirstSelectObject_message, "", MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
        }

        #endregion

    }
}

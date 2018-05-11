using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using MeiMei.Model;
using MeiMei.View;
using MeiMei.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeiMei.ViewModel
{
    public class CustomerVM : BaseVM
    {
        public static CustomerVM Instance;

        public CustomerVM()
        {
            Instance = this;
        }

        #region Propertis

        private string fio;

        public string FIO
        {
            get { return fio; }
            set
            {
                fio = value;
                OnPropertyChanged("FIO");
            }
        }

        private string birthday;

        public string Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                OnPropertyChanged("Birthday");
            }
        }

        private string contakts;

        public string Contakts
        {
            get { return contakts; }
            set
            {
                contakts = value;
                OnPropertyChanged("Contakts");
            }
        }

        private string note;

        public string Note
        {
            get { return note; }
            set
            {
                note = value;
                OnPropertyChanged("Note");
            }
        }

        private BitmapImage customerPhoto;

        public BitmapImage CustomerPhoto
        {
            get { return customerPhoto; }
            set
            {
                customerPhoto = value;
                OnPropertyChanged("CustomerPhoto");
            }
        }

        private static Customers selectedCustomer;

        public Customers SelectedCustomer
        {
            get { return selectedCustomer; }
            set
            {
                selectedCustomer = value;
                if (selectedCustomer == null)
                {
                    return;
                }
                FIO = SelectedCustomer.FIO;
                Contakts = SelectedCustomer.Contakts;
                Birthday = SelectedCustomer.Birthday;
                Note = SelectedCustomer.Notes;
                CustomerPhoto = LoadImage(SelectedCustomer.Photo);


                OnPropertyChanged("SelectedCustomer");
                OnPropertyChanged("CustomerHistory");
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


        private ObservableCollection<Customers> customersColl;

        public ObservableCollection<Customers> CustomersColl
        {
            get
            {
                customersColl = DataBaseManager.getAllCustomer();
                return customersColl;
            }
            set
            {
                customersColl = value;
                OnPropertyChanged("CustomersColl");
            }

        }

        private ObservableCollection<History> customerHistory;

        public ObservableCollection<History> CustomerHistory
        {
            get
            {
                customerHistory = DataBaseManager.getAllCustomerHistory();
                return customerHistory;
            }
            set
            {
                customerHistory = value;
                OnPropertyChanged("CustomerHistory");
            }
        }


        #endregion

        #region Command

        private DelegateCommand addCustomersCommand;

        public DelegateCommand AddCustomersCommand
        {
            get { return addCustomersCommand ?? (addCustomersCommand = new DelegateCommand(AddCustomersClick)); }
        }

        public void AddCustomersClick(object obj)
        {
            Add_Customers addCustomers = new Add_Customers(this);
            addCustomers.ShowDialog();
            OnPropertyChanged("CustomersColl");
        }

        private DelegateCommand removeCustomerCommand;

        public DelegateCommand RemoveCustomerCommand
        {
            get { return removeCustomerCommand ?? (removeCustomerCommand = new DelegateCommand(RemoveCustomerClick)); }
        }

        public void RemoveCustomerClick(object obj)
        {
            if (SelectedCustomer != null)
            {
                using (var db = new MeiMeiContext())
                {

                    while (db.Histories.Count() != null)
                    {
                        var history = (from b in db.Histories
                                       join ba in db.Customers on b.CustomersId equals ba.Id
                                       where b.CustomersId == SelectedCustomer.Id
                                       select b).FirstOrDefault();
                        if (history != null)
                        {
                            db.Histories.Remove(history);
                            db.SaveChanges();
                        }
                        else
                        {
                            break;
                        }
                       
                    }
                    var customer = (from b in db.Customers
                                    where b.FIO == SelectedCustomer.FIO
                                    select b).FirstOrDefault();
                    db.Customers.Remove(customer);
                    db.SaveChanges();
                }
                OnPropertyChanged("CustomersColl");
            }
            else
            {
                MessageBox.Show(Properties.Resources.FirstSelectObject_message, "", MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
        }


        private DelegateCommand editCustomerCommand;

        public DelegateCommand EditCustomerCommand
        {
            get { return editCustomerCommand ?? (editCustomerCommand = new DelegateCommand(EditCustomerClick)); }
        }

        public void EditCustomerClick(object obj)
        {
            if (SelectedCustomer != null)
            {


                Edit_Customer editCustomer = new Edit_Customer(this);
                editCustomer.ShowDialog();
            }
            else
            {
                MessageBox.Show(Properties.Resources.FirstSelectObject_message, "", MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
        }

    #endregion

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
    }
}

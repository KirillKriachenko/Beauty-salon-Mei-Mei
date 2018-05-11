using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Xml.Schema;
using MeiMei.Model;
using MeiMei.ViewModel.Base;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeiMei.ViewModel
{
    public class Add_CustomersVM : BaseVM
    {
        private CustomerVM _customerVMOwner;

        public Add_CustomersVM(CustomerVM customerVm)
        {
            _customerVMOwner = customerVm;
        }

        #region Propertis


        private BitmapImage customerPhoto;
        public BitmapImage CustomerPhoto
        {
            get { return customerPhoto; }
            set { customerPhoto = value; OnPropertyChanged("CustomerPhoto"); }
        }

        private string fio = string.Empty;
        public string FIO
        {
            get { return fio; }
            set 
            {
                fio = value; OnPropertyChanged("FIO");
            }
        }

        private string contacts = string.Empty;
        public string Contacts
        {
            get{return contacts;}
            set
            {
                contacts = value;
                OnPropertyChanged("Contacts");
            }
        }
        private string birthday = string.Empty;
        public string Birthyday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                OnPropertyChanged("Birthday");
            }
        }
        private string notes = string.Empty;
        public string Notes
        {
            get { return notes; }
            set
            {
                notes = value;
                OnPropertyChanged("Notes");
            }
        }
        private ObservableCollection<Add_CustomersVM> addCustomersCollection;
        public ObservableCollection<Add_CustomersVM> AddCustomerCollection
        {
            get
            {
                    addCustomersCollection = new ObservableCollection<Add_CustomersVM>();
                return addCustomersCollection;
            }
            set { addCustomersCollection = value; OnPropertyChanged("AddCustomerCollection"); }
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
           
             //Добавление и запись в бд
            if (FIO != string.Empty || Contacts != string.Empty || Birthyday != string.Empty || Notes != string.Empty)
            {
                using (var db = new MeiMeiContext())
                {
                    var customer = new Customers
                        {
                            FIO = FIO,
                            Birthday = Birthyday,
                            Contakts = Contacts,
                            Notes = Notes,
                            Photo = a

                        };
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }

                MessageBox.Show("Добавленно", "", MessageBoxButton.OK, MessageBoxImage.Information);
                FIO = string.Empty;
                Birthyday = string.Empty;
                Contacts = string.Empty;
                Notes = string.Empty;
                _customerVMOwner.CustomersColl = _customerVMOwner.CustomersColl;
            }
            else
            {
                MessageBox.Show("Пожалуста заполните все строки", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private DelegateCommand addPhotoCommand;
        public DelegateCommand AddPhotoCommand
        {
            get { return addPhotoCommand ?? (addPhotoCommand = new DelegateCommand(AddPhotoClick)); }
        }

        private byte[] a;
        private string selectedFileName;


        public void AddPhotoClick(object obj)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";

            if (openFile.ShowDialog() == true)
            {
                BitmapImage bmi = new BitmapImage();
                selectedFileName = openFile.FileName;
                bmi.BeginInit();
                bmi.CacheOption = BitmapCacheOption.OnLoad;
                bmi.UriSource = new Uri(selectedFileName);
                bmi.EndInit();
                CustomerPhoto = bmi;
                var bytes = File.ReadAllBytes(Path.GetFullPath(selectedFileName));
                a = bytes;

            }

        }

        #endregion

    }
}

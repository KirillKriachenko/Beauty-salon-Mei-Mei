using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using MeiMei.Model;
using MeiMei.ViewModel.Base;
using Microsoft.Win32;

namespace MeiMei.ViewModel
{
    public class Edit_CustomerVM : BaseVM
    {
        private CustomerVM _customerVMOwner;
         public Edit_CustomerVM(CustomerVM customerVm)
        {
            _customerVMOwner = customerVm;
            FIO = CustomerVM.Instance.SelectedCustomer.FIO;
            Contacts = CustomerVM.Instance.SelectedCustomer.Contakts;
            Birthyday = CustomerVM.Instance.SelectedCustomer.Birthday;
            Notes = CustomerVM.Instance.SelectedCustomer.Notes;
            CustomerPhoto = LoadImage(CustomerVM.Instance.SelectedCustomer.Photo);
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

        #region Propertis

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

        private string fio = string.Empty;

        public string FIO
        {
            get { return fio; }
            set
            {
                fio = value;
                OnPropertyChanged("FIO");
            }
        }

        private string contacts = string.Empty;

        public string Contacts
        {
            get { return contacts; }
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

        #endregion


        #region Command

        private DelegateCommand editPhotoCommand;

        public DelegateCommand EditPhotoCommand
        {
            get { return editPhotoCommand ?? (editPhotoCommand = new DelegateCommand(AddPhotoClick)); }
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


        private DelegateCommand saveCommand;
        public DelegateCommand SaveCommand
        {
            get { return saveCommand ?? (saveCommand = new DelegateCommand(SaveClick)); }
        }

        public void SaveClick(object obj)
        {

            if (FIO != string.Empty && Birthyday != string.Empty && Contacts != string.Empty && Notes!= string.Empty)
            {


                using (var db = new MeiMeiContext())
                {
                    var customer = (from b in db.Customers
                                    where b.Id == CustomerVM.Instance.SelectedCustomer.Id
                                    select b).FirstOrDefault();
                    customer.FIO = FIO;
                    customer.Birthday = Birthyday;
                    customer.Contakts = Contacts;
                    customer.Notes = Notes;
                    customer.Photo = a;
                    db.SaveChanges();

                }

                _customerVMOwner.CustomersColl = _customerVMOwner.CustomersColl;
                MessageBox.Show(Properties.Resources.Сompleted_message,"",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show(Properties.Resources.FirstFill_message,Properties.Resources.Attention_message,MessageBoxButton.OK,MessageBoxImage.Information);
            }
        }
        #endregion
    }
}

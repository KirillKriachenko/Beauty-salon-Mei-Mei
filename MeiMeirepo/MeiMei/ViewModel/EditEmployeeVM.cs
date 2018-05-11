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
    class EditEmployeeVM : BaseVM
    {
        private EmployeeVM _employeeVMOwner;

        public EditEmployeeVM(EmployeeVM employeeVm)
        {
            _employeeVMOwner = employeeVm;
            Fio = EmployeeVM.Instance.SelectedEmployee.FIO;
            Birthday = EmployeeVM.Instance.SelectedEmployee.Birthday;
            Post = EmployeeVM.Instance.SelectedEmployee.Post;
            Contacts = EmployeeVM.Instance.SelectedEmployee.Contacts;
            PersonalData = EmployeeVM.Instance.SelectedEmployee.PersonalData;
            Salarity = EmployeeVM.Instance.SelectedEmployee.Salary;
            EmployeePhoto = LoadImage(EmployeeVM.Instance.SelectedEmployee.Photo);
        }
        #region Propertis

        private BitmapImage employeePhoto;
        public BitmapImage EmployeePhoto
        {
            get { return employeePhoto; }
            set { employeePhoto = value; OnPropertyChanged("EmployeePhoto"); }
        }

        private string fio = string.Empty;
        public string Fio
        {
            get { return fio; }
            set { fio = value; OnPropertyChanged("Fio"); }
        }

        private string post = string.Empty;
        public string Post
        {
            get { return post; }
            set { post = value; OnPropertyChanged("Post"); }
        }

        private string birthday = string.Empty;
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; OnPropertyChanged("Birthday"); }
        }

        private string contacts = string.Empty;
        public string Contacts
        {
            get { return contacts; }
            set { contacts = value; OnPropertyChanged("Contacts"); }
        }

        private string personalData = string.Empty;
        public string PersonalData
        {
            get { return personalData; }
            set { personalData = value; OnPropertyChanged("PersonalData"); }
        }

        private string salarity = string.Empty;
        public string Salarity
        {
            get { return salarity; }
            set { salarity = value; OnPropertyChanged("Salarity"); }
        }
        #endregion


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


        #region Commands

        private DelegateCommand editPhotoCommand;
        public DelegateCommand EditPhotoCommand
        {
            get { return editPhotoCommand ?? (editPhotoCommand = new DelegateCommand(TakePhoto)); }
        }

        private byte[] a;
        private string selectedFileName;

        public void TakePhoto(object obj)
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
                EmployeePhoto = bmi;

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

            if (Fio != string.Empty && Birthday != string.Empty && Contacts != string.Empty && Post != string.Empty &&
                Salarity != string.Empty && PersonalData != string.Empty)
            {


                using (var db = new MeiMeiContext())
                {
                    var emploeyy = (from b in db.EmployeeTables
                                    where b.FIO == EmployeeVM.Instance.SelectedEmployee.FIO
                                    select b).FirstOrDefault();
                    emploeyy.FIO = Fio;
                    emploeyy.Birthday = Birthday;
                    emploeyy.Contacts = Contacts;
                    emploeyy.PersonalData = PersonalData;
                    emploeyy.Post = Post;
                    emploeyy.Salary = Salarity;
                    emploeyy.Photo = a;
                    db.SaveChanges();

                }
                _employeeVMOwner.EmployeeFIOCollection = _employeeVMOwner.EmployeeFIOCollection;
                MessageBox.Show(Properties.Resources.Сompleted_message, "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show(Properties.Resources.FirstFill_message, Properties.Resources.Attention_message, MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        #endregion
    }
}

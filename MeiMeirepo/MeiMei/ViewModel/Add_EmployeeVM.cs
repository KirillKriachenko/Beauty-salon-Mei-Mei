using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using MeiMei.Model;
using MeiMei.ViewModel.Base;
using System.Windows;
using Microsoft.Win32;

namespace MeiMei.ViewModel 
{
    public class Add_EmployeeVM : BaseVM
    {

        private EmployeeVM _employeeVMOwner;

        public Add_EmployeeVM(EmployeeVM employeeVm)
        {
            _employeeVMOwner = employeeVm;
        }

        public EmployeeVM _employee;

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
            set { post = value;OnPropertyChanged("Post"); }
        }

        private string birthday = string.Empty;
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value;OnPropertyChanged("Birthday"); }
        }

        private string contacts = string.Empty;
        public string Contacts
        {
            get { return contacts; }
            set { contacts = value;OnPropertyChanged("Contacts"); }
        }

        private string personalData = string.Empty;
        public string PersonalData
        {
            get { return personalData; }
            set { personalData = value;OnPropertyChanged("PersonalData"); }
        }

        private string salarity = string.Empty;
        public string Salarity
        {
            get { return salarity; }
            set { salarity = value;OnPropertyChanged("Salarity"); }
        }

        private ObservableCollection<Add_EmployeeVM> employeeColl;
        public ObservableCollection<Add_EmployeeVM> EmployeeColl
        {
            get
            {
                if (employeeColl==null)
                    employeeColl = new ObservableCollection<Add_EmployeeVM>();
                return employeeColl;
            }
            set { employeeColl = value; OnPropertyChanged("EmployeeColl"); }
        }
        #endregion

        #region Command

        private DelegateCommand addPhotoCommand;
        public DelegateCommand AddPhotoCommand
        {
            get { return addPhotoCommand ?? (addPhotoCommand = new DelegateCommand(TakePhoto)); }
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
            get { return saveCommand ?? (saveCommand = new DelegateCommand(SaveCommandClick)); }
        }

        public void SaveCommandClick(object obj)
        {
            if (Fio != string.Empty || Birthday != string.Empty || Contacts != string.Empty || Post != string.Empty || PersonalData != string.Empty)
            {
                using (var db = new MeiMeiContext())
                {
                    var emploeyy = new EmployeeTable
                    {
                        FIO = Fio,
                        Birthday = Birthday,
                        Contacts = Contacts,
                        Post = Post,
                        Salary = Salarity,
                        PersonalData = PersonalData,
                        Photo = a
                      
                    };
                    db.EmployeeTables.Add(emploeyy);
                    db.SaveChanges();
                }

                MessageBox.Show(Properties.Resources.Сompleted_message, "", MessageBoxButton.OK, MessageBoxImage.Information);
                Fio = string.Empty;
                Birthday = string.Empty;
                Contacts = string.Empty;
                Post = string.Empty;
                PersonalData = string.Empty;
                Salarity = string.Empty;

                _employeeVMOwner.EmployeeFIOCollection = _employeeVMOwner.EmployeeFIOCollection;
            }
            else
            {
                MessageBox.Show(Properties.Resources.FirstFill_message, Properties.Resources.Attention_message, MessageBoxButton.OK, MessageBoxImage.Information);
            }
    }
        #endregion
    }
}

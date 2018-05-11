using System.Data.Entity;
using MeiMei.ViewModel;
using MeiMei.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeiMei.ViewModel
{
    public class MainWindowVM : BaseVM
    {
        private MainWindow _ownerWindow;
        private bool _isSheduleSelected = false;
        private bool _isButtonServisOpenSelected = false;
        private bool _isButtonEmploeeOpenSelected = false;
        private bool _isButtonClientOpenSelected = false;
        private bool _isButtonGoodOpenSelected = false;

        public int lang = 1;

        public bool IsButtonGoodOpenSelected
        {
            get { return _isButtonGoodOpenSelected; }
            set 
            {
                _isButtonGoodOpenSelected = value;
                OnPropertyChanged("ButtonGoodOpenTickness");
            }
        }

        public bool IsButtonClientOpenSelected
        {
            get { return _isButtonClientOpenSelected; }
            set 
            {
                _isButtonClientOpenSelected = value;
                OnPropertyChanged("ButtonClientOpenTickness");
            }
        }

        public bool IsSheduleSelected
        {
            get { return _isSheduleSelected; }
            set 
            { 
                _isSheduleSelected = value;
                OnPropertyChanged("ButtonSheduleTickness");
            }
        }
        public bool IsButtonServisOpenSelected
        {
            get { return _isButtonServisOpenSelected; }
            set
            {
                _isButtonServisOpenSelected = value;
                OnPropertyChanged("ButtonServisOpenTickness");
            }
        }
        public bool IsButtonEmploeeOpenSelected
        {
            get { return _isButtonEmploeeOpenSelected; }
            set
            {
                _isButtonEmploeeOpenSelected = value;
                OnPropertyChanged("ButtonEmploeeOpenBorderTickness");
            }
        }

        public int ButtonGoodOpenTickness
        {
            get { return IsButtonGoodOpenSelected ? 0 : 1; }
        }

        public int ButtonClientOpenTickness
        {
            get { return IsButtonClientOpenSelected ? 0 : 1; }
        }

        public int ButtonSheduleTickness
        {
            get { return IsSheduleSelected ? 0 : 1; }
        }

        public int ButtonServisOpenTickness
        {
            get { return IsButtonServisOpenSelected ? 0 : 1; }
        }

        public int ButtonEmploeeOpenBorderTickness
        {
            get { return IsButtonEmploeeOpenSelected ? 0 : 1; }
        }

        public MainWindowVM(MainWindow ownerWindow)
        {
            _ownerWindow = ownerWindow;
            _ownerWindow.FrameMain.NavigationService.Navigate(new ShedulePage()); 
        }

        #region Commands

        private DelegateCommand clientOpen;
        public DelegateCommand ClientOpen
        {
            get { return clientOpen ?? (clientOpen = new DelegateCommand(ClientClick)); }
        }
        public void ClientClick(object obj)
        {
            UnSelect();
            IsButtonClientOpenSelected = true;

            _ownerWindow.FrameMain.NavigationService.Navigate(new ClientPage());
        }

        private DelegateCommand sheduleCommand;
        public DelegateCommand SheduleCommand
        {
            get { return sheduleCommand ?? (sheduleCommand = new DelegateCommand(SheduleClick)); }
        }
        public void SheduleClick(object obj)
        {
            UnSelect();
            IsSheduleSelected = true;

            _ownerWindow.FrameMain.NavigationService.Navigate(new ShedulePage());
        }

        private DelegateCommand servisOpen;
        public DelegateCommand ServisOpen
        {
            get { return servisOpen ?? (servisOpen = new DelegateCommand(LoadServis)); }
        }
        public void LoadServis(object obj)
        {
            UnSelect();
            IsButtonServisOpenSelected = true;

            _ownerWindow.FrameMain.NavigationService.Navigate(new ServisPage());
        }

        private DelegateCommand emploeeOpen;
        public DelegateCommand EmploeeOpen
        {
            get { return emploeeOpen ?? (emploeeOpen = new DelegateCommand(EmploeeClick)); }
        }
        public void EmploeeClick(object obj)
        {
            UnSelect();
            IsButtonEmploeeOpenSelected = true;

            _ownerWindow.FrameMain.NavigationService.Navigate(new Employee());
        }

        private DelegateCommand goodOpen;
        public DelegateCommand GoodOpen
        {
            get { return goodOpen ?? (goodOpen = new DelegateCommand(GoodClick)); }
        }
        public void GoodClick(object obj)
        {
            UnSelect();
            IsButtonGoodOpenSelected = true;

            _ownerWindow.FrameMain.NavigationService.Navigate(new Good());
        }

        #endregion

        public void UnSelect()
        {
            IsSheduleSelected = false;
            IsButtonServisOpenSelected = false;
            IsButtonEmploeeOpenSelected = false;
            IsButtonClientOpenSelected = false;
            IsButtonGoodOpenSelected = false;
        }


        #region Content

        private string goodButtonName;
        public string GoodButtonName
        {
            get
            {
                switch (lang)
                {
                    case 1:
                        goodButtonName = "Товары";
                        break;
                    case 2:
                        goodButtonName = "Goods";
                        break;
                }
                return goodButtonName;
            }
            set { goodButtonName = value; OnPropertyChanged("GoodButtonName"); }
        }


        #endregion


    }
}

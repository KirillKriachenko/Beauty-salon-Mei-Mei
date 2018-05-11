using MeiMei.Model;
using MeiMei.View;
using MeiMei.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MeiMei.ViewModel
{
    public class EditServisVM : BaseVM
    {
        public ServisVM _servis;
        public Edit_Service _editOwner;

        public EditServisVM(Edit_Service ownerEditService)
        {
            _servis = ServisVM.Instance;
            _editOwner = ownerEditService;
            if (_servis.SelectedService != null && _servis.SelectedTypeService != null)
            {
                _editOwner.Kategoria_btn.IsEnabled = false;
                _editOwner.Kategoria_tb.IsEnabled = false;

                _editOwner.Price_tb.IsEnabled = true;
                _editOwner.NameService_tb.IsEnabled = true;
                _editOwner.Service_btn.IsEnabled = true;

                NameServis = _servis.SelectedService.ServiceName;
                CostServis = _servis.SelectedService.ServicePrice;


            }
            else if (_servis.SelectedTypeService != null)
            {
                _editOwner.Price_tb.IsEnabled = false;
                _editOwner.NameService_tb.IsEnabled = false;
                _editOwner.Service_btn.IsEnabled = false;
                KategoriaServis = _servis.SelectedTypeService.TypeService;
            } 

        }

        #region Property

        private string kategoriaServis;
        public string KategoriaServis
        {
            get { return kategoriaServis; }
            set { kategoriaServis = value; OnPropertyChanged("KategoriaServis"); }
        }

        private string nameServis;
        public string NameServis
        {
            get { return nameServis; }
            set { nameServis = value; OnPropertyChanged("NameServis"); }
        }

        private string costServis;
        public string CostServis
        {
            get { return costServis; }
            set { costServis = value; OnPropertyChanged("CostServis"); }
        }

        #endregion

        #region Command

        private DelegateCommand saveKategoriaClick;
        public DelegateCommand SaveKategoriaClick
        {
            get { return saveKategoriaClick ?? (saveKategoriaClick = new DelegateCommand(SaveKategoria)); }
        }

        public void SaveKategoria(object obj)
        {
            using (var db = new MeiMeiContext())
            {
                var kategoria = (from b in db.TypeOfServices
                               where b.TypeService ==  _servis.SelectedTypeService.TypeService
                               select b).FirstOrDefault();
                if (kategoria != null) kategoria.TypeService = KategoriaServis;
                db.SaveChanges();
            }
            MessageBox.Show(Properties.Resources.Save_message, "", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private DelegateCommand saveServiceClick;
        public DelegateCommand SaveServiceClick
        {
            get { return saveServiceClick ?? (saveServiceClick = new DelegateCommand(SaveService)); }
        }

        public void SaveService(object obj)
        {
            using (var db = new MeiMeiContext())
            {
                var service = (from b in db.Services
                               where b.ServiceName == _servis.SelectedService.ServiceName && b.ServicePrice == _servis.SelectedService.ServicePrice
                                 select b).FirstOrDefault();
                if (service != null)
                {
                    service.ServiceName = NameServis;
                    service.ServicePrice = CostServis;
                }
                db.SaveChanges();
            }
            MessageBox.Show(Properties.Resources.Save_message, "", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        #endregion



    }
}

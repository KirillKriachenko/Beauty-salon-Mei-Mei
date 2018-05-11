using System.Windows;
using MeiMei.Model;
using MeiMei.View;
using MeiMei.ViewModel;
using MeiMei.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeiMei.ViewModel
{
    public class ServisVM : BaseVM
    {
        public static ServisVM Instance;
     
        public ServisVM()
        {
            Instance = this;
        }

        #region Propertis

        private static TypeOfService selectedTypeService;
        public TypeOfService SelectedTypeService
        {
            get { return selectedTypeService; }
            set 
            {
                selectedTypeService = value;
                OnPropertyChanged("SelectedTypeService");
                OnPropertyChanged("PriceCollection");
            }
        }

        private static Service selectedService;
        public Service SelectedService
        {
            get { return selectedService; }
            set { selectedService = value; OnPropertyChanged("SelectedService"); }
        }

        private string kategoriaServis;
        public string KategoriaServis
        {
            get { return kategoriaServis; }
            set { kategoriaServis = value; OnPropertyChanged("KategoriaServis"); }
        }


        private string servisName;
        public string ServisName
        {
            get { return servisName; }
            set { servisName = value; OnPropertyChanged("ServisName"); }
        }

        private string servisCost;
        public string ServisCost
        {
            get { return servisCost; }
            set { servisCost = value; OnPropertyChanged("ServisCost"); }
        }


        private ObservableCollection<TypeOfService> kategoriaCollection;
        public ObservableCollection<TypeOfService> KategoriaCollection
        {
            get
            {
                kategoriaCollection = DataBaseManager.getTypeOfService(); 
                return kategoriaCollection;
            }
            set { kategoriaCollection = value; OnPropertyChanged("KategoriaCollection"); }

        }

        private ObservableCollection<Service> priceCollection;
        public ObservableCollection<Service> PriceCollection
        {
            get
            {
                    priceCollection = DataBaseManager.getService();
                return priceCollection;
            }
            set { priceCollection = value; OnPropertyChanged("PriceCollection"); }
        }

        #endregion

        #region Commands

        private DelegateCommand addServisOpenCommand;
        public DelegateCommand AddServisOpenCommand
        {
            get { return addServisOpenCommand ?? (addServisOpenCommand = new DelegateCommand(AddServisOpen)); }
        }
        public void AddServisOpen(object obj)
        {
            AddServis addServis = new AddServis() 
            {
                DataContext = new AddServisVM()
            };
            addServis.ShowDialog();
        }

        private DelegateCommand editServisCommand;
        public DelegateCommand EditServisCommand
        {
            get { return editServisCommand ?? (editServisCommand = new DelegateCommand(EditOpen)); }
        }
        public void EditOpen(object obj)
        {
            Edit_Service editService = new Edit_Service();
            editService.ShowDialog();
        }         
        
        private DelegateCommand deleteServiceCommand;
        public DelegateCommand DeleteServiceCommand
        {
            get { return deleteServiceCommand ?? (deleteServiceCommand = new DelegateCommand(Delete)); }
        }
        public void Delete(object obj)
        {

            if (SelectedTypeService != null && SelectedService != null)
            {
                using (var db = new MeiMeiContext())
                {
                    var delete = (from b in db.Services
                                  where b.Id == SelectedService.Id
                                  select b).FirstOrDefault();

                    db.Services.Remove(delete);
                    db.SaveChanges();
                    OnPropertyChanged("PriceCollection");
                }
            }
            else if(SelectedTypeService != null)
            {
                using (var db = new MeiMeiContext())
                {

                    for (int i = 0; i < db.Services.Count(); i++)
                    {


                        var deleteService = (from b in db.Services
                                             where b.TypeOfServiceId == SelectedTypeService.Id
                                             select b).FirstOrDefault();

                        if (deleteService != null)
                        {
                            db.Services.Remove(deleteService);
                            db.SaveChanges();
                            MessageBox.Show(Properties.Resources.RemovedSuccessfully_message, "", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                        else
                        {
                            break;
                        }
                        
                    }

                    var deleteType = (from b in db.TypeOfServices
                                      where b.Id == SelectedTypeService.Id
                                      select b).FirstOrDefault();
                    db.TypeOfServices.Remove(deleteType);
                    db.SaveChanges();
                    
                    
                }
            }
        }
        #endregion
    }
}

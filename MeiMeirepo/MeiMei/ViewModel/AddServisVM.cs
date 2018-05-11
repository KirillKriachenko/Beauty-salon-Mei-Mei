using System.Windows;
using MeiMei.Model;
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
    public class AddServisVM : BaseVM
    {

        public ServisVM _servis;

        public AddServisVM()
        {
            _servis = ServisVM.Instance;
        }
        #region Property

        private static TypeOfService seleTypeOfService;
        public TypeOfService SelectTypeOfService
        {
            get { return seleTypeOfService; }
            set { seleTypeOfService = value; OnPropertyChanged("SelectTypeOfService"); }
        }

        private string typeOfService = string.Empty;
        public string TypeOfService
        {
            get { return typeOfService; }
            set
            {
                typeOfService = value;
                OnPropertyChanged("TypeOfService");
            }
        }

        private string kategoriaServis;

        public string KategoriaServis
        {
            get { return kategoriaServis; }
            set
            {
                kategoriaServis = value;
                OnPropertyChanged("KategoriaServis");
            }
        }

        private string nameServis;

        public string NameServis
        {
            get { return nameServis; }
            set
            {
                nameServis = value;
                OnPropertyChanged("NameServis");
            }
        }

        private string costServis;

        public string CostServis
        {
            get { return costServis; }
            set
            {
                costServis = value;
                OnPropertyChanged("CostServis");
            }
        }


        private ObservableCollection<TypeOfService> typeServiceCollection;
        public ObservableCollection<TypeOfService> TypeServiceCollection
        {
            get
            {
                typeServiceCollection = new ObservableCollection<TypeOfService>(DataBaseManager.getTypeOfService());
                return typeServiceCollection;
            }
            set
            {
                typeServiceCollection = value;
                OnPropertyChanged("TypeServiceCollection");
            }
        }

        private ObservableCollection<AddServisVM> pricesColl;

        public ObservableCollection<AddServisVM> PricesColl
        {
            get
            {
                if (pricesColl == null)
                    pricesColl = new ObservableCollection<AddServisVM>();
                return pricesColl;
            }
            set
            {
                pricesColl = value;
                OnPropertyChanged("PricesColl");
            }
        }

        #endregion


        #region Command

        private DelegateCommand addServisCommand;
        public DelegateCommand AddServisCommand
        {
            get { return addServisCommand ?? (addServisCommand = new DelegateCommand(AddServis)); }
        }
        public void AddServis(object obj)
        {
            if (NameServis != String.Empty && CostServis != String.Empty && SelectTypeOfService != null )
            {
                if (SelectTypeOfService != null)
                {
                    PricesColl.Add(new AddServisVM {NameServis = NameServis, CostServis = CostServis,});

                    using (var db = new MeiMeiContext())
                    {
                        var service = new Service
                            {
                                ServiceName = NameServis,
                                ServicePrice = CostServis,
                                TypeOfServiceId = SelectTypeOfService.Id
                            };
                        db.Services.Add(service);
                        db.SaveChanges();
                    }

                    NameServis = String.Empty;
                    CostServis = String.Empty;
                }
                else
                {
                    MessageBox.Show(Properties.Resources.SelectServiceType_message, "", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show(Properties.Resources.FirstFill_message, Properties.Resources.Attention_message, MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
        }

        private DelegateCommand addTypeOfServiceCommand;

        public DelegateCommand AddTypeOfServiceCommand
        {
            get { return addTypeOfServiceCommand ?? (addTypeOfServiceCommand = new DelegateCommand(AddTypeservice)); }
        }

        public void AddTypeservice(object obj)
        {
            if (TypeOfService != string.Empty)
            {


                using (var db = new MeiMeiContext())
                {
                    var typeService = new TypeOfService
                        {
                            TypeService = TypeOfService
                        };
                    db.TypeOfServices.Add(typeService);
                    db.SaveChanges();
                }
                OnPropertyChanged("TypeServiceCollection");
            }
            else
            {
                MessageBox.Show(Properties.Resources.FirstFill_message, "", MessageBoxButton.OK,
                                MessageBoxImage.Information);
            } 
        }
    }

    #endregion
}

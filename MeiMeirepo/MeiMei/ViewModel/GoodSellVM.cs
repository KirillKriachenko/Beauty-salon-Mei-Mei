using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeiMei.Model;
using MeiMei.ViewModel.Base;

namespace MeiMei.ViewModel
{
    public class GoodSellVM : BaseVM
    {
        #region Properties

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value;OnPropertyChanged("Name");}
        }

        private string firma;
        public string Firma
        {
            get { return firma; }
            set { firma = value;OnPropertyChanged("Firma");}
        }

        private string perOne;
        public string PerOne
        {
            get { return perOne; }
            set { perOne = value;OnPropertyChanged("PerOne");}
        }

        private string count;
        public string Count
        {
            get { return count; }
            set { count = value; OnPropertyChanged("Count"); }
        }

        private string sum;
        public string Sum
        {
            get { return sum; }
            set { sum = value;OnPropertyChanged("Sum");}
        }

        private ObservableCollection<Goods> goodSellColl;
        public ObservableCollection<Goods> GoodSellColl
        {
            get
            {
                if (goodSellColl == null)
                    DataBaseManager.getGoods();
                return goodSellColl;
            }
            set { goodSellColl = value; OnPropertyChanged("GoodSellColl"); }
        }

        private ObservableCollection<TypeOfGoods> typeGoodSellColl;
        public ObservableCollection< TypeOfGoods >TypeGoodSellColl
        {
            get
            {
                if (typeGoodSellColl == null)
                    DataBaseManager.getTypeOfGoods();
                return typeGoodSellColl;
            }
            set { typeGoodSellColl = value; OnPropertyChanged("TypeGoodSellColl"); }
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MeiMei.Model;
using MeiMei.ViewModel.Base;

namespace MeiMei.ViewModel
{
    public class Add_GoodsVM : BaseVM
    {
        #region Properties

        private string company = string.Empty;
        public string Company
        {
            get { return company; }
            set { company = value;OnPropertyChanged("Company"); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value;OnPropertyChanged("Name"); }
        }

        private string price;
        public string Price
        {
            get { return price; }
            set { price = value;OnPropertyChanged("Price"); }
        }

        private string count;
        public string Count
        {
            get { return count; }
            set { count = value;
                OnPropertyChanged("Count");
            }
        }

        private static TypeOfGoods seleTypeOfGoods;
        public TypeOfGoods SelectTypeOfGoods
        {
            get { return seleTypeOfGoods; }
            set { seleTypeOfGoods = value; OnPropertyChanged("SelectTypeOfGoods"); }
        }

        private ObservableCollection<Add_GoodsVM> priceGoodsCollection;
        public ObservableCollection<Add_GoodsVM> PriceGoodsCollection
        {
            get
            {
                if(priceGoodsCollection == null)
                    priceGoodsCollection = new ObservableCollection<Add_GoodsVM>();
                return priceGoodsCollection;
            }

            set { priceGoodsCollection = value; OnPropertyChanged("PriceGoodsCollection"); }
        }

        private ObservableCollection<TypeOfGoods> typeOfGoodsCollection;
        public ObservableCollection<TypeOfGoods> TypeOfGoodsCollection
        {
            get
            {
                typeOfGoodsCollection = new ObservableCollection<TypeOfGoods>(DataBaseManager.getTypeOfGoods());
                return typeOfGoodsCollection;
            }
            set { typeOfGoodsCollection = value; OnPropertyChanged("TypeOfGoodsCollection"); }
        }

        #endregion

        #region Command

        private DelegateCommand addTypeOfGoods;
        public DelegateCommand AddTypeOfGoods
        {
            get { return addTypeOfGoods ?? (addTypeOfGoods = new DelegateCommand(AddTypeGoodsClick)); }
        }

        public void AddTypeGoodsClick(object obj)
        {
            if (Company != string.Empty)
            {
                using (var db = new MeiMeiContext())
                {
                    var typeGoods = new TypeOfGoods
                        {
                            TypeGoods = Company
                        };
                    db.TypeOfGoods.Add(typeGoods);
                    db.SaveChanges();
                }
                OnPropertyChanged("TypeOfGoodsCollection");
            }
            else
            {
                MessageBox.Show(Properties.Resources.FirstFill_message);
            }
        }

        private DelegateCommand addGoods;
        public DelegateCommand AddGoods 
        {
            get { return addGoods ?? (addGoods = new DelegateCommand(AddGoodsClick)); }
        }

        public void AddGoodsClick(object obj)
        {
            PriceGoodsCollection.Add(new Add_GoodsVM { Name = Name, Price = Price, Count = Count});
            using (var db = new MeiMeiContext())
            {
                var goods = new Goods
                    {
                        GoodName = Name,
                        GoodPrice = Price,
                        Count = Count,
                        TypeOfGoodsId = SelectTypeOfGoods.Id
                    };
                db.Goods.Add(goods);
                db.SaveChanges();
            }
        }

        #endregion
    }
}

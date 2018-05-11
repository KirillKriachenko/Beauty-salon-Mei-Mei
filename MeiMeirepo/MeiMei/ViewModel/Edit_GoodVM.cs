using System.Windows;
using MeiMei.Model;
using MeiMei.View;
using MeiMei.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeiMei.ViewModel
{
    public class Edit_GoodVM : BaseVM
    {
        public GoodVM _good;
        public Edit_Goods _edtGoods;
        
        public Edit_GoodVM(Edit_Goods ownerEditGoods)
        {
            _good = GoodVM.Instance;
            _edtGoods = ownerEditGoods;

            if (_good.SelectedGoods != null && _good.SelectedTypeOfGoods != null)
            {
                _edtGoods.Kategoria_tb.IsEnabled = false;
                _edtGoods.Kategoria_btn.IsEnabled = false;

                _edtGoods.Price_tb.IsEnabled = true;
                _edtGoods.Name_tb.IsEnabled = true;
                _edtGoods.Count_tb.IsEnabled = true;
                _edtGoods.Goods_btn.IsEnabled = true;

                GoodName = _good.SelectedGoods.GoodName;
                GoodPrice = _good.SelectedGoods.GoodPrice;
                GoodCount = _good.SelectedGoods.Count;
            }
            else if( _good.SelectedTypeOfGoods != null)
            {
                _edtGoods.Price_tb.IsEnabled = false;
                _edtGoods.Name_tb.IsEnabled = false;
                _edtGoods.Count_tb.IsEnabled = false;
                _edtGoods.Goods_btn.IsEnabled = false;

                _edtGoods.Kategoria_tb.IsEnabled = true;
                _edtGoods.Kategoria_btn.IsEnabled = true;


                GoodKategoria = _good.SelectedTypeOfGoods.TypeGoods;
            }
        }
        #region Property

        private string goodKategoria;
        public string GoodKategoria
        {
            get { return goodKategoria; }
            set { goodKategoria = value; OnPropertyChanged("GoodKategoria"); }
        }

        private string goodName;
        public string GoodName
        {
            get { return goodName; }
            set { goodName = value; OnPropertyChanged("GoodName"); }
        }
        
        private string goodPrice;
        public string GoodPrice
        {
            get { return goodPrice; }
            set { goodPrice = value; OnPropertyChanged("PoodPrice"); }
        }

        private string goodCount;
        public string GoodCount
        {
            get { return goodCount; }
            set { goodCount = value; OnPropertyChanged("GoodCount"); }
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
                var kategoria = (from b in db.TypeOfGoods
                                 where b.TypeGoods == _good.SelectedTypeOfGoods.TypeGoods
                                 select b).FirstOrDefault();
                if (kategoria != null) kategoria.TypeGoods = GoodKategoria;
                db.SaveChanges();
                OnPropertyChanged("CompColl");
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
                var good = (from b in db.Goods
                               where b.GoodName == _good.SelectedGoods.GoodName && b.GoodPrice == _good.SelectedGoods.GoodPrice && b.Count == _good.SelectedGoods.Count
                               select b).FirstOrDefault();
                if (good != null)
                {
                    good.GoodName = GoodName;
                    good.GoodPrice = GoodPrice;
                    good.Count = GoodCount;
                }
                db.SaveChanges();
            }
            MessageBox.Show(Properties.Resources.Save_message, "", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        #endregion
    }
}

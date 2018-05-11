using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MeiMei.Model;
using MeiMei.View;
using MeiMei.ViewModel.Base;

namespace MeiMei.ViewModel
{
    public class GoodVM : BaseVM
    {
        public static GoodVM Instance;

        public GoodVM()
        {
            Instance = this;
        }

        #region Property

        private static TypeOfGoods selectedTypeOfGoods;

        public TypeOfGoods SelectedTypeOfGoods
        {
            get { return selectedTypeOfGoods; }
            set
            {
                selectedTypeOfGoods = value;
                if (selectedTypeOfGoods == null)
                    return;
                OnPropertyChanged("SelectedTypeOfGoods");
                OnPropertyChanged("GoodsColl");
            }
        }

        private static Goods selectedGoods;

        public Goods SelectedGoods
        {
            get { return selectedGoods; }
            set
            {
                selectedGoods = value;
                OnPropertyChanged("SelectedGoods");
            }
        }

        private string company;

        public string Company
        {
            get { return company; }
            set
            {
                company = value;
                OnPropertyChanged("Company");
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        private string price;

        public string Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        private string customer;
        public string Customer
        {
            get { return customer; }
            set { customer = value; OnPropertyChanged("Customer"); }
        }

        private string count = "1";

        public string Count
        {
            get { return count; }
            set
            {
                count = value;
                OnPropertyChanged("Count");
                if (Count != null && Count != "")
                {
                    Price = (Convert.ToInt32(SelectedGoods.GoodPrice) * Convert.ToInt32(Count)).ToString();
                }
                
            }
        }

        private static Customers selectedCustomers;

        public Customers SelectedCustomers
        {
            get { return selectedCustomers; }
            set
            {
                selectedCustomers = value;
                OnPropertyChanged("SelectedCustomers");
            }
        }

        private ObservableCollection<Customers> customerColl;

        public ObservableCollection<Customers> CustomerColl
        {
            get { return customerColl = DataBaseManager.getAllCustomer(); }
            set
            {
                customerColl = value;
                OnPropertyChanged("CustomerColl");
            }
        }

        private ObservableCollection<TypeOfGoods> compColl;

        public ObservableCollection<TypeOfGoods> CompColl
        {
            get
            {
                if (compColl == null)
                    compColl = DataBaseManager.getTypeOfGoods();
                return compColl;
            }
            set
            {
                compColl = value;
                OnPropertyChanged("CompColl");
            }
        }

        private ObservableCollection<Goods> goodsColl;

        public ObservableCollection<Goods> GoodsColl
        {
            get
            {

                    goodsColl = DataBaseManager.getGoods();
                return goodsColl;
            }
            set
            {
                goodsColl = value;
                OnPropertyChanged("GoodsColl");
            }
        }

        private ObservableCollection<GoodHistory> goodsHistoryColl;

        public ObservableCollection<GoodHistory> GoodsHistoryColl
        {
            get { return goodsHistoryColl = DataBaseManager.getGoodHistory(); }
            set
            {
                goodsHistoryColl = value;
                OnPropertyChanged("GoodsHistoryColl");
            }
        }

        #endregion

        #region Command

        private DelegateCommand addGoodOpenCommand;

        public DelegateCommand AddGoodOpenCommand
        {
            get { return addGoodOpenCommand ?? (addGoodOpenCommand = new DelegateCommand(AddGoodOpen)); }
        }

        public void AddGoodOpen(object obj)
        {

            Add_Goods addGoods = new Add_Goods();
            addGoods.ShowDialog();
        }

        private DelegateCommand sellGoods;

        public DelegateCommand SellGoods
        {
            get { return sellGoods ?? (sellGoods = new DelegateCommand(SellGoodsClick)); }
        }

        public void SellGoodsClick(object obj)
        {
            if (SelectedGoods != null)
            {

                int price = Convert.ToInt32(SelectedGoods.GoodPrice)*Convert.ToInt32(Count);

                int newCount = Convert.ToInt32(SelectedGoods.Count) - Convert.ToInt32(Count);


                using (var db = new MeiMeiContext())
                {
                    if (SelectedCustomers != null)
                    {


                        var goodHistory = new GoodHistory
                            {
                                GoodName = SelectedGoods.GoodName,
                                Price = price.ToString(),
                                Data = DateTime.Now,
                                Customer = SelectedCustomers.FIO
                            };
                        db.GoodHistories.Add(goodHistory);
                        db.SaveChanges();



                        var goods = (from b in db.Goods
                                     where
                                         b.GoodName == GoodVM.Instance.SelectedGoods.GoodName &&
                                         b.GoodPrice == GoodVM.Instance.SelectedGoods.GoodPrice
                                         && b.Count == GoodVM.Instance.SelectedGoods.Count
                                     select b).FirstOrDefault();

                        if (newCount >= 0)
                        {
                            goods.Count = newCount.ToString();
                            db.SaveChanges();
                            OnPropertyChanged("GoodsColl");
                            OnPropertyChanged("GoodsHistoryColl");
                        }
                        else
                        {
                            MessageBox.Show("Больше продать нельзя");
                        }
                    }
                    else if(selectedCustomers == null)
                    {
                        using (var bd = new MeiMeiContext())
                        {


                            var customer = new Customers
                                {
                                    FIO = Customer
                                };
                            bd.Customers.Add(customer);
                            bd.SaveChanges();

                            var goodHistory = new GoodHistory
                                {
                                    GoodName = SelectedGoods.GoodName,
                                    Price = price.ToString(),
                                    Data = DateTime.Now,
                                    Customer = Customer
                                };
                            bd.GoodHistories.Add(goodHistory);
                            bd.SaveChanges();



                            var goods = (from b in bd.Goods
                                         where
                                             b.GoodName == GoodVM.Instance.SelectedGoods.GoodName &&
                                             b.GoodPrice == GoodVM.Instance.SelectedGoods.GoodPrice
                                             && b.Count == GoodVM.Instance.SelectedGoods.Count
                                         select b).FirstOrDefault();

                            OnPropertyChanged("CustomerColl");

                            if (newCount >= 0)
                            {
                                goods.Count = newCount.ToString();
                                bd.SaveChanges();
                                OnPropertyChanged("GoodsColl");
                                OnPropertyChanged("GoodsHistoryColl");
                            }
                            else
                            {
                                MessageBox.Show("Больше продать нельзя");
                            }
                        }
                    }
                }
            }
        }


        private DelegateCommand editGoodCommand;
        public DelegateCommand EditGoodCommand
        {
            get { return editGoodCommand ?? (editGoodCommand = new DelegateCommand(EditGood)); }
        }

        public void EditGood(object obj)
        {
            Edit_Goods editGood = new Edit_Goods();
            editGood.ShowDialog();
        }

        private DelegateCommand deleteGoodCommand;
        public DelegateCommand DeleteGoodCommand
        {
            get { return deleteGoodCommand ?? (deleteGoodCommand = new DelegateCommand(DeleteGoodClick)); }
        }

        public void DeleteGoodClick(object obj)
        {
            if (SelectedGoods != null && SelectedTypeOfGoods != null)
            {
                using (var db = new MeiMeiContext())
                {
                    var delete = (from b in db.Goods
                                  where b.Id == SelectedGoods.Id
                                  select b).FirstOrDefault();
                    db.Goods.Remove(delete);
                    db.SaveChanges();
                    OnPropertyChanged("GoodsColl");
                }
            }

            else if(SelectedTypeOfGoods != null)
            {
                using (var db = new MeiMeiContext())
                {
                    for (int i = 0; i < db.Goods.Count(); i++)
                    {
                        var deleteGoods = (from b in db.Goods
                                           where b.TypeOfGoodsId == SelectedTypeOfGoods.Id
                                           select b).FirstOrDefault();
                        if (deleteGoods != null)
                        {
                            db.Goods.Remove(deleteGoods);
                            db.SaveChanges();
                        }
                        else
                        {
                            break; 
                        }

                        var deleteType = (from b in db.TypeOfGoods
                                          where b.Id == SelectedTypeOfGoods.Id
                                          select b).FirstOrDefault();
                        db.TypeOfGoods.Remove(deleteType);
                        db.SaveChanges();
                    }
                }
            }
        }
    }

    #endregion
}

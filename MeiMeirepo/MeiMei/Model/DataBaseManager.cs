using MeiMei.View;
using MeiMei.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MeiMei.Model
{
    public class DataBaseManager
    {

        public static ObservableCollection<EmployeeHistory> getEmployeeHistory()
        {
            using (var db = new MeiMeiContext())
            {
                
                var query = from history in db.EmployeeHistories
                            join employee in db.EmployeeTables on history.EmployeeTableId equals employee.Id
                            where
                                employee.Id == EmployeeVM.Instance.SelectedEmployee.Id &&
                                history.Data == EmployeeVM.Instance.Today
                            select history;
                if (db.EmployeeHistories.Count() != 0)
                {
                    return new ObservableCollection<EmployeeHistory>(query);
                }
                return new ObservableCollection<EmployeeHistory>();
            }
        }

        public static ObservableCollection<SheduleColumn> getSheduleColumn()
        {
            using (var db = new MeiMeiContext())
            {
                var query = from b in db.SheduleColumns
                            orderby b.ColumnName
                            select b;
                return new ObservableCollection<SheduleColumn>(query);
            }
        }


        public static ObservableCollection<GoodHistory> getGoodHistory()
        {
            using (var db = new MeiMeiContext())
            {
                var query = from b in db.GoodHistories
                            orderby b.GoodName
                            select b;
                return new ObservableCollection<GoodHistory>(query);
            }
        }

        public static ObservableCollection<Shedule> GetAllShedule()
        {
            using (var db = new MeiMeiContext())
            {
                var query = from b in db.Shedules
                            orderby b.ServiceName
                            select b;
                return new ObservableCollection<Shedule>(query);
            }
        }

        public static ObservableCollection<ScheduleVM> findEmploeyy()
        {
            var res = new ObservableCollection<ScheduleVM>();
            using (var db = new MeiMeiContext())
            {
                var query = from b in db.EmployeeTables
                            orderby b.FIO
                            select b;

                foreach (var item in query)
                {
                    var name = new ScheduleVM();
                    name.FIO = item.FIO;
                    res.Add(name);
                }
            }
            return res;
        }

        public static ObservableCollection<Customers> getAllCustomer()
        {
            using (var db = new MeiMeiContext())
            {
                var query = from b in db.Customers
                            orderby b.FIO
                            select b;
               return new ObservableCollection<Customers>(query);
            }
        }

        public static ObservableCollection<History> getAllCustomerHistory()
        {
            using (var db = new MeiMeiContext())
            {
                CustomerVM _customer;
                _customer = CustomerVM.Instance;


                var query = from history in db.Histories
                            join customer in db.Customers on history.CustomersId equals customer.Id
                            where customer.Id == _customer.SelectedCustomer.Id
                           // where customer.Id == history.CustomersId
                            //orderby history.CustomersId
                            select history;

                if (db.Histories.Count() != 0)
                {
                    //using (var bd = new MeiMeiContext())
                    //{
                    //    foreach (var history in bd.Histories)
                    //    {
                    //        bd.Histories.Remove(history);
                    //    }
                    //    bd.SaveChanges();
                    //}
                    //using (var ctx = new ShopEntities())
                    //{
                    //    foreach (var u in ctx.Users)
                    //    {
                    //        ctx.Users.Remove(u);
                    //    }
                    //    ctx.SaveChanges();
                    //}
                    return new ObservableCollection<History>(query);
                }

                //var query = from b in db.Histories
                //            join ba in db.Customers on b.CustomersId equals ba.Id
                //            where b.Id == _customer.SelectedCustomer.Id
                //            where b.Id == ba.Id
                //            //orderby b.Data
                //            select b;



                //var query = from b in db.TypeOfServices
                //            join ba in db.Services on b.Id equals ba.TypeOfServiceId
                //            where b.Id == _servis.SelectedTypeService.Id
                //            where b.Id == ba.TypeOfServiceId
                //            select ba;


                return new ObservableCollection<History>();
            }
        }

        public static ObservableCollection<EmployeeTable> getAllEmpoyee()
        {
            using (var db = new MeiMeiContext())
            {
                var query = from b in db.EmployeeTables
                            orderby b.FIO
                            select b;
                return new ObservableCollection<EmployeeTable>(query);
            }
        }

        public static ObservableCollection<SheduleColumn> getAllColumn()
        {
            using (var db = new MeiMeiContext())
            {
                var quary = from b in db.SheduleColumns
                            orderby b.ColumnName
                            select b;
                return new ObservableCollection<SheduleColumn>(quary);
            }
        }

        public static ObservableCollection<SheduleTime> getAllTime()
        {
            using (var db = new MeiMeiContext())
            {
                var query = from b in db.SheduleTimes
                            orderby b.Time
                            select b;
                return new ObservableCollection<SheduleTime>(query);
            }
        }


        public static ObservableCollection<TypeOfService> getTypeOfService()
        {
            using (var db = new MeiMeiContext())
            {
                var query = from b in db.TypeOfServices
                            orderby b.TypeService
                            select b;
                return new ObservableCollection<TypeOfService>(query);
            }
        }

        public static ObservableCollection<Service> getService()
        {
            using (var db = new MeiMeiContext())
            {
                ServisVM _servis;
                _servis = ServisVM.Instance;

                var query = from b in db.TypeOfServices
                            join ba in db.Services on b.Id equals ba.TypeOfServiceId
                            where b.Id == _servis.SelectedTypeService.Id
                            where b.Id == ba.TypeOfServiceId
                            select ba;

                if (db.TypeOfServices.Count() == 0)
                {
                    AddServis addServis = new AddServis()
                    {
                        DataContext = new AddServisVM()
                    };
                    addServis.ShowDialog();
                }
                else
                {
                    return new ObservableCollection<Service>(query);
                }

                return new ObservableCollection<Service>();

                //var query = from b in db.Services
                //            join ba in db.TypeOfServices on b.Id equals ba.Id
                //            where ba.Services == _servis.SelectedTypeService.Services
                //            select b;

            }
        }


        public static ObservableCollection<Service> getAddService()
        {
            using (var db = new MeiMeiContext())
            {
            
                Add_ScheduleVM _servis;
                _servis = Add_ScheduleVM.Instance;

                var query = from b in db.TypeOfServices
                            join ba in db.Services on b.Id equals ba.TypeOfServiceId
                            //where b.Id == _servis.SelectedService.Id
                            where b.Id == ba.TypeOfServiceId
                            select ba;


                //var query = from b in db.Services
                //            join ba in db.TypeOfServices on b.Id equals ba.Id
                //            //where b.Id == _servis.SelectedService.Id
                //            where b.TypeOfServiceId == ba.Id
                //            select b;
                return new ObservableCollection<Service>(query);

            }
        }



        public static ObservableCollection<TypeOfGoods> getTypeOfGoods()
        {
            using (var db = new MeiMeiContext())
            {

                var quary = from b in db.TypeOfGoods
                            orderby b.TypeGoods
                            select b;
                return new ObservableCollection<TypeOfGoods>(quary);
            }
        }

        public static ObservableCollection<Goods> getGoods()
        {
            using (var db = new MeiMeiContext())
            {
                GoodVM _good;
                _good = GoodVM.Instance;


                
                var query = from b in db.TypeOfGoods
                            join ba in db.Goods on b.Id equals ba.TypeOfGoodsId
                            where b.Id == _good.SelectedTypeOfGoods.Id
                            where b.Id == ba.TypeOfGoodsId
                            select ba;

                if (db.TypeOfGoods.Count() == 0)
                {
                    Add_Goods addGoods = new Add_Goods();
                    addGoods.ShowDialog();
                }
                else
                {
                    return new ObservableCollection<Goods>(query);
                }
                

                return new ObservableCollection<Goods>();
            }
        }
    }
}

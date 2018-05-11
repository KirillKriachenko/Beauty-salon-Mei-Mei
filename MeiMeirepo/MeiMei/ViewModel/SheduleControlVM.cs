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
    public class SheduleControlVM : BaseVM
    {

        public static SheduleControlVM Instance;
        private EmployeeTable employeeTable;
        private Shedule shedule;
        private int _columnNumber;
        public SheduleControlVM(int columnNumber)
        {
            Instance = this;
            _columnNumber = columnNumber;
        }

        #region Property

        private string room;
        public string Room
        {
            get { return shedule != null ? shedule.Room : String.Empty; }
            set { shedule.Room = value; OnPropertyChanged("Room"); }
        }

        private string employee;
        public string Employee
        {
            get { return employeeTable != null ? employeeTable.FIO : String.Empty; }
            set
            {
                employeeTable.FIO = value;
                OnPropertyChanged("Employee");
            }
        }

        private string service;
        public string Service
        {
            get { return shedule != null ? shedule.ServiceName : String.Empty; }
            set { shedule.ServiceName = value; OnPropertyChanged("Service"); }
        }

        private string customer;
        public string Customer
        {
            get { return shedule != null ? shedule.CustomerName : String.Empty; }
            set { shedule.CustomerName = value; OnPropertyChanged("Customer"); }
        }

        private string price;
        public string Price
        {
            get { return shedule != null ? shedule.ServicePrice : String.Empty; }
            set { shedule.ServicePrice = value; OnPropertyChanged("Price"); }
        }

        #endregion

        #region Command


        private DelegateCommand opeenAddCommand;
        public DelegateCommand OpenAddCommand
        {
            get { return opeenAddCommand ?? (opeenAddCommand = new DelegateCommand(OpenCommand)); }
        }

        public void OpenCommand(object obj)
        {

            Add_Schedule add_Schedule = new Add_Schedule(this);
            add_Schedule.ShowDialog();
        }



        private DelegateCommand deleteCommand;
        public DelegateCommand DeleteCommand
        {
            get { return deleteCommand ?? (deleteCommand = new DelegateCommand(DeleteClick)); }
        }

        public int ColumnNumber
        {
            get { return _columnNumber; }
        }

        public void DeleteClick(object obj)
        {
            using (var db = new MeiMeiContext())
            {
                var delete = (from b in db.Shedules
                             where b.CustomerName == Customer && b.ServiceName == Service && b.EmployeeTable.FIO == Employee && b.Time == b.Time && b.Size == b.Size && b.Data == b.Data
                              select b).FirstOrDefault();


                var deleteHistory = (from b in db.EmployeeHistories
                                     where b.ServiceName == Service
                                     select b).FirstOrDefault();


                var deletehistoryCustomer = (from b in db.Histories
                                             where b.ServiceName == Service
                                             select b).FirstOrDefault();

                db.Shedules.Remove(delete);
                db.SaveChanges();

                db.EmployeeHistories.Remove(deleteHistory);
                db.SaveChanges();

                db.Histories.Remove(deletehistoryCustomer);
                db.SaveChanges();

            }

            MessageBox.Show(Properties.Resources.RemovedSuccessfully_message, "", MessageBoxButton.OK, MessageBoxImage.Information);

            ScheduleVM.Instance.FindeShedule(ShedulePage.Instance.gridShedule);
        }


        private DelegateCommand opeenEditCommand;
        public DelegateCommand OpeenEditCommand
        {
            get { return opeenEditCommand ?? (opeenEditCommand = new DelegateCommand(OpenEditableCommand)); }
        }

        public EmployeeTable EmployeeTable
        {
            get { return employeeTable; }
            set { employeeTable = value; }
        }

        public Shedule Shedule
        {
            get { return shedule; }
            set { shedule = value; }
        }

        public void OpenEditableCommand(object obj)
        {
            Edit_Schedule editShedule = new Edit_Schedule(employeeTable, shedule);
            editShedule.ShowDialog();
        }



        #endregion
    }
}

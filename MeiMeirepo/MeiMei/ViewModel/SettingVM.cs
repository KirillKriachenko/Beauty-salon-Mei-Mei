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
    class SettingVM : BaseVM
    {

        private MainWindow _ownerWindow;

        #region Propertis

        private string startFrom = string.Empty;
        public string StartFrom
        {
            get { return startFrom; }
            set { startFrom = value; OnPropertyChanged("StartFrom"); }
        }


        private string endFrom = string.Empty;
        public string EndFrom
        {
            get { return endFrom; }
            set { endFrom = value; OnPropertyChanged("EndFrom"); }
        }

        private string newColumn = string.Empty;
        public string NewColumn
        {
            get { return newColumn; }
            set { newColumn = value; OnPropertyChanged("NewColumn"); }
        }

        private static SheduleColumn selectedColumn;
        public SheduleColumn SelectedColumn
        {
            get { return selectedColumn; }
            set { selectedColumn = value; OnPropertyChanged("SelectedColumn"); }
        }
        private ObservableCollection<SheduleColumn> columnCollection;
        public ObservableCollection<SheduleColumn> ColumnCollection
        {
            get 
            { 
                columnCollection = DataBaseManager.getSheduleColumn();
                return columnCollection;
            }
            set { columnCollection = value; OnPropertyChanged("ColumnCollection"); }
        }

       
        #endregion

        #region Command

        private DelegateCommand addTimes;
        public DelegateCommand Addtimes
        {
            get { return addTimes ?? (addTimes = new DelegateCommand(AddTimesCklick)); }
        }

        public void AddTimesCklick(object obj)
        {
            if (StartFrom != string.Empty && EndFrom != string.Empty)
            {

                int a, b;
                a = Convert.ToInt32(StartFrom);
                b = Convert.ToInt32(EndFrom);
                int c = 0;
                for (int i = a; i < b + 1; i++)
                {
                    for (int j = 1; j < 5; j++)
                    {
                        if (c == 0)
                        {
                            using (var db = new MeiMeiContext())
                            {
                                var time = new SheduleTime
                                {
                                    Time = i + " : " + c + "0"
                                };
                                db.SheduleTimes.Add(time);
                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            using (var db = new MeiMeiContext())
                            {
                                var time = new SheduleTime
                                {
                                    Time = i + " : " + c
                                };
                                db.SheduleTimes.Add(time);
                                db.SaveChanges();
                            }
                        }

                        c += 15;
                        if (c > 45)
                        {
                            c = 0;
                        }
                    }
                }
            
            }

            else
            {
                MessageBox.Show(Properties.Resources.StartEnterDay_message, "", MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
        }


        private DelegateCommand addColumn;
        public DelegateCommand AddColumn
        {
            get { return addColumn ?? (addColumn = new DelegateCommand(AddColumnClick)); }
        }

        public void AddColumnClick(object obj)
        {
            if (NewColumn != string.Empty)
            {


                using (var db = new MeiMeiContext())
                {
                    var column = new SheduleColumn
                    {
                        ColumnName = NewColumn
                    };
                    db.SheduleColumns.Add(column);
                    db.SaveChanges();
                }

                MessageBox.Show(Properties.Resources.Сompleted_message, "", MessageBoxButton.OK, MessageBoxImage.Information);
                OnPropertyChanged("ColumnCollection");
            }
            else
            {
                MessageBox.Show(Properties.Resources.FirstFill_message, "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private DelegateCommand removeColumn;
        public DelegateCommand RemoveColumn
        {
            get { return removeColumn ?? (removeColumn = new DelegateCommand(RemoveClick)); }
        }

        public void RemoveClick(object obj)
        {
            if (SelectedColumn != null)
            {


                using (var db = new MeiMeiContext())
                {
                    var sheduleColumn = (from b in db.SheduleColumns
                                         where b.ColumnName == SelectedColumn.ColumnName
                                         select b).FirstOrDefault();
                    db.SheduleColumns.Remove(sheduleColumn);
                    db.SaveChanges();

                    OnPropertyChanged("ColumnCollection");
                }
            }

            else
            {
                MessageBox.Show(Properties.Resources.FirstSelectObject_message, "", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        #endregion
    }
}

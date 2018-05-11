using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using MeiMei.Model;
using MeiMei.View;
using MeiMei.ViewModel;
using MeiMei.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeiMei.ViewModel
{
    public class ScheduleVM : BaseVM
    {
        public static ScheduleVM Instance;
        public static Grid GridInstance;
        private ShedulePage _ownershedulePage;
        private List<ControlShedule> _controlShedules = new List<ControlShedule>();

        public ScheduleVM(ShedulePage ownerShedule)
        {
            Instance = this;
            ThisData = DateTime.Now.Date;

            _ownershedulePage = ownerShedule;
            var gridShedule = _ownershedulePage.gridShedule;
            GridInstance = gridShedule;
            gridShedule.Background = new SolidColorBrush();
            gridShedule.Height = 2000;
            gridShedule.MinWidth = 1100;
            gridShedule.MaxWidth = 1200;
            
            FindeShedule(gridShedule);

        }



        public void FindeShedule(Grid gridShedule)
        {
            for (int i = 0, size = gridShedule.Children.Count; i < size; i++ )
            {
                gridShedule.Children.RemoveAt(0);
            }
            gridShedule.ColumnDefinitions.Clear();
            gridShedule.RowDefinitions.Clear();
            int a = 8;
            int b, c;
            b = 24;
            c = b - a;

            for (int i = 0; i < SheduleTimeCollection.Count + 1; i++)
            {
                gridShedule.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < SheduleColumnCollection.Count + 1; i++)
            {
                gridShedule.ColumnDefinitions.Add(new ColumnDefinition());
            }


            for (int j = 0; j < gridShedule.ColumnDefinitions.Count - 1; j++)
            {
                var textBlock = new TextBlock();
                textBlock.VerticalAlignment = VerticalAlignment.Center;

                textBlock.HorizontalAlignment = HorizontalAlignment.Center;

                textBlock.FontSize = 20;

                gridShedule.Children.Add(textBlock);
                textBlock.Text = SheduleColumnCollection[j].ColumnName;
                
                Grid.SetColumn(textBlock, j + 1);
                Grid.SetRow(textBlock, 0);
            }



            for (int j = 0; j < gridShedule.RowDefinitions.Count - 1; j++)
            {
                var textBlock = new TextBlock();
                textBlock.VerticalAlignment = VerticalAlignment.Center;
                textBlock.HorizontalAlignment = HorizontalAlignment.Center;

                textBlock.FontSize = 20;

                gridShedule.Children.Add(textBlock);


                textBlock.Text = SheduleTimeCollection[j].Time;

                Grid.SetColumn(textBlock, 0);
                Grid.SetRow(textBlock, j + 1);
                a = a + 1;

             
            }

           
            for (int i = 0; i < gridShedule.ColumnDefinitions.Count; i++)
            {
                for (int j = 0; j < gridShedule.RowDefinitions.Count; j++)
                {
                    var border = new Border();
                    border.BorderThickness = new Thickness(1, 1, 1, 1);
                    border.BorderBrush = Brushes.Black;


                    var control = new ControlShedule(i);
                    control.Visibility = Visibility.Visible;
                    control.BorderThickness = new Thickness(1, 1, 1, 1);
                    control.BorderBrush = Brushes.Black;
                    control.ImageDelete.Visibility = Visibility.Hidden;
                    control.ImageEdit.Visibility = Visibility.Hidden;
                    if (j % 4 == 0)
                    {
                        control.Background = Brushes.RosyBrown;
                    }

                    gridShedule.Children.Add(border);
                    gridShedule.Children.Add(control);

                    Grid.SetColumn(border, i);
                    Grid.SetRow(border, j);

                    Grid.SetRow(control, j + 1);
                    Grid.SetColumn(control, i + 1);

                }

            }


            for (int i = 0; i < _controlShedules.Count; i++)
            {
                gridShedule.Children.Remove(_controlShedules[i]);
            }
            _controlShedules.Clear();
            foreach (var employeeTable in EmployeeCollection)
            {
                var list = new List<Shedule>();
                foreach (var shedule in SheduleCollection)
                {
                    if (shedule.EmployeeTableId == employeeTable.Id && shedule.Data == ThisData.Date)
                    {
                        list.Add(shedule);
                    }
                }

                foreach (var shedule in list)
                {
                    if (ThisData.Date == shedule.Data)
                    {
                        var control = new ControlShedule(Convert.ToInt32(shedule.Column));
                        _controlShedules.Add(control);

                        control.SheduleControl.Shedule = shedule;
                        control.SheduleControl.EmployeeTable = employeeTable;

                        control.Visibility = Visibility.Visible;
                        control.BorderThickness = new Thickness(1, 1, 1, 1);
                        control.BorderBrush = Brushes.Black;

                        control.Background = Brushes.Moccasin;
                        control.Image.Visibility = Visibility.Hidden;

                        gridShedule.Children.Add(control);
                        Grid.SetRow(control, Convert.ToInt32(shedule.Time));
                        Grid.SetColumn(control, Convert.ToInt32(shedule.Column));
                        Grid.SetRowSpan(control, Convert.ToInt32(shedule.Size));
                    }
                }
            }
        }

        private static readonly BrushConverter BrushConverter = new BrushConverter();
        private static readonly Brush Brush;
        static ScheduleVM()
        {
            Brush = (Brush)BrushConverter.ConvertFrom("#FFCFFFCA"); 
            Brush.Freeze();
        }

        public ScheduleVM()
        {
            ThisData = DateTime.Now;
        }

        #region Property
        private DateTime thisdDta;
        public DateTime ThisData
        {
            get { return thisdDta;}
            set { thisdDta = value; OnPropertyChanged("ThisData");
                if (_ownershedulePage != null)
                {
                    FindeShedule(_ownershedulePage.gridShedule); 
                }
            }
        }

        private string fio;
        public string FIO
        {
            get { return fio; }
            set { fio = value; OnPropertyChanged("FIO"); }
        }

        private ObservableCollection<SheduleColumn> sheduleColumnCollection;
        public ObservableCollection<SheduleColumn> SheduleColumnCollection
        {
            get
            {
                sheduleColumnCollection = new ObservableCollection<SheduleColumn>(DataBaseManager.getAllColumn());
                sheduleColumnCollection = new ObservableCollection<SheduleColumn>(sheduleColumnCollection.OrderBy(id => id.Id));
                sheduleTimeCollection = new ObservableCollection<SheduleTime>(sheduleTimeCollection.OrderBy(id => id.Id));
                return sheduleColumnCollection;
            }
            set { sheduleColumnCollection = value; OnPropertyChanged("SheduleColumnCollection"); }
        }

        private ObservableCollection<EmployeeTable> employeeCollection;
        public ObservableCollection<EmployeeTable> EmployeeCollection
        {
            get
            {
                employeeCollection = new ObservableCollection<EmployeeTable>(DataBaseManager.getAllEmpoyee());//(DataBaseManager.findEmploeyy());
                return employeeCollection;
            }
            set { employeeCollection = value; OnPropertyChanged("EmployeeCollection"); }
        }

        private ObservableCollection<Shedule> sheduleCollection;
        public ObservableCollection<Shedule> SheduleCollection
        {
            get
            {
                sheduleCollection = new ObservableCollection<Shedule>(DataBaseManager.GetAllShedule());
                return sheduleCollection;
            }
            set { sheduleCollection = value; OnPropertyChanged("SheduleCollection"); }
        }


        private ObservableCollection<SheduleTime> sheduleTimeCollection;
        public ObservableCollection<SheduleTime> SheduleTimeCollection
        {
            get
            {
                sheduleTimeCollection = new ObservableCollection<SheduleTime>(DataBaseManager.getAllTime());
                sheduleTimeCollection = new ObservableCollection<SheduleTime>(sheduleTimeCollection.OrderBy(id => id.Id));
                return sheduleTimeCollection;
            }
            set { sheduleTimeCollection = value; OnPropertyChanged("SheduleTimeCollection"); }
        }

        #endregion

        #region Command
        private DelegateCommand addSheduleCommand;
        public DelegateCommand AddSheduleCommand 
        {
            get { return addSheduleCommand ?? (addSheduleCommand = new DelegateCommand(AddClick)); }
        }

        public void AddClick(object obj)
        {
            Add_Schedule add_Schedule = new Add_Schedule();
            add_Schedule.ShowDialog();
           
        }

        private DelegateCommand openSheduleSettingCommand;
        public DelegateCommand OpenSheduleSettigCommand
        {
            get { return openSheduleSettingCommand ?? (openSheduleSettingCommand = new DelegateCommand(OpenSheduleSettig)); }

        }

        public void OpenSheduleSettig(object obj)
        {
            ScheduleSettings sheduleSetting = new ScheduleSettings();
            sheduleSetting.ShowDialog();
        }

        #endregion


    }
}

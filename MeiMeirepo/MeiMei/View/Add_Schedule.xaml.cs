using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MeiMei.ViewModel
{
    /// <summary>
    /// Interaction logic for Add_Schedule.xaml
    /// </summary>
    public partial class Add_Schedule : Window
    {
        private Add_ScheduleVM addSchedule;
        public Add_Schedule()
        {
            InitializeComponent();
            addSchedule = new Add_ScheduleVM();
            DataContext = addSchedule;
        }

        public Add_Schedule(SheduleControlVM sheduleControlVm)
        {
            InitializeComponent();
            addSchedule = new Add_ScheduleVM(sheduleControlVm);
            DataContext = addSchedule;
        }
    }
}

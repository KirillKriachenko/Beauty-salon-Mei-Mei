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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MeiMei.ViewModel;

namespace MeiMei
{
    /// <summary>
    /// Interaction logic for ControlShedule.xaml
    /// </summary>
    public partial class ControlShedule : UserControl
    {
        public  SheduleControlVM SheduleControl;
        private Add_ScheduleVM add_ScheduleVM;
        public ControlShedule(int columnNumber)
        {
            InitializeComponent();
            SheduleControl = new SheduleControlVM(columnNumber);
            DataContext = SheduleControl;
        }
    }
}

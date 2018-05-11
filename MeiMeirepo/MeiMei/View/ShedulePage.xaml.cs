using MeiMei.ViewModel;
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

namespace MeiMei.ViewModel
{
    /// <summary>
    /// Interaction logic for ShedulePage.xaml
    /// </summary>
    public partial class ShedulePage : Page
    {
        public static ShedulePage Instance;
        private ScheduleVM scheduleVM;
        public ShedulePage()
        {
            InitializeComponent();

            scheduleVM = new ScheduleVM(this);
            DataContext = scheduleVM;
            Instance = this;
        }
    }
}

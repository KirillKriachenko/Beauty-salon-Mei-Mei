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
using MeiMei.ViewModel;

namespace MeiMei.View
{
    /// <summary>
    /// Interaction logic for ScheduleSettings.xaml
    /// </summary>
    public partial class ScheduleSettings : Window
    {
        private SettingVM settingVM;
        public ScheduleSettings()
        {
            InitializeComponent();
            settingVM = new SettingVM();
            DataContext = settingVM;
        }

        private void Window_Closed_1(object sender, EventArgs e)
        {
            ScheduleVM.Instance.FindeShedule(ScheduleVM.GridInstance);
        }
    }
}

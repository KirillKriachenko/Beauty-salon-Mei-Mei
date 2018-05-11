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
using MeiMei.Model;
using MeiMei.ViewModel;

namespace MeiMei.View
{
    public partial class Edit_Schedule : Window
    {

        private Edit_SheduleVM editShedule;

        public Edit_Schedule(EmployeeTable employeeTable, Shedule shedule)
        {
            InitializeComponent();
            editShedule = new Edit_SheduleVM(employeeTable, shedule);
            DataContext = editShedule;
        }
    }
}

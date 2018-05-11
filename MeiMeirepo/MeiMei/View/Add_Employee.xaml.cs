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
    /// Interaction logic for Add_Employee.xaml
    /// </summary>
    public partial class Add_Employee : Window
    {
        private Add_EmployeeVM addEmployee;
        public Add_Employee(EmployeeVM employeeVm)
        {
            InitializeComponent();
            addEmployee = new Add_EmployeeVM(employeeVm);
            DataContext = addEmployee;
        }
    }
}

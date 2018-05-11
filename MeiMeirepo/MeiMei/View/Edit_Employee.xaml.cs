﻿using System;
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
    /// Interaction logic for Edit_Employee.xaml
    /// </summary>
    public partial class Edit_Employee : Window
    {
        private EditEmployeeVM editEmployee;
        public Edit_Employee(EmployeeVM employeeVm)
        {
            InitializeComponent();
            editEmployee = new EditEmployeeVM(employeeVm);
            DataContext = editEmployee;
        }
    }
}
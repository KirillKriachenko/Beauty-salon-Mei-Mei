using System.Data.Entity;
using MeiMei.Model;
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

namespace MeiMei
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM mainWindow;
        public MainWindow()
        {
            
            InitializeComponent();
            mainWindow = new MainWindowVM(this);
            DataContext = mainWindow;


            //Logger("Открытие главного окна");
        }

        //public void Logger(String lines)
        //{

        //    //Write the string to a file.append mode is enabled so that the log
        //    //lines get appended to test.txt than wiping content and writing the log

        //    System.IO.StreamWriter file = new System.IO.StreamWriter("e:\\test.txt", true);
        //    file.WriteLine(lines);

        //    file.Close();

        //}
    }
}

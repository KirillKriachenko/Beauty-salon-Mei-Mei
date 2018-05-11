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
    /// Interaction logic for ServisPage.xaml
    /// </summary>
    public partial class ServisPage : Page
    {
        private ServisVM servisVM;   
        public ServisPage()
        {
            InitializeComponent();
            servisVM = new ServisVM();
            DataContext = servisVM;
        }
    }
}

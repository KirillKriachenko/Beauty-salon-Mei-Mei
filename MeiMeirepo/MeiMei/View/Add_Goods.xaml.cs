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
    /// Interaction logic for Add_Goods.xaml
    /// </summary>
    public partial class Add_Goods : Window
    {
        private Add_GoodsVM addGoods;

        public Add_Goods()
        {
            InitializeComponent();
            addGoods = new Add_GoodsVM();
            DataContext = addGoods;
        }
    }
}

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
using Dealership_BD.DealershipDataSetTableAdapters;

namespace Dealership_BD
{
    /// <summary>
    /// Логика взаимодействия для OrdersPageBD.xaml
    /// </summary>
    public partial class OrdersPageBD : Page
    {
        OrdersTableAdapter orders = new OrdersTableAdapter();
        public OrdersPageBD()
        {
            InitializeComponent();
            BD_Orders.ItemsSource = orders.GetData();
        }
    }
}
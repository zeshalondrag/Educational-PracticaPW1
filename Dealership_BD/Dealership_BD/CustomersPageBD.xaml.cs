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
    /// Логика взаимодействия для CustomersPageBD.xaml
    /// </summary>
    public partial class CustomersPageBD : Page
    {
        CustomersTableAdapter customers = new CustomersTableAdapter();
        public CustomersPageBD()
        {
            InitializeComponent();
            BD_Customers.ItemsSource = customers.GetData();
        }
    }
}
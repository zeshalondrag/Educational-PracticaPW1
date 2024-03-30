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

namespace Dealership_BD2
{
    /// <summary>
    /// Логика взаимодействия для BrandsPageBD.xaml
    /// </summary>
    public partial class BrandsPageBD : Page
    {
        private DealershipEntities brands = new DealershipEntities();
        public BrandsPageBD()
        {
            InitializeComponent();
            BD_Brands.ItemsSource = brands.Brands.ToList();
        }
    }
}
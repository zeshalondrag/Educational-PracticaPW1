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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dealership_BD2
{
    /// <summary>
    /// Логика взаимодействия для VehiclesPageBD.xaml
    /// </summary>
    public partial class VehiclesPageBD : Page
    {
        private DealershipEntities vehicles = new DealershipEntities();
        public VehiclesPageBD()
        {
            InitializeComponent();
            BD_Vehicles.ItemsSource = vehicles.Vehicles.ToList();
        }
    }
}
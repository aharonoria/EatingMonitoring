﻿using HealthApp.viewModel;
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

namespace HealthApp
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : UserControl
    { 
        public String Id { get; set; }
        public Menu()
        {
            InitializeComponent();
        }
        //coneection to vmMenu
        public void init()
        {
            
            VMMenu vm = new VMMenu(Id);
            this.DataContext = vm;
        }


    }
}

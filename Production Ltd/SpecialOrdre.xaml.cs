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

namespace Production_Ltd
{
    /// <summary>
    /// Interaction logic for SpecialOrdre.xaml
    /// </summary>
    public partial class SpecialOrdre : Window
    {
        public SpecialOrdre()
        {
            InitializeComponent();
        }

        private void annuller_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
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

namespace HR_Department
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void depList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int k = depList.SelectedIndex+1;
            XmlDataProvider xdp = (XmlDataProvider)this.FindResource("empProvider");
            Binding b = new Binding();
            b.Source = xdp;
            b.XPath = $"employee[@dep=={k}]";
            empList.SetBinding(ListBox.ItemsSourceProperty, b);
        }
    }
}

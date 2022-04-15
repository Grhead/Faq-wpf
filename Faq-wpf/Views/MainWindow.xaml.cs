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
using Faq_wpf.Models;

namespace Faq_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Service.frame = MainFrame;
            MainFrame.Navigate(new Uri("Views/Pages/AuthPage.xaml", UriKind.Relative));
        }
        private void Profile_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Views/Pages/ProfilePage.xaml", UriKind.Relative));
        }

    }
}

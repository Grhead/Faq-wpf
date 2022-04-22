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
using Faq_wpf.Models;

namespace Faq_wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Service.frame = MainFrame;
            //InitialClass.Init();
            MainFrame.Navigate(new Uri("Views/Pages/AuthPage.xaml", UriKind.Relative));
        }

        private void Profile_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (Service.ClientSession.Login != null)
            {
                MainFrame.Navigate(new Uri("Views/Pages/ProfilePage.xaml", UriKind.Relative));
            }
        }

        private void Users_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (Service.ClientSession.Login != null)
            {
                MainFrame.Navigate(new Uri("Views/Pages/ViewUsersPage.xaml", UriKind.Relative));
            }
        }

        private void AvailableTasks_Btn_OnClick(object sender, RoutedEventArgs e)
        {
            if (Service.ClientSession.Login != null)
            {
                MainFrame.Navigate(new Uri("Views/Pages/AvailableTasksPage.xaml", UriKind.Relative));
            }

        }

        private void GetTask_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (Service.ClientSession.Login != null)
            {
                MainFrame.Navigate(new Uri("Views/Pages/GetTaskPage.xaml", UriKind.Relative));
            }
        }

        private void History_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (Service.ClientSession.Login != null)
            {
                MainFrame.Navigate(new Uri("Views/Pages/HistoryPage.xaml", UriKind.Relative));
            }
        }

        private void ChangeStatus_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Views/Pages/ChangeStatusPage.xaml", UriKind.Relative));
        }

        private void FilterTasks_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Views/Pages/FilterPage.xaml", UriKind.Relative));
        }

        private void FindTasks_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Views/Pages/FindPage.xaml", UriKind.Relative));
        }

        private void SetTasks_Btn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("Views/Pages/CreateTaskPage.xaml", UriKind.Relative));
        }
    }
}

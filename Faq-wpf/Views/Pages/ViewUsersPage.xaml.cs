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

namespace Faq_wpf.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewUsersPage.xaml
    /// </summary>
    public partial class ViewUsersPage : Page
    {
        public List<User> ListOfUsersFromDb = new List<User>(Service.db.Users);
        public ViewUsersPage()
        {
            InitializeComponent();
            UsersList.ItemsSource = ListOfUsersFromDb;
        }
    }
}

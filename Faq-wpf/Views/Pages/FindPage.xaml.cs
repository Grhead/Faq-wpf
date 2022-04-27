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
using Microsoft.EntityFrameworkCore;

namespace Faq_wpf.Views.Pages
{
    public partial class FindPage : Page
    {
        public List<TaskX> ListOfTasksFromDb = new List<TaskX>(Service.db.TaskXes.Include(x => x.Status).Include(x => x.UsersSet));
        public List<User> ListOfUsersFromDb = new List<User>(Service.db.Users);

        public FindPage()
        {
            InitializeComponent();
        }

        private void FindBtn_Click(object sender, RoutedEventArgs e)
        {
            var user = EnterLogin.Text;
            var UserLoginGetId = ListOfUsersFromDb.FirstOrDefault(x => x.Login == user)?.Id;
            var UserLoginFind = ListOfTasksFromDb.Where(x => x.UsersGetId == UserLoginGetId).ToList();
            TaskList.ItemsSource = UserLoginFind;
        }
    }
}

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
    /// <summary>
    /// Логика взаимодействия для HistoryPage.xaml
    /// </summary>
    public partial class HistoryPage : Page
    {
        public List<TaskX> ListOfTasksFromDb = new List<TaskX>(Service.db.TaskXes.Where(x => x.UsersGetId == Service.ClientSession.Id).Include(x => x.Status).Include(x => x.UsersSet));

        public HistoryPage()
        {
            InitializeComponent();
            TasksList.ItemsSource = ListOfTasksFromDb;
            var TaskCountGet = Service.db.TaskXes.Count(x => x.UsersGetId == Service.ClientSession.Id);
            var TaskGet = Service.db.TaskXes.Where(x => x.UsersGetId == Service.ClientSession.Id);
            CountTasksUserGet.Text = "Всего Вами решено: " + TaskCountGet.ToString();
        }
    }
}

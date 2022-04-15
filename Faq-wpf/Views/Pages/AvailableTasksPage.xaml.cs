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
    /// Логика взаимодействия для AvailableTasksPage.xaml
    /// </summary>
    public partial class AvailableTasksPage : Page
    {
        public List<TaskX> ListOfTasksFromDb = new List<TaskX>(Service.db.TaskXes.Include(x => x.Status).Where(x => x.StatusId == 1));
        public AvailableTasksPage()
        {
            InitializeComponent();
            TasksList.ItemsSource = ListOfTasksFromDb;
        }
    }
}

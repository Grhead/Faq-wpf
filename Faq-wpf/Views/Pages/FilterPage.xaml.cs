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
    public partial class FilterPage : Page
    {
        public List<TaskX> ListOfTasksFromDb = new List<TaskX>(Service.db.TaskXes.Include(x => x.Status).Include(x => x.UsersSet));
        public FilterPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var start = DateStartBox.SelectedDate;
            var end = DateEndBox.SelectedDate;
            var DateTasks = ListOfTasksFromDb.Where(x => x.Date < end && x.Date > start).ToList();
            TaskList.ItemsSource = DateTasks;
        }
    }
}

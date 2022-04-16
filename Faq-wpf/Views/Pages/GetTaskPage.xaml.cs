using Faq_wpf.Models;
using Microsoft.EntityFrameworkCore;
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

namespace Faq_wpf.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для GetTaskPage.xaml
    /// </summary>
    public partial class GetTaskPage : Page
    {
        public List<TaskX> ListOfTasksFromDb = new List<TaskX>(Service.db.TaskXes.Include(x => x.Status).Where(x => x.StatusId == 1));
        public object item { get; set; }

        public GetTaskPage()
        {
            InitializeComponent();
            TaskList.ItemsSource = ListOfTasksFromDb;
            item = TaskList.SelectedItem;

        }
    }
}

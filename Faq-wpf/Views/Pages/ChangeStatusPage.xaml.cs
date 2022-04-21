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
    public partial class ChangeStatusPage : Page
    {
        public List<TaskX> ListOfTasksFromDb = new List<TaskX>(Service.db.TaskXes.Include(x => x.Status).Where(x => x.StatusId == 2 && x.UsersSetId == Service.ClientSession.Id).Include(x => x.UsersSet));
        private bool ica { get; set; }
        public ChangeStatusPage()
        {
            InitializeComponent();
            TaskList.ItemsSource = ListOfTasksFromDb;
        }

        private void ApplyAnswerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ica == true)
            {
                TaskX temp = TaskList.SelectedItem as TaskX;
                temp.StatusId = 3;
                Service.db.SaveChanges();
                ListOfTasksFromDb = new List<TaskX>(Service.db.TaskXes.Include(x => x.Status).Where(x => x.StatusId == 2 && x.UsersSetId == Service.ClientSession.Id).Include(x => x.UsersSet));
                TaskList.ItemsSource = ListOfTasksFromDb;
            }
        }

        private void IsCorrectAnswer_Checked(object sender, RoutedEventArgs e)
        {
            ica = true;
        }

        private void IsCorrectAnswer_Unchecked(object sender, RoutedEventArgs e)
        {
            ica = false;
        }
    }
}

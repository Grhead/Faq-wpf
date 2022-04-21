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
        public List<TaskX> ListOfTasksFromDb = new List<TaskX>(Service.db.TaskXes.Include(x => x.Status).Where(x => x.StatusId == 1).Include(x => x.UsersSet));
        public TaskX a { get; set; }

        public GetTaskPage()
        {
            InitializeComponent();
            TaskList.ItemsSource = ListOfTasksFromDb;
        }

        private void UserConfirmBtn_Click(object sender, RoutedEventArgs e)
        {
            if (UserGetAnswer.Text != "" && ListOfTasksFromDb.Count != 0)
            {
                string UserAnswer = UserGetAnswer.Text;
                int UserSetAnswer = Service.ClientSession.Id;
                TaskX temp = TaskList.SelectedItem as TaskX;
                var ToPush = Service.db.TaskXes.FirstOrDefault(x => x.Title == temp.Title);
                ToPush.UsersGetId = Service.ClientSession.Id;
                ToPush.Answer = UserGetAnswer.Text;
                ToPush.StatusId = 2;
                Service.db.SaveChanges();
                ListOfTasksFromDb = new List<TaskX>(Service.db.TaskXes.Include(x => x.Status).Where(x => x.StatusId == 1).Include(x => x.UsersSet));
                TaskList.ItemsSource = ListOfTasksFromDb;

            }

        }
    }
}

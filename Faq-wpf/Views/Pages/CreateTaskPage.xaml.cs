using Faq_wpf.Models;
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
    /// Логика взаимодействия для CreateTaskPage.xaml
    /// </summary>
    public partial class CreateTaskPage : Page
    {
        public CreateTaskPage()
        {
            InitializeComponent();
        }

        private void SetTaskButton_Click(object sender, RoutedEventArgs e)
        {
            TaskX NewTask = new TaskX();
            var TaskTitle = TaskTitleBox.Text;
            var check = Service.db.TaskXes.Contains(NewTask);
            NewTask.Title = TaskTitle;
            var TaskDescription = TaskDescriptionBox.Text;
            NewTask.Description = TaskDescription;
            NewTask.StatusId = 1;
            NewTask.UsersSetId = Service.ClientSession.Id;
            Service.db.TaskXes.Add(NewTask);
            Service.db.SaveChanges();
        }
    }
}

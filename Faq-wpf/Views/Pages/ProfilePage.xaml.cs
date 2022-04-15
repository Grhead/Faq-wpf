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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            NameTextBlock.Text = NameTextBlock.Text + Service.ClientSession.FirstName;
            SurNameTextBlock.Text = SurNameTextBlock.Text + Service.ClientSession.SecondName;
            LastNameTextBlock.Text = LastNameTextBlock.Text + Service.ClientSession.LastName;
            LoginTextBlock.Text = LoginTextBlock.Text + Service.ClientSession.Login;
            var TaskCountGet = Service.db.TaskXes.Count(x => x.UsersGetId == Service.ClientSession.Id);
            var TaskCountSet = Service.db.TaskXes.Count(x => x.UsersSetId == Service.ClientSession.Id);
            GetTextBlock.Text = GetTextBlock.Text + TaskCountGet;
            SetTextBlock.Text = SetTextBlock.Text + TaskCountSet;

        }
    }
}

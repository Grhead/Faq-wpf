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
    public partial class RegistrePage : Page
    {
        public RegistrePage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User NewUser = new User();
            string cl= LoginTB.Text;
            User CheckLogin = Service.db.Users.FirstOrDefault(x => x.Login == LoginTB.Text);
            if (CheckLogin == null)
            {
                if (FirstNameTB.Text != null && LastNameTB.Text != null && SecondNameTB.Text != null && LoginTB.Text != null && PasswordTB.Text != null)
                {
                        NewUser.FirstName = FirstNameTB.Text;
                        NewUser.LastName = LastNameTB.Text;
                        NewUser.SecondName = SecondNameTB.Text;
                        NewUser.Login = LoginTB.Text;
                        string fp = PasswordTB.Text;
                        string sp = ConfirmPasswordTB.Text;
                        if (fp == sp)
                        {
                            NewUser.Password = PasswordTB.Text;
                            Service.db.Users.Add(NewUser);
                            Service.db.SaveChanges();
                            Service.frame.Navigate(new AuthPage());
                        }
                        else
                        {
                            MessageBox.Show("Пароли не совпадают");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Вы не заполнили все поля");
                    }
            }
            else
            {
                
                MessageBox.Show("Login занят");

            }
        }
    }
}

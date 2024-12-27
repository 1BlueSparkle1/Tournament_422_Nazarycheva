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
using Tournament_422_Nazarycheva.Components;

namespace Tournament_422_Nazarycheva.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationOrganizerPage.xaml
    /// </summary>
    public partial class RegistrationOrganizerPage : Page
    {
        public RegistrationOrganizerPage()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            Organizer organizer = new Organizer();
            organizer.Surname = SurnameTb.Text;
            organizer.Name = NameTb.Text;
            organizer.Patronymic = PatronymicTb.Text;
            organizer.Phone = PhoneTb.Text;
            organizer.Login = LoginTb.Text;
            organizer.Password = PasswordTb.Text;
            App.db.Organizer.Add(organizer);
            App.db.SaveChanges();
            MessageBox.Show("Вы зарегистрированы");
            Navigations.NextPage(new AutharizationPage());
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.NextPage(new AutharizationPage());
        }
    }
}

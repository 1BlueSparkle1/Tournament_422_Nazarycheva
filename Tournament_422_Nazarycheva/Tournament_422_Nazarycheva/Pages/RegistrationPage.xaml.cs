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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
            RoleCb.ItemsSource = App.db.Role.ToList();
            RoleCb.DisplayMemberPath = "Title";
            RegionCb.ItemsSource = App.db.Region.ToList();
            RegionCb.DisplayMemberPath = "Title";
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            Player player = new Player();
            player.Nickname = NicknameTb.Text;
            player.Phone = PhoneTb.Text;
            Role role = (Role)RoleCb.SelectedItem;
            player.RoleId = role.Id;
            Region region = (Region)RegionCb.SelectedItem;
            player.RegionId = region.Id;
            player.Login = LoginTb.Text;
            player.Password = PasswordTb.Text;
            App.db.Player.Add(player);
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

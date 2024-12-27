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
    /// Логика взаимодействия для AutharizationPage.xaml
    /// </summary>
    public partial class AutharizationPage : Page
    {
        public AutharizationPage()
        {
            InitializeComponent();
        }

        private void RegistrationOrganizerBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.NextPage(new RegistrationOrganizerPage());
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Player> players = App.db.Player.ToList();
            bool find = false;
            bool user = false;

            foreach(var player in players)
            {
                if (player.Login == loginTb.Text)
                {
                    App.thisPlayer = player;
                    find = true;
                    break;
                }
            }
            if (find)
            {
                if (App.thisPlayer.Password == PasswordTb.Text)
                {
                    MessageBox.Show("вы вошли");
                    user = true;
                    Navigations.NextPage(new HomePage());
                    find = false;
                }
                else
                {
                    App.thisPlayer = new Player();
                    find = false;
                }
            }
            else
            {
                App.thisPlayer = new Player();
                find = false;
            }

            IEnumerable<Organizer> organizers = App.db.Organizer.ToList();

            foreach (var organizer in organizers)
            {
                if (organizer.Login == loginTb.Text)
                {
                    App.thisOrganizer = organizer;
                    find = true;
                    break;
                }
            }
            if (find)
            {
                if (App.thisOrganizer.Password == PasswordTb.Text)
                {
                    MessageBox.Show("вы вошли");
                    Navigations.NextPage(new HomePage());
                    find = false;
                    user = true;
                }
                else
                {
                    App.thisOrganizer = new Organizer();
                    find = false;
                }
            }
            else
            {
                App.thisOrganizer = new Organizer();
                find = false;
            }

            if (!user)
            {
                MessageBox.Show("Пользователь не найден");
            }
            else
            {
                user = false;
            }
        }

        private void RegistrationPlayerBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.NextPage(new RegistrationPage());
        }

        private void ViewerBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.NextPage(new HomePage());
        }
    }
}

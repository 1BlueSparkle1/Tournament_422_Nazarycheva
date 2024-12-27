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
    /// Логика взаимодействия для ProfilePlayerPage.xaml
    /// </summary>
    public partial class ProfilePlayerPage : Page
    {
        public ProfilePlayerPage(Player player)
        {
            InitializeComponent();
            NicknameTb.Text = player.Nickname;
            PhoneTb.Text = player.Phone;
            RoleCb.Text = player.Role.Title;
            RegionCb.Text = player.Region.Title;
            LoginTb.Text = player.Login;
            PasswordTb.Text = player.Password;
            if (player.TeamId != null)
            {
                TeamTb.Text = player.Team.Title;
            }
            else
            {
                TeamTb.Text = " - ";
            }
        }
    }
}

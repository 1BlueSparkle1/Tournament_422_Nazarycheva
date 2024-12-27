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
    /// Логика взаимодействия для HomePlayerPage.xaml
    /// </summary>
    public partial class HomePlayerPage : Page
    {
        public HomePlayerPage()
        {
            InitializeComponent();
            Navigations.homePlayerPage = this;
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            App.thisPlayer = new Player();
            Navigations.NextPage(new AutharizationPage());
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.NextPlayerPage(new ProfilePlayerPage(App.thisPlayer));
        }

        private void TournamentBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.NextPlayerPage(new ListAllTournamentPage("All"));
        }
    }
}

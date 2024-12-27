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
    /// Логика взаимодействия для HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
            Navigations.homePage = this;
            Navigations.NextVieverPage(new ListAllTournamentPage("All"));
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.NextPage(new AutharizationPage());
        }

        private void FutureBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.NextVieverPage(new ListAllTournamentPage("Future"));
        }

        private void NowBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.NextVieverPage(new ListAllTournamentPage("Now"));
        }

        private void LastBtn_Click(object sender, RoutedEventArgs e)
        {
            Navigations.NextVieverPage(new ListAllTournamentPage("Last"));
        }
    }
}

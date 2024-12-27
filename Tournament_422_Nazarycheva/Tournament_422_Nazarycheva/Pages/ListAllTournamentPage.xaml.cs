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
using Tournament_422_Nazarycheva.Components.userControls;

namespace Tournament_422_Nazarycheva.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListAllTournamentPage.xaml
    /// </summary>
    public partial class ListAllTournamentPage : Page
    {
        public ListAllTournamentPage(string view)
        {
            InitializeComponent();
            if (view == "All")
            {
                IEnumerable<Tournament> tournaments = App.db.Tournament.ToList();
                foreach(Tournament to in tournaments)
                {
                    TournamentWp.Children.Add(new TournamentUserControl(to));
                }
            }
            else if (view == "Future")
            {
                IEnumerable<Tournament> tournaments = App.db.Tournament.Where(x => x.DatetimeStart > DateTime.Now).ToList();
                foreach (Tournament to in tournaments)
                {
                    TournamentWp.Children.Add(new TournamentUserControl(to));
                }
            }
            else if (view == "Last")
            {
                IEnumerable<Tournament> tournaments = App.db.Tournament.Where(x => x.DatetimeStart < DateTime.Now).ToList();
                foreach (Tournament to in tournaments)
                {
                    TournamentWp.Children.Add(new TournamentUserControl(to));
                }
            }
            else if (view == "Now")
            {
                DateTime date = DateTime.Now.AddMonths(-1);
                IEnumerable<Tournament> tournaments = App.db.Tournament.Where(x => x.DatetimeStart <= DateTime.Now && x.DatetimeStart.Value >= date).ToList();
                foreach (Tournament to in tournaments)
                {
                    TournamentWp.Children.Add(new TournamentUserControl(to));
                }
            }
        }
    }
}

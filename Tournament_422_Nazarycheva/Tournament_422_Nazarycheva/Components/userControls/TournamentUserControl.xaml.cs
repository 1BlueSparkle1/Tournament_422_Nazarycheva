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

namespace Tournament_422_Nazarycheva.Components.userControls
{
    /// <summary>
    /// Логика взаимодействия для TournamentUserControl.xaml
    /// </summary>
    public partial class TournamentUserControl : UserControl
    {
        public TournamentUserControl(Tournament tournament)
        {
            InitializeComponent();
            TitleTb.Text = tournament.Title;
            DataTb.Text = tournament.DatetimeStart.ToString();
            GameTb.Text = tournament.Game.Title;
            CateroryTb.Text = tournament.Category.Title;
            QuantityTb.Text = tournament.QuantityPlayer.ToString();
            MinTb.Text = tournament.MinRank.ToString();
            OrganizerTb.Text = tournament.Organizer.Surname + " " + tournament.Organizer.Name + " " + tournament.Organizer.Patronymic;
        }
    }
}

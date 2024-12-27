using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Tournament_422_Nazarycheva.Components;

namespace Tournament_422_Nazarycheva
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        TournamentDB_422_NazarychevaEntities db = new TournamentDB_422_NazarychevaEntities();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Tournament_422_Nazarycheva.Pages;

namespace Tournament_422_Nazarycheva.Components
{
    internal class Navigations
    {
        public static MainWindow mainWindow;
        public static HomePage homePage;
        public static void NextPage(Page page)
        {
            mainWindow.MainFrame.Navigate(page);
        }

        public static void NextVieverPage(Page page)
        {
            homePage.ViewerFrame.Navigate(page);
        }
    }
}

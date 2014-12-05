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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace Production_Ltd
{
    /// <summary>
    /// Interaction logic for TilføjOrdre.xaml
    /// </summary>
    public partial class TilføjOrdre : Window
    {
        
        
            public TilføjOrdre()
            {
                InitializeComponent();

            }

            private void vælgKunde_DropDownOpened(object sender, EventArgs e)
            {
                Controller controller = new Controller();
                controller.hentKunder();

                foreach (string kundeNavn in controller.hentKunder())
                {
                    if (!vælgKunde.Items.Contains(kundeNavn))
                    {
                    vælgKunde.Items.Add(kundeNavn);
                }
                        
            }
            }

            private void vælgKunde_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

            }

            private void annuller_Click(object sender, RoutedEventArgs e)
            {

            }
    }
}

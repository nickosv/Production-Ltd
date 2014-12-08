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

namespace Production_Ltd
{
    /// <summary>
    /// Interaction logic for TilføjKunde.xaml
    /// </summary>
    public partial class TilføjKunde : Window
    {
        public TilføjKunde()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();

            controller.TilføjKunde( kundenNavn.Text, 
                                    kundeAdresse.Text, 
                                    int.Parse(telefonnummer.Text), 
                                    kundeType.Text);
        }

        
    }
}

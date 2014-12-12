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
    /// Interaction logic for SpecialOrdre.xaml
    /// </summary>
    public partial class SpecialOrdre : Window
    {
        public SpecialOrdre()
        {
            InitializeComponent();
        }

        private void annuller_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void vælgKunde_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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

        private void beregnTid_Click(object sender, RoutedEventArgs e)
        {
            int beregnetTid = 0;

            if (stansemaskine.IsChecked.Value == true)
            {
                beregnetTid = beregnetTid + 5;
            }
            if (svejsning.IsChecked.Value == true)
            {
                beregnetTid = beregnetTid + 10;
            }
            if (bukkemaskine.IsChecked.Value == true)
            {
                beregnetTid = beregnetTid + 10;
            }
            if (laserCutter.IsChecked.Value == true)
            {
                beregnetTid = beregnetTid + 5;
            }
            if (cncFræser.IsChecked.Value == true)
            {
                beregnetTid = beregnetTid + 9;
            }
            if (maskinsaks.IsChecked.Value == true)
            {
                beregnetTid = beregnetTid + 8;
            }
            if (montering.IsChecked.Value == true)
            {
                beregnetTid = beregnetTid + 5;
            }

            MessageBox.Show("Estimeret tid: " + (beregnetTid * int.Parse(antal.Text)) / 60 + " timer");
        }

        private void tilføjOrdre_Click(object sender, RoutedEventArgs e)
        {
            Controller controller = new Controller();

            try
            {
                controller.TilføjSpecialOrdre(vælgKunde.Text,
                                            int.Parse(antal.Text),
                                            Convert.ToDateTime(leveringsDato.Text),
                                            stansemaskine.IsChecked.Value,
                                            svejsning.IsChecked.Value,
                                            bukkemaskine.IsChecked.Value,
                                            montering.IsChecked.Value,
                                            laserCutter.IsChecked.Value,
                                            cncFræser.IsChecked.Value,
                                            maskinsaks.IsChecked.Value);

                MessageBox.Show("Ordre tilføjet");
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
            }
            
            Close();
        }



       

       
    }
}

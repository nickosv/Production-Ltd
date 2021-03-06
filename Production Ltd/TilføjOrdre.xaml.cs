﻿using System;
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
            private void vælgStandard_DropDownOpened(object sender, EventArgs e)
            {
                Controller controller = new Controller();
                controller.hentStandard();

                foreach (string Titel in controller.hentStandard())
                {
                    if (!vælgStandard.Items.Contains(Titel))
                    {
                        vælgStandard.Items.Add(Titel);
                    }

                }
            }



            private void vælgKunde_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

            }

            private void vælgStandard_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

            }

            private void annuller_Click(object sender, RoutedEventArgs e)
            {
            this.Close();
            }

            private void specialordre_Click(object sender, RoutedEventArgs e)
            {
                this.Close();
                new SpecialOrdre().Show();
            }

            
            
            private void TilføjOrdre_Click(object sender, RoutedEventArgs e)
            {
                
                Controller controller = new Controller();                

                controller.TilføjOrdre(int.Parse(antal.Text),
                                        vælgStandard.Text,
                                        Convert.ToDateTime(leveringsDato.Text),
                                        vælgKunde.Text);
                MessageBox.Show("Ordre tilføjet");
                Close();
            }

            private void udregn_Click(object sender, RoutedEventArgs e)
            {
                Controller controller = new Controller();
                controller.regneMetode(vælgStandard.SelectedItem.ToString(), int.Parse(antal.Text));
            }
    }
}

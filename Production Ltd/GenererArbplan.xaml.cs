using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;

namespace Production_Ltd
{
    public partial class GenererArbplan : Window
    {   
        Controller controller = new Controller();
        ObservableCollection<_listeInfo> _listeInfo2 = new ObservableCollection<_listeInfo>();

        public GenererArbplan()
        {
            string hentetOrdreId = controller.HentOrdreID();
            string hentetDeadline = controller.HentDeadline();
            string hentetAntal = controller.HentAntal();
            string hentetKunde = controller.HentKunde();
            string hentetProdukttype = controller.HentProdukttype();
            _listeInfo2.Add(new _listeInfo { OrdreID = hentetOrdreId, Deadline = hentetDeadline, Antal = hentetAntal, Kunde = hentetKunde, Produkttype = hentetProdukttype });

            InitializeComponent();
        }

        public ObservableCollection<_listeInfo> listeInfo
        { get { return _listeInfo2; } }

        private void AddRow_Click(object sender, RoutedEventArgs e)
        {
            _listeInfo2.Add(new _listeInfo { OrdreID = "A New Game", Deadline = "A New Creator", Antal = "A New Publisher" });
        }
    }

    public class _listeInfo
    {
        public string OrdreID { get; set; }
        public string Deadline { get; set; }
        public string Antal { get; set; }
        public string Kunde { get; set; }
        public string Produkttype { get; set; }
        
    }
    
}

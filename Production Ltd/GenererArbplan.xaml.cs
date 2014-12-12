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
            TilføjTilListview();
            InitializeComponent();

        }
        public void TilføjTilListview()
        {
            controller.hentOrdreID();
            for (int i = 0; i < controller.returnlistOrdreID.Count; i++)
            {
                string hentetOrdreId = controller.returnlistOrdreID[i].OrdreID;
                string hentetDeadline = controller.returnlistOrdreID[i].Deadline;
                string hentetAntal = controller.returnlistOrdreID[i].Antal;
                string hentetKunde = controller.returnlistOrdreID[i].Kunde;
                string hentetProdukttype = controller.returnlistOrdreID[i].Produkttype;

                _listeInfo2.Add(new _listeInfo(hentetOrdreId, hentetDeadline, hentetAntal, hentetKunde, hentetProdukttype));
            }
        }
        public ObservableCollection<_listeInfo> listeInfo
        { get { return _listeInfo2; } }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Denne funktion kommer senere");
        }

    }

    public class _listeInfo
    {
        public _listeInfo(string inOrdreID, string inDeadline, string inAntal, string inKunde, string inProdukttype)
        {
            OrdreID = inOrdreID;
            Antal = inAntal;
            Produkttype = inProdukttype;
            Deadline = inDeadline;
            Kunde = inKunde;
        }
        public string OrdreID { get; set; }
        public string Deadline { get; set; }
        public string Antal { get; set; }
        public string Kunde { get; set; }
        public string Produkttype { get; set; }
        
    }
    
}

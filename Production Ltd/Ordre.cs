using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production_Ltd
{
    class Ordre
    {
        public Ordre(string InOrdreID, string inAntal, string inProdukttype, string inDeadline, string inKunde)
        {
            InOrdreID = OrdreID;
            inAntal = Antal;
            inProdukttype = Produkttype;
            inDeadline = Deadline;
            inKunde = Kunde;
        }

        public string OrdreID { get; set; }
        public string Deadline { get; set; }
        public string Antal { get; set; }
        public string Kunde { get; set; }
        public string Produkttype { get; set; }

    }
}

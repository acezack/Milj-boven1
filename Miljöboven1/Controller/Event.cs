﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljöboven1.Controller
{
    [Serializable]
    public class Event
    {
        public String Kommentar { get; set; }

        public String Datum { get; set; }

        public Int32 CrimeID { get; private set; }
        public Int32 EventID { get; set; }
        public Event(string kommentar, int crimeId, int eventId)
        {
            this.EventID = eventId;
            this.Kommentar = kommentar;
            this.Datum = DateTime.Now.ToString("yyyy/MM/dd");
            this.CrimeID = crimeId;
        }

        public string GetKommentar()
        {
            return Kommentar;
        }

        public string GetDatum()
        {
            return Datum;
        }
    }
}

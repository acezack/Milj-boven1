using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljöboven1.Controller
{
    [Serializable]
    public class Event
    {
        public String EventKommentar { get; set; }

        public String EventDatum { get; set; }

        public Int32 EventID { get; set; }

        public Event(string eventKommentar, int eventID)
        {
            this.EventKommentar = eventKommentar;
            this.EventDatum = DateTime.Now.ToString("yyyy/MM/dd");
            this.EventID = eventID;
        }

        public string GetEventKommentar()
        {
            return EventKommentar;
        }

        public string GetEventDatum()
        {
            return EventDatum;
        }

        public int GetEventID()
        {
            return EventID;
        }
    }
}
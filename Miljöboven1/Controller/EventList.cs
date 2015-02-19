using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;

namespace Miljöboven1.Controller
{
    [Serializable]
    public class EventList
    {
        List<Event> eventList;
        public EventList() 
        {
            this.eventList = new List<Event>();
            AddPreviousItemsToList();
        }
        void AddPreviousItemsToList()
        {
            Event ev = new Event("Började projektet", 0);
            eventList.Add(ev);
            ev = new Event("Avslutade projektet", 0);
            eventList.Add(ev);
        }
        public void AddToList(Event ev)
        {
            eventList.Add(ev);
        }

        public string GetEventInfo(int id)
        {
            string svar = eventList[id].EventDatum + "   " + eventList[id].EventKommentar;
            return svar;
        }

        public int getCount()
        {
            return eventList.Count();
        }

        public string getEventInfo(int id)
        {
            return eventList[id].EventDatum + "   " + eventList[id].EventKommentar;
        }
        public Event GetEvent(int id)
        {
            return eventList[id];
        }
        public void RemoveEvent(int eventID)
        {
            eventList.RemoveAt(eventID);
        }
    }
}

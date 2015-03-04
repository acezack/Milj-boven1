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
            //adda det som redan finns (ifrån databasen/filen)
        }
        public void AddToList(Event ev)
        {
            eventList.Add(ev);
        }

        public int getCount()
        {
            return eventList.Count();
        }

        public string GetEventInfo(int eventID, int crimeID)
        {
            foreach (Event ev in eventList)
            {
                if (ev.CrimeID == crimeID && ev.EventID == eventID)
                {
                    return ev.Datum + "   " + ev.Kommentar;
                }
            }
            return "";
        }
        public Event GetEvent(int eventID, int crimeID)
        {
            foreach (Event ev in eventList)
            {
                if (ev.CrimeID == crimeID && ev.EventID == eventID)
                {
                    return ev;
                }
            }
            return null;
        }
        public void RemoveEvent(int eventID, int crimeID)
        {
            foreach (Event ev in eventList)
            {
                if (crimeID == ev.CrimeID && eventID == ev.EventID)
                {
                    eventList.Remove(ev);
                    break;
                }
            }
        }
        public int GetNumberOfEvents(int crimeID)
        {
            int returning = 0;
            foreach (Event ev in eventList)
            {
                if (ev.CrimeID == crimeID)
                {
                    returning++;
                }
            }
            return returning;
        }
    }
}

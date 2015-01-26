using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;

namespace Miljöboven1.Controller
{
    public class EventList
    {
        List<Event> eventList;
        HandläggareForm handläggareForm;
        public EventList(HandläggareForm handläggareForm) 
        {
            this.handläggareForm = handläggareForm;
            this.eventList = new List<Event>();
            AddPreviousItemsToList();
        }
        void AddPreviousItemsToList()
        {
            Event ev = new Event("Började projektet");
            eventList.Add(ev);
            ev = new Event("Avslutade projektet");
            eventList.Add(ev);
        }
        public void AddToList(Event ev)
        {
            eventList.Add(ev);
        }
        public string GetEventInfo(int id)
        {
            string svar = eventList[id].Datum + "   " + eventList[id].Kommentar;
            return svar;
        }
        public int getCount()
        {
            return eventList.Count();
        }
        public string getEventInfo(int id)
        {
            return eventList[id].Datum + "   " + eventList[id].Kommentar;
        }
    }
}

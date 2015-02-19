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
        List<Event> eventList = new List<Event>();

        public void AddEvent(Event newEvent)
        {
            eventList.Add(newEvent);
        }

        public void RemoveEventAt(int eventID)
        {
            eventList.RemoveAt(eventID);
        }

        public int GetCount()
        {
            return eventList.Count();
        }

        public Event GetEvent(int index)
        {
            return eventList[index];
        }

        public string GetEventComment(int index)
        {
            return eventList[index].EventComment;
        }

        public string GetEventDate(int index)
        {
            return eventList[index].EventDate;
        }

        public int GetEventID(int index)
        {
            return eventList[index].EventID;
        }

        public int GetCrimeID(int index)
        {
            return eventList[index].CrimeID;
        }
    }
}

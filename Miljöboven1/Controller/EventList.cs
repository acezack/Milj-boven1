﻿using System;
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
        #region Variables

        List<Event> eventList;

        #endregion

        #region Methods and functions

        public EventList()
        {
            this.eventList = new List<Event>();
        }

        public void AddToList(Event ev)
        {
            eventList.Add(ev);
        }

        public void AddEvent(Event ev)
        {
            eventList.Add(ev);
        }

        public string GetEventDate(int index)
        {
            return eventList[index].EventDate;
        }

        public string GetEventComment(int index)
        {
            return eventList[index].EventComment;
        }
        public int GetCount()
        {
            return eventList.Count();
        }

        public string GetEventInfo(int eventID, int crimeID)
        {
            foreach (Event ev in eventList)
            {
                if (ev.CrimeID == crimeID && ev.EventID == eventID)
                {
                    return ev.EventDate + "   " + ev.EventComment;
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
        public int GetCrimeEventsCount(int crimeID)
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

        public int GetCrimeID(int index)
        {
            return eventList[index].CrimeID;
        }

        #endregion
    }
}

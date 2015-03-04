using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;

namespace Miljöboven1.Controller
{
    public class HandläggareFormController
    {
        HandläggareForm handläggareForm;
        CrimeList crimeList;
        EventList eventList;
        public HandläggareFormController(HandläggareForm handläggarform, CrimeList crimeList, EventList eventList)
        {
            this.eventList = eventList;
            this.handläggareForm = handläggarform;
            this.crimeList = new CrimeList();
            //AddPreviousEventsToEventLists();
            InitForm();
        }

        void InitForm()
        {
            handläggareForm.rtbÄrenedeinformation.Text = "";
            handläggareForm.rtbKommentar.Text = "";
            handläggareForm.lbCrimes.Items.Clear();
            handläggareForm.lbEvent.Items.Clear();
            for (int i = 0; i < crimeList.GetCount(); i++)
            {
                handläggareForm.lbCrimes.Items.Add(crimeList.GetCrimeTitle(i));
            }
        }

        public void CommentSelectedCrime()
        {
            eventList.AddToList(new Event(handläggareForm.rtbKommentar.Text.Trim(), handläggareForm.lbCrimes.SelectedIndex, eventList.GetNumberOfEvents(handläggareForm.lbCrimes.SelectedIndex) + 1));
        }

        public void UpdateSelectedCrime(int i)
        {
            try
            {
                handläggareForm.rtbÄrenedeinformation.Text = crimeList.GetÄrendeInformation(i);
                handläggareForm.lbEvent.Items.Clear();
                for (int j = 0; j < eventList.GetNumberOfEvents(i); j++)
                {
                    handläggareForm.lbEvent.Items.Add(eventList.GetEventInfo(j, i));
                }
            }
            catch (Exception)
            { }
        }

        public void FinishCrime()
        {
            int i = handläggareForm.lbCrimes.SelectedIndex;
            handläggareForm.lbCrimes.Items.RemoveAt(i);
            crimeList.RemoveAt(i);
            handläggareForm.rtbÄrenedeinformation.Text = "";
            handläggareForm.lbEvent.Items.Clear();
        }

        //public void AddPreviousEventsToEventLists()
        //{
        //    for (int i = 0; i < crimeList.GetCount(); i++)
        //    {
        //        crimeList.GetCrime(i).ApplyEventList(handläggareForm);
        //    }
        //}

        public void EditEvents(int eventID, int crimeID, string newComment, string date)
        {
            eventList.GetEvent(eventID, crimeID).Kommentar = newComment;
            eventList.GetEvent(eventID, crimeID).Datum = date;
            UpdateSelectedCrime(crimeID);
        }
        public void RemoveEvent(int eventID, int crimeID)
        {
            eventList.RemoveEvent(eventID, crimeID);
        }
    }
}

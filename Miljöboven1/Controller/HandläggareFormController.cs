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
            testdata();
            InitForm();

        }

        void testdata()
        {
            crimeList.AddCrime(new Crime(1, 0, 2, "miljöbrott", "2014:06:07", "brunstavägen", "brottet är viktigt", "adrian", "super", "098", "ragmar"));
        }

        void InitForm()
        {
            handläggareForm.rtbÄrendeinformation.Text = "";
            handläggareForm.rtbKommentar.Text = "";
            handläggareForm.lbCrimes.Items.Clear();
            handläggareForm.lbxEvent.Items.Clear();
            for (int i = 0; i < crimeList.GetCount(); i++)
            {
                handläggareForm.lbCrimes.Items.Add(crimeList.GetCrimeTitle(i));
            }
        }

        public void CommentSelectedCrime()
        {
            eventList.AddToList(new Event(handläggareForm.rtbKommentar.Text.Trim(), eventList.GetNumberOfEvents(handläggareForm.lbCrimes.SelectedIndex), handläggareForm.lbCrimes.SelectedIndex));
        }

        public void UpdateSelectedCrime(int i)
        {
            try
            {
                handläggareForm.rtbÄrendeinformation.Text = crimeList.GetÄrendeInformation(i);
                handläggareForm.lbxEvent.Items.Clear();
                for (int j = 0; j < eventList.GetNumberOfEvents(i); j++)
                {
                    handläggareForm.lbxEvent.Items.Add(eventList.GetEventInfo(j, i));
                }
            }
            catch (Exception)
            { }
        }

        public void FinishCrime()
        {
            int i = handläggareForm.lbCrimes.SelectedIndex;
            handläggareForm.lbCrimes.Items.RemoveAt(i);
            crimeList.RemoveCrimeAt(i);
            handläggareForm.rtbÄrendeinformation.Text = "";
            handläggareForm.lbxEvent.Items.Clear();
        }

        //public void AddPreviousEventsToEventLists()
        //{
        //    for (int i = 0; i < crimeList.GetCount(); i++)
        //    {
        //        crimeList.GetCrime(i).ApplyEventList(handläggareForm);
        //    }
        //}

        public void EditEvents(int eventID, int crimeID, string newComment)
        {
            eventList.GetEvent(eventID, crimeID).EventComment = newComment;
            UpdateSelectedCrime(crimeID);
        }
        public void EditEvents(int eventID, int crimeID, string newComment, string newDate)
        {
            eventList.GetEvent(eventID, crimeID).EventComment = newComment;
            eventList.GetEvent(eventID, crimeID).EventDate = newDate;
            UpdateSelectedCrime(crimeID);
        }
        public void RemoveEvent(int eventID, int crimeID)
        {
            eventList.RemoveEvent(eventID, crimeID);
        }
    }
}

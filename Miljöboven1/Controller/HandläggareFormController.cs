using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;
using Miljöboven1.Controller;

namespace Miljöboven1.Controller
{
    public class HandläggareFormController
    {
        HandläggareForm handläggareForm;

        CrimeList crimeList;

        EventList eventList;

        string handläggarusername;

        public HandläggareFormController(
            HandläggareForm handläggarform,
            CrimeList crimeList,
            EventList eventList,
            string handläggarusername)
        {
            this.eventList = eventList;
            this.handläggareForm = handläggarform;
            this.crimeList = crimeList;
            this.handläggarusername = handläggarusername;
            InitForm();
        }

        void InitForm()
        {
            handläggareForm.rtbCrimeInfo.Text = "";
            handläggareForm.rtbEvent.Text = "";
            handläggareForm.lbCrimes.Items.Clear();
            handläggareForm.lbxEvent.Items.Clear();
            for (int i = 0; i < crimeList.GetCount(); i++)
            {
                if (crimeList.GetCrime(i).HandläggarUserName == this.handläggarusername)
                    handläggareForm.lbCrimes.Items.Add(crimeList.GetCrimeTitle(i));
            }
        }

        public void AddEvent()
        {
            eventList.AddToList(new Event(handläggareForm.rtbEvent.Text.Trim(), eventList.GetNumberOfEvents(Convert.ToInt32((handläggareForm.lbCrimes.Items[handläggareForm.lbCrimes.SelectedIndex].ToString().Substring(6)))), Convert.ToInt32((handläggareForm.lbCrimes.Items[handläggareForm.lbCrimes.SelectedIndex].ToString().Substring(6)))));
        }

        public void UpdateSelectedCrime(int i)
        {
            try
            {
                handläggareForm.rtbCrimeInfo.Text = crimeList.GetÄrendeInformation(i);
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
            handläggareForm.rtbCrimeInfo.Text = "";
            handläggareForm.lbxEvent.Items.Clear();
        }

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

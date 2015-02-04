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
        public HandläggareFormController(HandläggareForm handläggarform)
        {
            this.handläggareForm = handläggarform;
            this.crimeList = new CrimeList(handläggarform);
            AddCurrentItemsToList();
            AddPreviousEventsToEventLists();
            InitForm();
        }

        void AddCurrentItemsToList()
        {
            crimeList.Add(new Crime(0, DateTime.Now.ToString("MM/dd"), "Göteborgsgatan 23/3c", "Superadde", "Supergatan 1337", "07013371337"));
            crimeList.Add(new Crime(1, DateTime.Now.ToString("MM/dd"), "Stockholmsgatan 29c", "Superkungen", "Superkunggatan 1337", "07013391339"));
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
            crimeList.GetCrime(handläggareForm.lbCrimes.SelectedIndex).eventList.AddToList(new Event(handläggareForm.rtbKommentar.Text.Trim()));
        }

        public void UpdateSelectedCrime(int i)
        {
            try
            {
                handläggareForm.rtbÄrenedeinformation.Text = crimeList.GetCrime(i).GetÄrendeInformation();
                handläggareForm.lbEvent.Items.Clear();
                for (int j = 0; j < crimeList.GetCrime(i).eventList.getCount(); j++)
                {
                    handläggareForm.lbEvent.Items.Add(crimeList.GetCrime(i).eventList.getEventInfo(j));
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

        public void AddPreviousEventsToEventLists()
        {
            for (int i = 0; i < crimeList.GetCount(); i++)
            {
                crimeList.GetCrime(i).ApplyEventList(handläggareForm);
            }
        }

        public void EditEvent(int eventId, int crimeId, string newComment, string date)
        {
            crimeList.GetCrime(crimeId).eventList.GetEvent(eventId).Kommentar = newComment;
            crimeList.GetCrime(crimeId).eventList.GetEvent(eventId).Datum = date;
            UpdateSelectedCrime(crimeId);
        }
    }
}

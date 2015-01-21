using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;

namespace Miljöboven1.Controller
{
    public class CrimeList
    {
        HandläggareForm handläggareForm;
        List<Crime> crimeList;
        

        public CrimeList(HandläggareForm handläggareForm)
        {
            this.handläggareForm = handläggareForm;
            this.crimeList = new List<Crime>();
            AddCurrentItemsToList();
            AddPreviousEventsToEventLists();
            InitForm();
            

        }

        void AddCurrentItemsToList()
        {
            crimeList.Add(new Crime(0, DateTime.Now.ToString("MM/dd"), "Göteborgsgatan 23/3c", "Superadde", "Supergatan 1337", "07013371337"));
            crimeList.Add(new Crime(1, DateTime.Now.ToString("MM/dd"), "Stockholmsgatan 29c", "Superkungen", "Superkunggatan 1337", "07013391339"));
        }
        void AddPreviousEventsToEventLists()
        {
            for (int i = 0; i < crimeList.Count; i++)
            {
                crimeList[i].ApplyEventList(handläggareForm);
                string bitching = "ola luktar bajs";
            }
        }

        void InitForm()
        {
            handläggareForm.rtbÄrenedeinformation.Text = "";
            handläggareForm.rtbKommentar.Text = "";
            handläggareForm.clbÄrendetitlar.Items.Clear();
            handläggareForm.lbEvent.Items.Clear();
            for (int i = 0; i < crimeList.Count; i++)
            {
                handläggareForm.clbÄrendetitlar.Items.Add(crimeList[i].Title);
            }
        }
        public void UpdateSelectedCrime(int i)
        {
            handläggareForm.rtbÄrenedeinformation.Text = crimeList[i].GetÄrendeInformation();
            handläggareForm.lbEvent.Items.Clear();
            for (int j = 0; j < crimeList[i].eventList.getCount(); j++)
            {
                handläggareForm.lbEvent.Items.Add(crimeList[i].eventList.getEventInfo(j));
            }
        }

        
    }
}

﻿using System;
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
            }
        }

        public void UpdateSelectedCrime(int i)
        {
            try
            {
                handläggareForm.rtbÄrenedeinformation.Text = crimeList[i].GetÄrendeInformation();
                handläggareForm.lbEvent.Items.Clear();
                for (int j = 0; j < crimeList[i].eventList.getCount(); j++)
                {
                    handläggareForm.lbEvent.Items.Add(crimeList[i].eventList.getEventInfo(j));
                }
            }
            catch (Exception)
            { }
        }

        public int GetCount()
        { 
            return crimeList.Count; 
        }

        public string GetCrimeTitle(int index)
        {
            return crimeList[index].Title;
        }

        public void FinishCrime()
        {
            int i = handläggareForm.lbCrimes.SelectedIndex;
            handläggareForm.lbCrimes.Items.RemoveAt(i);
                crimeList.RemoveAt(i);
                handläggareForm.rtbÄrenedeinformation.Text = "";
                handläggareForm.lbEvent.Items.Clear();
        }
    }
}

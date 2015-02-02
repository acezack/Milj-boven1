using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;

namespace Miljöboven1.Controller
{
    class HandläggareFormController
    {
        HandläggareForm handläggareForm;
        CrimeList crimeList;
        public HandläggareFormController(HandläggareForm handläggarform)
        {
            this.handläggareForm = handläggarform;
            this.crimeList = new CrimeList(handläggarform);
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
            crimeList[handläggareForm.lbCrimes.SelectedIndex].eventList.AddToList(new Event(handläggareForm.rtbKommentar.Text.Trim()));
        }
    }
}

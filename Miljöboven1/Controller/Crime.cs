using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;

namespace Miljöboven1.Controller
{
    [Serializable]
    public class Crime
    {
        public Int32 CrimeType { get; set; }

        public String Title { get; set; }

        public String Date { get; set; }

        public String Location { get; set; }

        public String CallerName { get; set; }

        public String CallerAddress { get; set; }

        public String CallerNumber { get; set; }

        public String HandläggarUserName { get; set; }

        public Int32 CrimeID { get; set; }

        public EventList eventList;

        public HandläggareForm handläggareForm;

        public Crime(int crimeType,
            string date,
            string location,
            string callerName,
            string callerAddress,
            string callerNumber,
            string handläggarUserName,
            int crimeID)
        {
            this.Title = "brott";
            this.CrimeType = crimeType;
            this.Date = date;
            this.Location = location;
            this.CallerName = callerName;
            this.CallerAddress = callerAddress;
            this.CallerNumber = callerNumber;
            this.HandläggarUserName = handläggarUserName;
            this.CrimeID = crimeID;
            ApplyEventList(handläggareForm);
        }

        public void ApplyEventList(HandläggareForm handläggareForm)
        {
            this.handläggareForm = handläggareForm;
            this.eventList = new EventList();
        }

        public string GetÄrendeInformation()
        {
            return DateTime.Now.ToString("MM/dd") + " " + Location + " " + CallerName + " " + CallerAddress + " " + CallerNumber;
        }
    }
}

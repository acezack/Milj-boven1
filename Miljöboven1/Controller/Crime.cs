using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;

namespace Miljöboven1.Controller
{
    public class Crime
    {
        public Int32 CrimeType { get; set; }
        public String Title { get; set; }
        public String Date { get; set; }
        public String Location { get; set; }
        public String CallerName { get; set; }
        public String CallerAddress { get; set; }
        public String CallerNumber { get; set; }
        public EventList eventList;
        public HandläggareForm handläggareForm;

        public Crime(int crimeType,
            string date,
            string location,
            string callerName,
            string callerAddress,
            string callerNumber)
        {
            this.Title = "brott";
            this.Date = date;
            this.Location = location;
            this.CallerName = callerName;
            this.CallerAddress = callerAddress;
            this.CallerNumber = callerNumber;
        }
        public void ApplyEventList(HandläggareForm handläggareForm)
        {
            this.handläggareForm = handläggareForm;
            this.eventList = new EventList(handläggareForm);
        }
        public string GetÄrendeInformation()
        {
            return DateTime.Now.ToString("MM/dd") + " " + Location + " " + CallerName + " " + CallerAddress + " " + CallerNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljöboven1.Controller
{
    [Serializable]
    public class Event
    {
        public String EventComment { get; set; }

        public String EventDate { get; set; }

        public Int32 EventID { get; set; }

        public Int32 CrimeID { get; set; }

        public Event(string eventComment, int eventID, int crimeID)
        {
            this.EventComment = eventComment;
            this.EventDate = DateTime.Now.ToString("yyyy/MM/dd");
            this.EventID = eventID;
            this.CrimeID = crimeID;
        }
    }
}
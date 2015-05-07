using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miljöboven1.Controller
{
    /// <summary>
    /// Den här klassen är en model utav en händelse knutet till ett brott och används utav hela programmet.
    /// </summary>
    
    [Serializable]
    public class Event
    {
        #region Variables

        public String EventComment { get; set; }

        public String EventDate { get; set; }

        public Int32 EventID { get; set; }

        public Int32 CrimeID { get; set; }

        #endregion

        #region Contructor

        /// <summary>
        /// This class is a model for the events created for each crime.
        /// </summary>
        /// <param name="eventComment">The comment the event has, e.g. "Visited the site and took some pictures for further review."</param>
        /// <param name="eventID">The ID to recognise the event in the eventList (each event gets an individual ID by the program)</param>
        /// <param name="crimeID">Det brotts Id som händelsen skall knytas till</param>
        public Event(string eventComment, int eventID, int crimeID)
        {
            this.EventComment = eventComment;
            this.EventDate = DateTime.Now.ToString("yyyy/MM/dd");
            this.EventID = eventID;
            this.CrimeID = crimeID;
        }

        #endregion
    }
}
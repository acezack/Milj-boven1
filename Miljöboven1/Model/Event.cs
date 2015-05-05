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
        /// Skapar en ny händelse
        /// </summary>
        /// <param name="eventComment">Den kommentar som händelsen får (kan vara t.ex. "påbörjade brottet" eller "rengjorde övre delen av bron")</param>
        /// <param name="eventID">Det Id händelsen kommer få</param>
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
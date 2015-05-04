using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;

namespace Miljöboven1.Controller
{
    /// <summary>
    /// Den här klassen är en model utav ett brott och används utav hela programmet.
    /// </summary>
    
    [Serializable]
    public class Crime
    {
        #region Variables

        public Int32 CrimeType { get; set; }

        public Int32 CrimeID { get; set; }

        public Int32 CrimeStatus { get; set; }      //0=Ej påbörjad
        //1=Påbörjad        
        //2=Slutförd

        public String CrimeTitle { get; set; }

        public String CrimeDate { get; set; }

        public String CrimeLocation { get; set; }

        public String CrimeInformation { get; set; }

        public String CallerName { get; set; }

        public String CallerAddress { get; set; }

        public String CallerNumber { get; set; }

        public String HandläggarUserName { get; set; }

        #endregion

        #region Contstuctor

        public Crime(int crimeType,
            int crimeID,
            int crimeStatus,
            string crimeTitle,
            string crimeDate,
            string crimeLocation,
            string crimeInformation,
            string callerName,
            string callerAddress,
            string callerNumber,
            string handläggarUserName
            )
        {
            this.CrimeType = crimeType;
            this.CrimeID = crimeID;
            this.CrimeStatus = crimeStatus;
            this.CrimeTitle = crimeTitle;
            this.CrimeDate = crimeDate;
            this.CrimeLocation = crimeLocation;
            this.CrimeInformation = crimeInformation;
            this.CallerName = callerName;
            this.CallerAddress = callerAddress;
            this.CallerNumber = callerNumber;
            this.HandläggarUserName = handläggarUserName;
        }

        #endregion
    }
}
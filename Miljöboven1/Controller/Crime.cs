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

        public Int32 CrimeID { get; set; }

        public Int32 CrimeStatus { get; set; }      //0=Ej påbörjad
                                                    //1=Påbörjad
                                                    //2=Slutförd

        public String CrimeTitle { get; set; }

        public String CrimeDate { get; set; }

        public String CrimeLocation { get; set; }

        public String CallerName { get; set; }

        public String CallerAddress { get; set; }

        public String CallerNumber { get; set; }

        public String HandläggarUserName { get; set; }

        public Crime(int crimeType,
            int crimeID,
            int crimeStatus,
            string crimeTitle,
            string crimeDate,
            string crimeLocation,
            string callerName,
            string callerAddress,
            string callerNumber,
            string handläggarUserName)
        {
            this.CrimeType = crimeType;
            this.CrimeID = crimeID;
            this.CrimeStatus = crimeStatus;
            this.CrimeTitle = crimeTitle;
            this.CrimeDate = crimeDate;
            this.CrimeLocation = crimeLocation;
            this.CallerName = callerName;
            this.CallerAddress = callerAddress;
            this.CallerNumber = callerNumber;
            this.HandläggarUserName = handläggarUserName;
        }
    }
}
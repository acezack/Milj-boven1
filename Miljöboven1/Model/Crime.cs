using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;

namespace Miljöboven1.Controller
{
    /// <summary>
    /// This class is a model for the crimes submitted.
    /// </summary>
    
    [Serializable]
    public class Crime
    {
        #region Variables

        public Int32 CrimeType { get; set; }

        public Int32 CrimeID { get; set; }

        public Int32 CrimeStatus { get; set; }      //0 = The crime hasn't begun.
                                                    //1 = The crime has begun.
                                                    //2 = The crime has been completed.

        public String CrimeTitle { get; set; }

        public String CrimeDate { get; set; }

        public String CrimeLocation { get; set; }

        public String CrimeInformation { get; set; }

        public String CallerName { get; set; }

        public String CallerAddress { get; set; }

        public String CallerNumber { get; set; }

        public String HandläggarUserName { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// This class is a model for the crimes submitted.
        /// </summary>
        /// <param name="crimeType">Static 35 for environment crimes.</param>
        /// <param name="crimeID">The ID to recognise the crime.</param>
        /// <param name="crimeStatus">Indicates the current status of the crime.</param>
        /// <param name="crimeTitle">The name given to the crime as decided by the government.</param>
        /// <param name="crimeDate">The date the crime was added to the database.</param>
        /// <param name="crimeLocation">The location of crime as given by the caller.</param>
        /// <param name="crimeInformation">Any other information the caller could give.</param>
        /// <param name="callerName">The name of the caller.</param>
        /// <param name="callerAddress">The address of the caller.</param>
        /// <param name="callerNumber">The phonenumber of the caller.</param>
        /// <param name="handläggarUserName">The investigator that handles the crime.
        /// </param>
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
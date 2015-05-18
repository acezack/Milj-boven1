using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;

namespace Miljöboven1.Controller
{
    /// <summary>
    /// This controller handles a list of the crimes. This list can be used to get the name, address, crimetype and more from the different crimes.
    /// </summary>
    [Serializable]
    public class CrimeList
    {
        #region Variables

        List<Crime> crimeList = new List<Crime>();

        #endregion

        #region Functions and methods

        /// <summary>
        /// Returns how many crimes there is in the list at the moment.
        /// </summary>
        /// <returns>How many crimes there is in the list</returns>
        public int GetCount()
        {
            return crimeList.Count;
        } 

        /// <summary>
        /// Returns the crimes Id using an index
        /// </summary>
        /// <param name="index">The index used to return the crimes Id</param>
        /// <returns>The crimes Id</returns>
        public int GetCrimeID(int index)
        {
            return crimeList[index].CrimeID;
        }

        /// <summary>
        /// Returns the crimes crimestatus.
        /// </summary>
        /// <param name="index">The index used to return the crimes crimestatus.</param>
        /// <returns>The crimes crimestatus</returns>
        public int GetCrimeStatus(int index)
        {
            return crimeList[index].CrimeStatus;
        }

        /// <summary>
        /// Returns the crimes title.
        /// </summary>
        /// <param name="index">The index used to return the crimes title.</param>
        /// <returns>The crimes title</returns>
        public string GetCrimeTitle(int index)
        {
            return crimeList[index].CrimeTitle;
        }

        /// <summary>
        /// Return the crimes date.
        /// </summary>
        /// <param name="index">The index used to return the crimes date.</param>
        /// <returns>The crimes date.</returns>
        public string GetCrimeDate(int index)
        {
            return crimeList[index].CrimeDate;
        }

        /// <summary>
        /// Returns the crimes location
        /// </summary>
        /// <param name="index">The index used to return the crimes crimelocation.</param>
        /// <returns>Brotssplatsen</returns>
        public string GetCrimeLocation(int index)
        {
            return crimeList[index].CrimeLocation;
        }

        /// <summary>
        /// Returns the crimes information (to be shown in investigator form)
        /// </summary>
        /// <param name="index">The index used to return the crimes information.</param>
        /// <returns>The crimes information (address, caller name etc.)</returns>
        public string GetCrimeInformation(int index)
        {
            return crimeList[index].CrimeInformation;
        }

        /// <summary>
        /// Returns the informers name
        /// </summary>
        /// <param name="index">The index used to return the crimes informers name.</param>
        /// <returns>informer name.</returns>
        public string GetCallerName(int index)
        {
            return crimeList[index].CallerName;
        }

        /// <summary>
        /// Returns a crime in the form of a class.
        /// </summary>
        /// <param name="index">Index for which crime it is.</param>
        /// <returns>A crime in the form of a class.</returns>
        public Crime GetCrime(int index)
        {
            return crimeList[index];
        }  

        /// <summary>
        /// Returns the informers address
        /// </summary>
        /// <param name="index">The index used to return the crimes informers address.</param>
        /// <returns>Anmälarens address</returns>
        public string GetCallerAddress(int index)
        {
            return crimeList[index].CallerAddress;
        }

        /// <summary>
        /// Returnerar anmälarens nummer
        /// Returns the informers callernumber
        /// </summary>
        /// <param name="index">The index used to return the crimes informers number.</param>
        /// <returns>anmälarens nummer</returns>
        public string GetCallerNumber(int index)
        {
            return crimeList[index].CallerNumber;
        }

        /// <summary>
        /// Returnerar vilken handläggare som satts till brottet
        /// </summary>
        /// <param name="index">Det index man använder i brottet när man returnerar namnet för den hanläggare som satts till brottet</param>
        /// <returns>Den handläggare som satts till brottet</returns>
        public string GetInvestigatorUserName(int index)
        {
            return crimeList[index].InvestigatorUserName;
        }

        /// <summary>
        /// Returnerar en sträng klar att använda som innehåller anmälarens uppgifter (namn, address och nummer)
        /// </summary>
        /// <param name="id">Det index man använder för att få anmälarens uppgifter ifrån ett speciellt brott</param>
        /// <returns>Anmälarens uppgifter</returns>
        public string GetÄrendeInformation(int id)
        {
            return crimeList[id].CallerName + " " + crimeList[id].CallerAddress + " " + crimeList[id].CallerNumber;
        }

        /// <summary>
        /// Lägger in ett brott i brottslistan.
        /// </summary>
        /// <param name="crime">Det brott som ska läggas in i listan</param>
        public void AddCrime(Crime crime)
        {
            crimeList.Add(crime);
        }

        /// <summary>
        /// Ta bort ett brott ifrån listan.
        /// </summary>
        /// <param name="index">Index för vilket brott man ska ta bort</param>
        public void RemoveCrimeAt(int index)
        {
            crimeList.RemoveAt(index);
        }

        /// <summary>
        /// Ändra den tilldelare handläggaren för brottet
        /// </summary>
        /// <param name="index">Index som bestämmer vilket brott handläggaren ska ändras</param>
        /// <param name="newHandläggare">Den nya handläggaren som blir tilldelad ärendet</param>
        public void ChangeInvestigator(int index, string newHandläggare)
        {
            crimeList[index].InvestigatorUserName = newHandläggare;
        }

        /// <summary>
        /// Ändra brottsstatus (t.ex. till slutförd)
        /// </summary>
        /// <param name="index">Index för att veta vilket brott som brottsstatusen ska ändras för</param>
        /// <param name="newStatus">Ett nummer som representerar vilken status brottet ska få</param>
        public void ChangeCrimeStatus(int index, int newStatus)
        {
            crimeList[index].CrimeStatus = newStatus;
        }

        #endregion

    }
}

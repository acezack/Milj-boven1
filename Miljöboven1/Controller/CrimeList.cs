using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;

namespace Miljöboven1.Controller
{
    /// <summary>
    /// Den här kontrollen hanterar en lista av brotten. Listan av brotten kan användas för att bl.a.
    /// få namn, address och brottstyp ifrån de olika brotten.
    /// </summary>
    [Serializable]
    public class CrimeList
    {
        #region Variables

        List<Crime> crimeList = new List<Crime>();

        #endregion

        #region Functions

        /// <summary>
        /// Returneran hur många brott som just nu finns i listan.
        /// </summary>
        /// <returns>Hur många brott som finns</returns>
        public int GetCount()
        {
            return crimeList.Count;
        }

        /// <summary>
        /// Returnerar ett brott i klassform.
        /// </summary>
        /// <param name="index">Index för vilket brott det är</param>
        /// <returns>Ett brott i klassform</returns>
        public Crime GetCrime(int index)
        {
            return crimeList[index];
        }   

        /// <summary>
        /// Returnerar brottets id med hjälp utav ett visst index
        /// </summary>
        /// <param name="index">Det index man returnerar brottets id med</param>
        /// <returns>Bottets ID</returns>
        public int GetCrimeID(int index)
        {
            return crimeList[index].CrimeID;
        }

        /// <summary>
        /// Returnerar brottets brottsstatus
        /// </summary>
        /// <param name="index">Det index man returnerar brottets brottsstatus med</param>
        /// <returns>Brottets brottsstatus</returns>
        public int GetCrimeStatus(int index)
        {
            return crimeList[index].CrimeStatus;
        }

        /// <summary>
        /// Returnerar brottets titel
        /// </summary>
        /// <param name="index">Det index man returnerar brottets titel med</param>
        /// <returns>Brottets titel</returns>
        public string GetCrimeTitle(int index)
        {
            return crimeList[index].CrimeTitle;
        }

        /// <summary>
        /// Returnerar brottets händelsedatum
        /// </summary>
        /// <param name="index">Det index man returnerar brottets händelsedatum med</param>
        /// <returns>Brottets händelsedatum</returns>
        public string GetCrimeDate(int index)
        {
            return crimeList[index].CrimeDate;
        }

        /// <summary>
        /// Returnerar brottets brottsplats
        /// </summary>
        /// <param name="index">Det index man returnerar brottets plats med</param>
        /// <returns>Brotssplatsen</returns>
        public string GetCrimeLocation(int index)
        {
            return crimeList[index].CrimeLocation;
        }

        /// <summary>
        /// Returnerar brottets information (för visande i handläggarformen)
        /// </summary>
        /// <param name="index">Det index man returnerar brottets information med</param>
        /// <returns>Brottets information (address, nummer etc.)</returns>
        public string GetCrimeInformation(int index)
        {
            return crimeList[index].CrimeInformation;
        }

        /// <summary>
        /// Returnerar anmälarens namn
        /// </summary>
        /// <param name="index">Det index man använder i brottet när man returnerar anmälarens namn</param>
        /// <returns>Anmälarens namn</returns>
        public string GetCallerName(int index)
        {
            return crimeList[index].CallerName;
        }

        /// <summary>
        /// Returnerar anmälarens address
        /// </summary>
        /// <param name="index">Det index man använder i brottet när man returnerar anmälarens address</param>
        /// <returns>Anmälarens address</returns>
        public string GetCallerAddress(int index)
        {
            return crimeList[index].CallerAddress;
        }

        /// <summary>
        /// Returnerar anmälarens nummer
        /// </summary>
        /// <param name="index">Det index man använder i brottet när man returnerar anmälarens nummer</param>
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
        public string GetHandläggarUserName(int index)
        {
            return crimeList[index].HandläggarUserName;
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

        #endregion

        #region Methods

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
        public void ChangeHandläggare(int index, string newHandläggare)
        {
            crimeList[index].HandläggarUserName = newHandläggare;
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

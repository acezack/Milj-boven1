using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;

namespace Miljöboven1.Controller
{
    [Serializable]
    public class CrimeList
    {
        List<Crime> crimeList = new List<Crime>();

        public void AddCrime(Crime crime)
        {
            crimeList.Add(crime);
        }

        public void RemoveCrimeAt(int index)
        {
            crimeList.RemoveAt(index);
        }

        public int GetCount()
        {
            return crimeList.Count;
        }

        public Crime GetCrime(int index)
        {
            return crimeList[index];
        }   

        public int GetCrimeID(int index)
        {
            return crimeList[index].CrimeID;
        }

        public int GetCrimeStatus(int index)
        {
            return crimeList[index].CrimeStatus;
        }

        public string GetCrimeTitle(int index)
        {
            return crimeList[index].CrimeTitle;
        }

        public string GetCrimeDate(int index)
        {
            return crimeList[index].CrimeDate;
        }

        public string GetCrimeLocation(int index)
        {
            return crimeList[index].CrimeLocation;
        }

        public string GetCrimeInformation(int index)
        {
            return crimeList[index].CrimeInformation;
        }

        public string GetCallerName(int index)
        {
            return crimeList[index].CallerName;
        }

        public string GetCallerAddress(int index)
        {
            return crimeList[index].CallerAddress;
        }

        public string GetCallerNumber(int index)
        {
            return crimeList[index].CallerNumber;
        }

        public string GetHandläggarUserName(int index)
        {
            return crimeList[index].HandläggarUserName;
        }
        public string GetÄrendeInformation(int id)
        {
            return crimeList[id].CallerName + " " + crimeList[id].CallerAddress + " " + crimeList[id].CallerNumber;
        }

        public void ChangeHandläggare(int index, string newHandläggare)
        {
            crimeList[index].HandläggarUserName = newHandläggare;
        }

        public void ChangeCrimeStatus(int index, int newStatus)
        {
            crimeList[index].CrimeStatus = newStatus;
        }
    }
}

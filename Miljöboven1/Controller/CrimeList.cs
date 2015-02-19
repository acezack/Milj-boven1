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

        public void Add(Crime crime)
        {
            crimeList.Add(crime);
        }

        public void RemoveAt(int index)
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
    }
}
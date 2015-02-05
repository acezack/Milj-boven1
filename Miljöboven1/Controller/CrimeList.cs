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

        public int GetCount()
        { 
            return crimeList.Count; 
        }

        public string GetCrimeTitle(int index)
        {
            return crimeList[index].Title;
        }

        public Crime GetCrime(int index)
        {
            return crimeList[index];
        }

        public void RemoveAt(int index)
        {
            crimeList.RemoveAt(index);
        }
    }
}

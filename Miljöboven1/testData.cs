using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.Controller;

namespace Miljöboven1
{
    public class TestData
    {
        UserList userList = new UserList();

        CrimeList crimeList = new CrimeList();

        EventList eventList = new EventList();

        public void testData()
        {
            userList.AddUser(new User("admin", "admin", 0, 0));
            userList.AddUser(new User("chef", "chef", 1, 0));
            userList.AddUser(new User("hand", "hand", 2, 0));
            userList.AddUser(new User("hand1", "hand", 2, 1));
            userList.AddUser(new User("milj", "milj", 3, 0));

            if (crimeList.GetCount() == 0)
            {
                crimeList.AddCrime(new Crime(35,
                    0,
                    0, //Ej påbörjad
                    DateTime.Now.ToString("yy") + "-35-" + crimeList.GetCount().ToString("00#"),
                    DateTime.Now.ToString("yyyy/MM/dd"),
                    "Någonstansivärlden 1",
                    "Brottet ID = 0 verkar vem fan bryr HAND1 sig om den här texten Ej påbörjad",
                    "Någon",
                    "Någongana 1",
                    "070137137",
                    "hand1"));
            }
            crimeList.AddCrime(new Crime(35,
                crimeList.GetCount(),
                1, //Påbörjad
                DateTime.Today.ToString("yy") + "-35-" + crimeList.GetCount().ToString("00#"),
                DateTime.Now.ToString("yyyy/MM/dd"),
                "Göteborgsgatan 23/3c",
                "Brottet ID = 1 verkar vem fan bryr HAND sig om den här texten Påbörjad",
                "Superadde",
                "Supergatan 1337",
                "07013371337",
                "hand"));
            crimeList.AddCrime(new Crime(35,
                crimeList.GetCount(),
                0, //Ej påbörjad
                DateTime.Today.ToString("yy") + "-35-" + crimeList.GetCount().ToString("00#"),
                DateTime.Now.ToString("yyyy/MM/dd"),
                "Stockholmsgatan 29c",
                "Brottet ID = 2 verkar vem fan bryr HAND1 sig om den här texten Ej påbörjad",
                "Superungen",
                "Superkunggatan 13",
                "070139139",
                "hand1"));
            crimeList.AddCrime(new Crime(35,
                crimeList.GetCount(),
                2, //Slutförd
                DateTime.Today.ToString("yy") + "-35-" + crimeList.GetCount().ToString("00#"),
                DateTime.Now.ToString("yyyy/MM/dd"),
                "Hejsangatan 2",
                "Brottet ID = 3 verkar vem fan bryr HAND sig om den här texten Slutförd",
                "Apan",
                "SuperVÄGEN 37",
                "070187137",
                "hand"));
            crimeList.AddCrime(new Crime(35,
                crimeList.GetCount(),
                0,
                DateTime.Today.ToString("yy") + "-35-" + crimeList.GetCount().ToString("00#"),
                DateTime.Now.ToString("yyyy/MM/dd"),
                "a",
                "a",
                "a",
                "a",
                "a",
                null));

            if (eventList.GetCount() == 0)
            {
                eventList.AddEvent(new Event("test0", 0, 1));
            }
            eventList.AddToList(new Event("test1", eventList.GetCount(), 1));
            eventList.AddEvent(new Event("test2", eventList.GetCount(), 1));
            eventList.AddEvent(new Event("test3", eventList.GetCount(), 1));
            eventList.AddEvent(new Event("test4", eventList.GetCount(), 1));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Miljöboven1.Controller;
using Miljöboven1.View;

namespace Miljöboven1
{
    public partial class FormMain : Form
    {
        UserList userList = new UserList();

        CrimeList crimeList = new CrimeList();

        EventList eventList = new EventList();

        public FormMain()
        {
            Stream userFileStream;

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
                eventList.AddEvent(new Event("MOTHERFUCKER", 0, 1));
            }
            eventList.AddToList(new Event("MOTHERFUCKER1", eventList.GetCount(), 1));
            eventList.AddEvent(new Event("MOTHERFUCKER2", eventList.GetCount(), 1));
            eventList.AddEvent(new Event("MOTHERFUCKER3", eventList.GetCount(), 1));
            eventList.AddEvent(new Event("MOTHERFUCKER4", eventList.GetCount(), 1));
            eventList.AddEvent(new Event("MOTHERFUCKER5", eventList.GetCount(), 1));
            eventList.AddEvent(new Event("MOTHERFUCKER6", eventList.GetCount(), 1));
            eventList.AddEvent(new Event("MOTHERFUCKER7", eventList.GetCount(), 1));

            //if (File.Exists("1userData.txt"))
            //{
            //    userFileStream = File.OpenRead("1userData.txt");
            //    BinaryFormatter deserializer = new BinaryFormatter();
            //    userList = (UserList)(deserializer.Deserialize(userFileStream));
            //    userFileStream.Close();
            //}
            //else
            //{
            //    userFileStream = File.Create("1userData.txt");
            //    BinaryFormatter serializer = new BinaryFormatter();
            //    serializer.Serialize(userFileStream, userList);
            //    userFileStream.Close();
            //}

            //if (File.Exists("1crimeData.txt"))
            //{
            //    Stream crimeFileStream = File.OpenRead("1crimeData.txt");
            //    BinaryFormatter deserializer = new BinaryFormatter();
            //    crimeList = (CrimeList)(deserializer.Deserialize(crimeFileStream));
            //    crimeFileStream.Close();
            //}
            //else
            //{
            //    Stream crimeFileStream = File.Create("1crimeData.txt");
            //    BinaryFormatter serializer = new BinaryFormatter();
            //    serializer.Serialize(crimeFileStream, crimeList);
            //    crimeFileStream.Close();
            //}

            //if (File.Exists("1eventData.txt"))
            //{
            //    Stream eventFileStream = File.OpenRead("1eventData.txt");
            //    BinaryFormatter deserializer = new BinaryFormatter();
            //    eventList = (EventList)(deserializer.Deserialize(eventFileStream));
            //    eventFileStream.Close();
            //}
            //else
            //{
            //    Stream eventFileStream = File.Create("1eventData.txt");
            //    BinaryFormatter serializer = new BinaryFormatter();
            //    serializer.Serialize(eventFileStream, eventList);
            //    eventFileStream.Close();
            //}

            InitializeComponent();


            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Hide();
            View.InloggningsForm inloggningsForm = new View.InloggningsForm(userList, crimeList, eventList);
            inloggningsForm.ShowDialog();
        }
    }
}
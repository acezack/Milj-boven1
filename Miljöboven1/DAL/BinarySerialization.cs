using Miljöboven1.Controller;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Miljöboven1.DAL
{
    class BinarySerialization
    {
        UserList userList = new UserList();

        CrimeList crimeList = new CrimeList();

        EventList eventList = new EventList();

        /// <summary>
        /// Kollar om filer med data redan finns och om inte skapar nya filer med ny data och om det finns hämtar datan från filerna.
        /// </summary>
        public void Deserialize()
        {
            Stream userFileStream;

            if (File.Exists("1userData.txt"))
            {
                userFileStream = File.OpenRead("1userData.txt");
                BinaryFormatter deserializer = new BinaryFormatter();
                userList = (UserList)(deserializer.Deserialize(userFileStream));
                userFileStream.Close();
            }
            else
            {
                userFileStream = File.Create("1userData.txt");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(userFileStream, userList);
                userFileStream.Close();
            }

            if (File.Exists("1crimeData.txt"))
            {
                Stream crimeFileStream = File.OpenRead("1crimeData.txt");
                BinaryFormatter deserializer = new BinaryFormatter();
                crimeList = (CrimeList)(deserializer.Deserialize(crimeFileStream));
                crimeFileStream.Close();
            }
            else
            {
                Stream crimeFileStream = File.Create("1crimeData.txt");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(crimeFileStream, crimeList);
                crimeFileStream.Close();
            }

            if (File.Exists("1eventData.txt"))
            {
                Stream eventFileStream = File.OpenRead("1eventData.txt");
                BinaryFormatter deserializer = new BinaryFormatter();
                eventList = (EventList)(deserializer.Deserialize(eventFileStream));
                eventFileStream.Close();
            }
            else
            {
                Stream eventFileStream = File.Create("1eventData.txt");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(eventFileStream, eventList);
                eventFileStream.Close();
            }
        }

        /// <summary>
        /// Sparar ner datan till filer på datorn så de kan hämtas nästa gång programmet startas.
        /// </summary>
        public void Serialize()
        {
            Stream userFileStream = File.OpenWrite("1userData.txt");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(userFileStream, userList);
            userFileStream.Close();

            Stream crimeFileStream = File.OpenWrite("1crimeData.txt");
            serializer = new BinaryFormatter();
            serializer.Serialize(crimeFileStream, crimeList);
            crimeFileStream.Close();

            Stream eventFileStream = File.OpenWrite("1eventData.txt");
            serializer = new BinaryFormatter();
            serializer.Serialize(eventFileStream, eventList);
            eventFileStream.Close();
        }
    }
}

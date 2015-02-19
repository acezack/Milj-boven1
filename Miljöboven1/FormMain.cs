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

        public FormMain()
        {
            Stream userFileStream;

            userList.AddUser(new User("admin", "admin", 0, 0));
            userList.AddUser(new User("chef", "chef", 1, 0));
            userList.AddUser(new User("hand", "hand", 2, 0));
            userList.AddUser(new User("milj", "milj", 3, 0));

            if (crimeList.GetCount() == 0)
            {
                crimeList.Add(new Crime(1, 0, 0, (DateTime.Now.ToString("yy") + "-35-" + crimeList.GetCount().ToString("00#")), DateTime.Now.ToString("MM/dd"), "Någonstansivärlden 1", "Någon", "Någongana 1", "070137137", "asd"));
            }
            crimeList.Add(new Crime(0, crimeList.GetCount(), 1, (DateTime.Today.ToString("yy") + "-35-" + crimeList.GetCount().ToString("00#")), DateTime.Now.ToString("yyyy/MM/dd"), "Göteborgsgatan 23/3c", "Superadde", "Supergatan 1337", "07013371337", "asd"));
            crimeList.Add(new Crime(1, crimeList.GetCount(), 0, (DateTime.Today.ToString("yy") + "-35-" + crimeList.GetCount().ToString("00#")), DateTime.Now.ToString("yyyy/MM/dd"), "Stockholmsgatan 29c", "Superungen", "Superkunggatan 13", "070139139", "asd"));
            crimeList.Add(new Crime(2, crimeList.GetCount(), 2, (DateTime.Today.ToString("yy") + "-35-" + crimeList.GetCount().ToString("00#")), DateTime.Now.ToString("yyyy/MM/dd"), "Hejsangatan 2", "Apan", "SuperVÄGEN 37", "070187137", "asd"));

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

            InitializeComponent();


            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.Hide();
            View.InloggningsForm inloggningsForm = new View.InloggningsForm(userList, crimeList);
            inloggningsForm.ShowDialog();
        }
    }
}
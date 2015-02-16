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
    [Serializable]
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

            crimeList.Add(new Crime(0, DateTime.Now.ToString("MM/dd"), "Göteborgsgatan 23/3c", "Superadde", "Supergatan 1337", "07013371337", "asd", 0));
            crimeList.Add(new Crime(1, DateTime.Now.ToString("MM/dd"), "Stockholmsgatan 29c", "Superkungen", "Superkunggatan 1337", "07013391339", "asd", 1));

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
                try
                {
                crimeList = (CrimeList)(deserializer.Deserialize(crimeFileStream));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                crimeFileStream.Close();
            }
            else
            {
                Stream crimeFileStream = File.Create("1crimeData.txt");
                BinaryFormatter serializer = new BinaryFormatter();
                try
                {
                    serializer.Serialize(crimeFileStream, crimeList);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
                crimeFileStream.Close();
            }

            InitializeComponent();

            
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            View.InloggningsForm inloggningsForm = new View.InloggningsForm(userList, crimeList);
            inloggningsForm.ShowDialog();
        }
    }
}
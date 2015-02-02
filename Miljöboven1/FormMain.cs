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

        UserList userList;

        public FormMain()
        {
            Stream fileStream;
            if (File.Exists("data.txt"))
            {
                fileStream = File.OpenRead("data.txt");
            }
            else
            {
                fileStream = File.Create("data.txt");
            }
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fileStream, userList);
            fileStream.Close();
            InitializeComponent();
            userList = new UserList();

            userList.AddUser(new User("admin", "admin", 0, 0));
            userList.AddUser(new User("chef", "chef", 1, 0));
            userList.AddUser(new User("hand", "hand", 2, 0));
            userList.AddUser(new User("milj", "milj", 3, 0));
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            View.InloggningsForm inloggningsForm = new View.InloggningsForm(userList);
            inloggningsForm.ShowDialog();
        }
    }
}
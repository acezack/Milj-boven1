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
using Miljöboven1.DAL;

namespace Miljöboven1
{
    public partial class FormMain : Form
    {
        #region Variables

        UserList userList = new UserList();

        CrimeList crimeList = new CrimeList();

        EventList eventList = new EventList();

        TestData testData = new TestData();

        BinarySerialization binarySerialization = new BinarySerialization();

        #endregion

        #region Constructor

        /// <summary>
        /// Initialiserar programmet och gömmer FormMain-fönstret.
        /// binarySerialization.Deserialize hämtar datan.
        /// </summary>
        public FormMain()
        {
            testData.testData();

            userList = testData.userList;

            crimeList = new CrimeList();

            eventList = new EventList();

            //crimeList.AddCrime(new Crime(35, 0, 1, "15-35-000", "2015-05-26", "s", "s", "s", "s", "s", "hand"));
            //crimeList.AddCrime(new Crime(35, 1, 1, "15-35-001", "2015-05-26", "s", "s", "s", "s", "s", "hand"));

            //eventList.AddEvent(new Event("aaa", 0, 0));
            //eventList.AddEvent(new Event("asd", 1, 1));
            //eventList.AddEvent(new Event("sss", 2, 0));
            //eventList.AddEvent(new Event("ddd", 3, 0));

            //binarySerialization.Deserialize();

            //userList = binarySerialization.userList;

            //crimeList = binarySerialization.crimeList;

            //eventList = binarySerialization.eventList;

            InitializeComponent();

            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Hide();
            View.LoginForm inloggningsForm = new View.LoginForm(userList, crimeList, eventList);
            inloggningsForm.ShowDialog();
        }

        #endregion

        #region FormClosing

        /// <summary>
        /// När programmet stängs ner sparas datan som har använts ner till filer på datorn så att när man öppnar programmet nästa gång har man datan man använde sist.
        /// </summary>
        /// <param name="sender">Objektet som kallade metoden.</param>
        /// <param name="e">Eventargument.</param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            binarySerialization.Serialize();

            e.Cancel = false;
        }

        #endregion
    }
}
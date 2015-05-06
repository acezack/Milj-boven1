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
            //testData.testData();

            binarySerialization.Deserialize();

            userList = binarySerialization.userList;

            crimeList = binarySerialization.crimeList;

            eventList = binarySerialization.eventList;

            InitializeComponent();

            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Hide();
            View.InloggningsForm inloggningsForm = new View.InloggningsForm(userList, crimeList, eventList);
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
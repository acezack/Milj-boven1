using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miljöboven1.Controller;

namespace Miljöboven1.View
{
    /// <summary>
    /// Den här klassen är till för att ändra datumet för en vald händelse.
    /// </summary>
    public partial class HandläggarDatum : Form
    {
        #region Variables

        HandläggareForm handläggareform;
        HandläggareFormController handläggarecontroller;
        int crimeID;
        int eventID;
        string newComment;

        #endregion

        #region Form Component Events

        /// <summary>
        /// Här initieras formen och alla värden sätts till de värden de bör vara för att formen skall kunna ändra datumet för händelsen.
        /// </summary>
        /// <param name="handläggareform">Handläggarformen</param>
        /// <param name="handläggarecontroller">Handläggarkontrollen</param>
        /// <param name="newComment">Den nya kommentaren till händelsen</param>
        /// <param name="eventID">Används för att få rätt händelse</param>
        /// <param name="crimeID">Används för att få rätt brott</param>
        public HandläggarDatum(HandläggareForm handläggareform, HandläggareFormController handläggarecontroller, string newComment, int eventID, int crimeID)
        {
            InitializeComponent();
            this.handläggareform = handläggareform;
            this.handläggarecontroller = handläggarecontroller;
            this.crimeID = crimeID;
            this.eventID = eventID;
            this.newComment = newComment;
        }

        /// <summary>
        /// Här anropas "EditEvents" metoden i handläggarkontrollen och ändrar händelsen med ett nytt datum och en ny kommentar.
        /// Sen stängs fönstret och handläggarformen visas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            handläggarecontroller.EditEvents(eventID, crimeID, newComment, this.dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            this.Hide();
            handläggareform.Show();
        }

        /// <summary>
        /// Om formen stängs göms den och sedan visas handläggarformen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandläggarDatum_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            handläggareform.Show();
        }

        #endregion
    }
}
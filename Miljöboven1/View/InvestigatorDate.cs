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
    /// This form is used to change the date for a specific even.
    /// </summary>
    public partial class InvestigatorDate : Form
    {
        #region Variables

        InvestigatorForm handläggareform;
        InvestigatorController handläggarecontroller;
        int crimeID;
        int eventID;
        string newComment;

        #endregion

        #region Form Component Events

        /// <summary>
        /// The form initiates and all the values is set to the appropriate values so the form can change the date
        /// </summary>
        /// <param name="handläggareform">Investigator form</param>
        /// <param name="handläggarecontroller">Investigator controller</param>
        /// <param name="newComment">The new description for the event</param>
        /// <param name="eventID">Is used to get the correct event</param>
        /// <param name="crimeID">Is used to get the correct crime</param>
        public InvestigatorDate(InvestigatorForm handläggareform, InvestigatorController handläggarecontroller, string newComment, int eventID, int crimeID)
        {
            InitializeComponent();
            this.handläggareform = handläggareform;
            this.handläggarecontroller = handläggarecontroller;
            this.crimeID = crimeID;
            this.eventID = eventID;
            this.newComment = newComment;
        }

        /// <summary>
        /// The "EditEvents" method is called in the Investigator controller and changes the event with a new date and a new desctription.
        /// Then this form closes and investigator form shows.
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
        /// If the form is closed, it is hidden and investigator form is shown
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
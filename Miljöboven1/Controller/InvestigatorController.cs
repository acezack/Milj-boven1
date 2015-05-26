using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Miljöboven1.View;
using Miljöboven1.Controller;

namespace Miljöboven1.Controller
{
    /// <summary>
    /// This class holds most of the investigator logic.
    /// </summary>
    public class InvestigatorController
    {
        #region Variables

        InvestigatorForm investigatorForm;

        CrimeList crimeList;

        EventList eventList;

        String investigatorusername;

        List<int> eventIDlist = new List<int>();

        #endregion

        #region Constructor

        /// <summary>
        /// This contructor initiates investigator controller and sets all the variables to the correct value.
        /// </summary>
        /// <param name="handläggarform">A reference to the investigator form</param>
        /// <param name="crimeList">A reference to the crimelist</param>
        /// <param name="eventList">A reference to the eventlist</param>
        /// <param name="investigatorusername">A reference to the investigator username</param>
        public InvestigatorController(
            InvestigatorForm handläggarform,
            CrimeList crimeList,
            EventList eventList,
            string investigatorusername)
        {
            this.eventList = eventList;
            this.investigatorForm = handläggarform;
            this.crimeList = crimeList;
            this.investigatorusername = investigatorusername;
            InitForm();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Adds the correct crimes into the form from the start.
        /// </summary>
        void InitForm()
        {
            investigatorForm.rtbCrimeInfo.Text = "";
            investigatorForm.rtbEvent.Text = "";
            investigatorForm.lbCrimes.Items.Clear();
            investigatorForm.lbxEvent.Items.Clear();
            for (int i = 0; i < crimeList.GetCount(); i++)
            {
                if (crimeList.GetCrime(i).InvestigatorUserName == this.investigatorusername)
                    investigatorForm.lbCrimes.Items.Add(crimeList.GetCrimeTitle(i));
            }
        }

        /// <summary>
        /// Adds a new event to the selected crime.
        /// </summary>
        public void AddEvent()
        {
            eventList.AddToList(new Event(investigatorForm.rtbEvent.Text.Trim(), eventList.GetCrimeEventsCount(Convert.ToInt32((investigatorForm.lbCrimes.Items[investigatorForm.lbCrimes.SelectedIndex].ToString().Substring(6)))), Convert.ToInt32((investigatorForm.lbCrimes.Items[investigatorForm.lbCrimes.SelectedIndex].ToString().Substring(6)))));
        }

        /// <summary>
        /// Updates the correct information for the selected crime
        /// </summary>
        /// <param name="i">Index for the selected crime</param>
        public void UpdateSelectedCrime(int i)
        {
            try
            {
                investigatorForm.rtbCrimeInfo.Text = crimeList.GetÄrendeInformation(i);
                investigatorForm.lbxEvent.Items.Clear();
                for (int j = 0; j < eventList.GetCrimeEventsCount(i); j++)
                {
                    investigatorForm.lbxEvent.Items.Add(eventList.GetEventInfo(j, i));
                }
            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// Finish a crime and remove it from the investigator crime list and clear the information (since a crime will not be selected afterwards)
        /// </summary>
        public void FinishCrime()
        {
            int i = investigatorForm.lbCrimes.SelectedIndex;
            investigatorForm.lbCrimes.Items.RemoveAt(i);
            crimeList.RemoveCrimeAt(i);
            investigatorForm.rtbCrimeInfo.Text = "";
            investigatorForm.lbxEvent.Items.Clear();
        }

        /// <summary>
        /// Change an event description
        /// </summary>
        /// <param name="eventID">The event one wish to change</param>
        /// <param name="crimeID">The selected crime the event is associated with</param>
        /// <param name="newComment">The new description for the event</param>
        public void EditEvents(int eventID, int crimeID, string newComment)
        {
            eventList.GetEvent(eventID, crimeID).EventComment = newComment;
            UpdateSelectedCrime(crimeID);
        }

        /// <summary>
        /// Changes an events description and the date
        /// </summary>
        /// <param name="eventID">The event one wish to change</param>
        /// <param name="crimeID">The selected crime the event is associated with</param>
        /// <param name="newComment">The new description for the event</param>
        /// <param name="newDate">The new date</param>
        public void EditEvents(int eventID, int crimeID, string newComment, string newDate)
        {
            eventList.GetEvent(eventID, crimeID).EventComment = newComment;
            eventList.GetEvent(eventID, crimeID).EventDate = newDate;
            UpdateSelectedCrime(crimeID);
        }

        /// <summary>
        /// Remove an event from the crime
        /// </summary>
        /// <param name="eventID">The event one wish to remove</param>
        /// <param name="crimeID">The selected crime the event is associated with</param>
        public void RemoveEvent(int eventID, int crimeID)
        {
            eventList.RemoveEvent(eventID, crimeID);
        }

        #endregion
    }
}

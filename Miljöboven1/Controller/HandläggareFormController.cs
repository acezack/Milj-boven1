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
    /// Den här klassen används för att hantera största delen av handläggarens logik.
    /// </summary>
    public class HandläggareFormController
    {
        #region Variables

        InvestigatorForm handläggareForm;

        CrimeList crimeList;

        EventList eventList;

        String handläggarusername;

        #endregion

        #region Constructor

        public HandläggareFormController(
            InvestigatorForm handläggarform,
            CrimeList crimeList,
            EventList eventList,
            string handläggarusername)
        {
            this.eventList = eventList;
            this.handläggareForm = handläggarform;
            this.crimeList = crimeList;
            this.handläggarusername = handläggarusername;
            InitForm();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Lägger till rätt brott och brottsinformation i formen från början
        /// </summary>
        void InitForm()
        {
            handläggareForm.rtbCrimeInfo.Text = "";
            handläggareForm.rtbEvent.Text = "";
            handläggareForm.lbCrimes.Items.Clear();
            handläggareForm.lbxEvent.Items.Clear();
            for (int i = 0; i < crimeList.GetCount(); i++)
            {
                if (crimeList.GetCrime(i).InvestigatorUserName == this.handläggarusername)
                    handläggareForm.lbCrimes.Items.Add(crimeList.GetCrimeTitle(i));
            }
        }

        /// <summary>
        /// Lägger till en händelse för ett valt brott
        /// </summary>
        public void AddEvent()
        {
            eventList.AddToList(new Event(handläggareForm.rtbEvent.Text.Trim(), eventList.GetCrimeEventsCount(Convert.ToInt32((handläggareForm.lbCrimes.Items[handläggareForm.lbCrimes.SelectedIndex].ToString().Substring(6)))), Convert.ToInt32((handläggareForm.lbCrimes.Items[handläggareForm.lbCrimes.SelectedIndex].ToString().Substring(6)))));
        }

        /// <summary>
        /// Uppdaterar rätt information för det brott som väljs ifrån brottslistan
        /// </summary>
        /// <param name="i">Index för det brott som valts</param>
        public void UpdateSelectedCrime(int i)
        {
            try
            {
                handläggareForm.rtbCrimeInfo.Text = crimeList.GetÄrendeInformation(i);
                handläggareForm.lbxEvent.Items.Clear();
                for (int j = 0; j < eventList.GetCrimeEventsCount(i); j++)
                {
                    handläggareForm.lbxEvent.Items.Add(eventList.GetEventInfo(j, i));
                }
            }
            catch (Exception)
            { }
        }

        /// <summary>
        /// Avsluta ett brott och ta bort den ifrån brottslistan samt rensa informationen (då ett brott efter denna metod ej valts)
        /// </summary>
        public void FinishCrime()
        {
            int i = handläggareForm.lbCrimes.SelectedIndex;
            handläggareForm.lbCrimes.Items.RemoveAt(i);
            crimeList.RemoveCrimeAt(i);
            handläggareForm.rtbCrimeInfo.Text = "";
            handläggareForm.lbxEvent.Items.Clear();
        }

        /// <summary>
        /// Ändrar en händelses kommentar
        /// </summary>
        /// <param name="eventID">Den händelse man vill ändra</param>
        /// <param name="crimeID">Det brott händelsen förknippas med</param>
        /// <param name="newComment">Den nya kommentaren till händelsen</param>
        public void EditEvents(int eventID, int crimeID, string newComment)
        {
            eventList.GetEvent(eventID, crimeID).EventComment = newComment;
            UpdateSelectedCrime(crimeID);
        }

        /// <summary>
        /// Ändrar en händelses kommentar och även händelsens datum
        /// </summary>
        /// <param name="eventID">Den händelse man vill ändra</param>
        /// <param name="crimeID">Det brott händelsen förknippas med</param>
        /// <param name="newComment">Den nya kommentaren till händelsen</param>
        /// <param name="newDate">Det nya datumet i sträng format</param>
        public void EditEvents(int eventID, int crimeID, string newComment, string newDate)
        {
            eventList.GetEvent(eventID, crimeID).EventComment = newComment;
            eventList.GetEvent(eventID, crimeID).EventDate = newDate;
            UpdateSelectedCrime(crimeID);
        }

        /// <summary>
        /// Ta bort en händelse ifrån ett brott
        /// </summary>
        /// <param name="eventID">Den händelse man vill ta bort</param>
        /// <param name="crimeID">Det brott händelsen förknippas med</param>
        public void RemoveEvent(int eventID, int crimeID)
        {
            eventList.RemoveEvent(eventID, crimeID);
        }

        #endregion
    }
}

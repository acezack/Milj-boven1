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
    /// This class holds the basic functionality for the investigator form
    /// </summary>
    [Serializable]
    public partial class InvestigatorForm : Form
    {

        #region Variables

        UserList userList;

        CrimeList crimeList;

        EventList eventList;

        LoginForm loginForm;

        InvestigatorController investigatorController;

        List<int> eventIDlist = new List<int>();

        #endregion

        #region Contructor

        /// <summary>
        /// In the constructor the variables is set to the correct values
        /// </summary> 
        /// <param name="userList">The correct list with with users from FormMain</param>
        /// <param name="crimeList">The correct list with crimes from FormMain</param>
        /// <param name="eventList">The correct list with events from FormMain</param>
        /// <param name="handläggarusername">What user logged in to investigator form</param>
        public InvestigatorForm(UserList userList, CrimeList crimeList, EventList eventList, string handläggarusername)
        {
            InitializeComponent();
            this.userList = userList;
            this.eventList = eventList;
            this.crimeList = crimeList;
            this.investigatorController = new InvestigatorController(this, this.crimeList, eventList, handläggarusername);
            loginForm = new LoginForm(userList, crimeList, eventList);
        }

        #endregion

        #region Form Component Events

        /// <summary>
        /// Login form is shown when this form closes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvestigatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }

        /// <summary>
        /// Logic determines whether you want and can add a new event to the selected crime.
        /// It then updates the information shown.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            if (lbCrimes.SelectedIndex != -1)
            {
                if (rtbEvent.Text.Trim() != String.Empty)
                {
                    DialogResult res = MessageBox.Show("Är du helt säker på att du vill lägga till en händelse?", "Bekräfta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        if (crimeList.GetCrimeStatus(Convert.ToInt32((lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6)))) == 0)
                        {
                            crimeList.ChangeCrimeStatus(Convert.ToInt32((lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6))), 1);
                        }
                        investigatorController.AddEvent();
                        investigatorController.UpdateSelectedCrime(Convert.ToInt32((lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6))));
                        rtbEvent.Clear();
                    }
                }
                else
                    MessageBox.Show("Du måste skriva något i kommentar rutan för att uppdatera ett event!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Du måste välja ett brott ifrån listan till vänster först!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Logic determines whether you want and can finish the selected crime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinishCrime_Click(object sender, EventArgs e)
        {
            if (lbCrimes.SelectedIndex != -1)
            {
                DialogResult res = MessageBox.Show("Är du helt säker på att jobbet har slutförts?", "Bekräfta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    if (crimeList.GetCrimeStatus(Convert.ToInt32((lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6)))) == 1)
                    {
                        crimeList.ChangeCrimeStatus(Convert.ToInt32((lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6))), 2);
                    }
                    investigatorController.FinishCrime();
                }
                rtbEvent.Clear();
            }
            else
            {
                MessageBox.Show("Du måste välja ett brott ifrån listan högst upp till vänster först!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Updates the information for the selected crime.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbCrimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            investigatorController.UpdateSelectedCrime(Convert.ToInt32((lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6))));
            eventIDlist = investigatorController.eventIDlist;
        }

        /// <summary>
        /// Selects a crime when one enters the form.
        /// If there is no crimes in the list, no crime is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandläggareForm_Load(object sender, EventArgs e)
        {
            lbCrimes.SelectedIndex = lbCrimes.Items.Count - 1;
        }

        /// <summary>
        /// Logic determines whether you can change an event and if you can, you are asked whether you want to change the date as well. From here you can choose to change date
        /// and event description or just the description. Regardless which you choose the event will change and update, as long as you do not cancel the process during the time.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditEvents_Click(object sender, EventArgs e)
        {
            if (lbxEvent.SelectedIndex != -1)
            {
                    DialogResult res = MessageBox.Show("Bekräfta redigering", "Bekräfta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        DialogResult res2 = MessageBox.Show("Vill du ändra datum?", "Bekräfta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (res2 == DialogResult.Yes)
                        {
                            InvestigatorDate hlg = new InvestigatorDate(this, investigatorController, rtbEvent.Text.Trim(), Convert.ToInt32(lbxEvent.Items[lbxEvent.SelectedIndex].ToString().Substring(6)), Convert.ToInt32(lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6)));
                            hlg.Show();
                            this.Hide();
                        }
                        else
                            investigatorController.EditEvents(eventIDlist[lbxEvent.SelectedIndex], Convert.ToInt32(lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6)), rtbEvent.Text.Trim());
                    }
            }
            else
                MessageBox.Show("Du måste välja en händelse ifrån listan i mitten först!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Logic determines whether you can and want to remove an event from the selected crime. If possible, the event is removes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbxEvent.SelectedIndex != -1)
            {
                DialogResult res = MessageBox.Show("Bekräfta borttagning!", "Bekräfta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    investigatorController.RemoveEvent(Convert.ToInt32(lbxEvent.Items[lbxEvent.SelectedIndex].ToString().Substring(6)), Convert.ToInt32((lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6))));
                }
            }
            else
                MessageBox.Show("Du måste välja en händelse ifrån listan i mitten först!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion
    }
}

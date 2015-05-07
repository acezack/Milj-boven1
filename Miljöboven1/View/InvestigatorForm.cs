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
    /// Den här klassen hanterar den grundliga funktionaliteten för handläggarformen.
    /// </summary>
    [Serializable]
    public partial class InvestigatorForm : Form
    {

        #region Variables

        UserList userList;

        CrimeList crimeList;

        EventList eventList;

        InloggningsForm inloggningsForm;

        HandläggareFormController handläggarController;

        #endregion

        #region Contructor

        /// <summary>
        /// I konstruktorn sätts klassens variabler till de korrekta värdena.
        /// </summary>
        /// <param name="userList">Den korrekta listan med användare ifrån FormMain</param>
        /// <param name="crimeList">Den korrekta listan med brott ifrån FormMain</param>
        /// <param name="eventList">Den korrekta listan med händelser ifrån FormMain</param>
        /// <param name="handläggarusername">Den användare som loggat in på handläggarFormen</param>
        public InvestigatorForm(UserList userList, CrimeList crimeList, EventList eventList, string handläggarusername)
        {
            InitializeComponent();
            this.userList = userList;
            this.eventList = eventList;
            this.crimeList = crimeList;
            this.handläggarController = new HandläggareFormController(this, this.crimeList, eventList, handläggarusername);
            inloggningsForm = new InloggningsForm(userList, crimeList, eventList);
        }

        #endregion

        #region Form Component Events

        /// <summary>
        /// Inloggarformen visas när den här formen stängs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandläggareForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inloggningsForm.Show();
        }

        /// <summary>
        /// Logik körs för att kontrollera att man kan och vill lägga till en ny händelse för det valda brottet.
        /// Sen uppdateras den visade informationen.
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
                        handläggarController.AddEvent();
                        handläggarController.UpdateSelectedCrime(Convert.ToInt32((lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6))));
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
        /// Logik körs för att kontrollera att man kan och vill avsluta det valdra brottet.
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
                    handläggarController.FinishCrime();
                }
                rtbEvent.Clear();
            }
            else
            {
                MessageBox.Show("Du måste välja ett brott ifrån listan högst upp till vänster först!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Uppdaterar det valda brottets information när man väljer ett brott ur listan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbCrimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            handläggarController.UpdateSelectedCrime(Convert.ToInt32((lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6))));
        }

        /// <summary>
        /// Gör så att man valt ett brott när man först kommer in på formen.
        /// Om man inte har några brott så blir det valdra brottets index -1 vilket betyder: inget brott valt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandläggareForm_Load(object sender, EventArgs e)
        {
            lbCrimes.SelectedIndex = lbCrimes.Items.Count - 1;
        }

        /// <summary>
        /// Logik avgör ifall man kan ändra en händelse och kan man det så blir man tillfrågad ifall man vill ändra datum för händelsen. Här ifrån kan man välja att
        /// ändra datumet och kommentaren eller bara kommentaren. Oavsett vilket man väljer kommer händelsen ändras och uppdateras, om man inte avbryter på vägen.
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
                            InvestigatorDate hlg = new InvestigatorDate(this, handläggarController, rtbEvent.Text.Trim(), Convert.ToInt32(lbxEvent.Items[lbxEvent.SelectedIndex].ToString().Substring(6)), Convert.ToInt32(lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6)));
                            hlg.Show();
                            this.Hide();
                        }
                        else
                            handläggarController.EditEvents(Convert.ToInt32(lbxEvent.Items[lbxEvent.SelectedIndex].ToString().Substring(6)), Convert.ToInt32(lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6)), rtbEvent.Text.Trim());
                    }
            }
            else
                MessageBox.Show("Du måste välja en händelse ifrån listan i mitten först!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Logik avgör om man kan och vill ta bort en händelse från ett valt brott. Kan man det så tas händelsen bort.
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
                    handläggarController.RemoveEvent(Convert.ToInt32(lbxEvent.Items[lbxEvent.SelectedIndex].ToString().Substring(6)), Convert.ToInt32((lbCrimes.Items[lbCrimes.SelectedIndex].ToString().Substring(6))));
                }
            }
            else
                MessageBox.Show("Du måste välja en händelse ifrån listan i mitten först!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion
    }
}

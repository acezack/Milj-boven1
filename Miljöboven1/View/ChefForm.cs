﻿using System;
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
    public partial class ChefForm : Form
    {
        #region variables

        UserList userList;

        CrimeList crimeList;

        EventList eventList;

        #endregion

        #region Constructor

        /// <summary>
        /// ChefFormen hanterar allt som chefen ska kunna göra. Här visas alla brott och all information relaterade till dessa.
        /// </summary>
        /// <param name="userList">Listan som hanterar alla användare och även alla metoder som används för användarhantering.</param>
        /// <param name="crimeList">Listan som hanterar alla miljöbrott och även alla metoder som används för miljöbrottshantering.</param>
        /// <param name="eventList">Listan som hanterar alla händelser och även alla metoder som används för händelsehantering.</param>
        public ChefForm(UserList userList, CrimeList crimeList, EventList eventList)
        {
            InitializeComponent();

            this.userList = userList;
            this.crimeList = crimeList;
            this.eventList = eventList;

            cbxCrimeStatus.Items.Add("Alla");
            cbxCrimeStatus.Items.Add("Ej påbörjade");
            cbxCrimeStatus.Items.Add("Påbörjade");
            cbxCrimeStatus.Items.Add("Slutförda");

            cbxHandläggare.Items.Add("Alla");
            for (int index = 0; index < userList.GetCount(); index++)
            {
                if (userList.GetUser(index).UserType == 2)
                {
                    cbxHandläggare.Items.Add(userList.GetUser(index).UserName);
                }
            }

            lbxÄrenden.Items.Clear();

            lbxEvent.Items.Clear();

            for (int index = 0; index < crimeList.GetCount(); index++)
            {
                lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
            }

            cbxHandläggare.SelectedIndex = 0;

            cbxCrimeStatus.SelectedIndex = 0;
        }

        #endregion

        #region ÄrendeStatusComboBox logic

        // Sorterar brotten som visas utefter vad chefen väljer i en ComboBox-meny
        private void cbxÄrendeStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCrimeStatus.SelectedIndex == 0) //Alla brott
            {
                lbxÄrenden.Items.Clear();
                if (cbxHandläggare.SelectedIndex == 0)
                {
                    for (int index = 0; index < crimeList.GetCount(); index++)
                    {
                        lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                    }
                }
                else
                {
                    for (int index = 0; index < crimeList.GetCount(); index++)
                    {
                        if (cbxHandläggare.Items[cbxHandläggare.SelectedIndex].ToString() == crimeList.GetHandläggarUserName(index))
                        {
                            lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                        }
                    }
                }
            }

            if (cbxCrimeStatus.SelectedIndex == 1) // Alla ej påbörjade brott
            {
                lbxÄrenden.Items.Clear();
                if (cbxHandläggare.SelectedIndex != 0)
                {
                    for (int index = 0; index < crimeList.GetCount(); index++)
                    {
                        if (cbxHandläggare.Items[cbxHandläggare.SelectedIndex].ToString() == crimeList.GetHandläggarUserName(index) &&
                            crimeList.GetCrimeStatus(index) == 0)
                        {
                            lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                        }
                    }
                }
                else
                {
                    for (int index = 0; index < crimeList.GetCount(); index++)
                    {
                        if (crimeList.GetCrimeStatus(index) == 0)
                        {
                            lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                        }
                    }
                }
            }

            if (cbxCrimeStatus.SelectedIndex == 2) // Alla påbörjade brott
            {
                lbxÄrenden.Items.Clear();
                if (cbxHandläggare.SelectedIndex != 0)
                {
                    for (int index = 0; index < crimeList.GetCount(); index++)
                    {
                        if (cbxHandläggare.Items[cbxHandläggare.SelectedIndex].ToString() == crimeList.GetHandläggarUserName(index) &&
                            crimeList.GetCrimeStatus(index) == 1)
                        {
                            lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                        }
                    }
                }
                else
                {
                    for (int index = 0; index < crimeList.GetCount(); index++)
                    {
                        if (crimeList.GetCrimeStatus(index) == 1)
                        {
                            lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                        }
                    }
                }
            }

            if (cbxCrimeStatus.SelectedIndex == 3) // Alla slutförda brott
            {
                lbxÄrenden.Items.Clear();
                if (cbxHandläggare.SelectedIndex != 0)
                {
                    for (int index = 0; index < crimeList.GetCount(); index++)
                    {
                        if (cbxHandläggare.Items[cbxHandläggare.SelectedIndex].ToString() == crimeList.GetHandläggarUserName(index) &&
                            crimeList.GetCrimeStatus(index) == 2)
                        {
                            lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                        }
                    }
                }
                else
                {
                    for (int index = 0; index < crimeList.GetCount(); index++)
                    {
                        if (crimeList.GetCrimeStatus(index) == 2)
                        {
                            lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                        }
                    }
                }
            }
            rtbCrimeInformation.Clear();
            lbxEvent.Items.Clear();
        }

        #endregion

        #region HandläggarComboBox logic

        private void cbxHandläggare_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int backIndex = 0; backIndex < userList.GetCount(); backIndex++)
            {
                if (cbxHandläggare.SelectedIndex == backIndex)
                {
                    lbxÄrenden.Items.Clear();
                    if (cbxCrimeStatus.SelectedIndex != 0)
                    {
                        for (int index = 0; index < crimeList.GetCount(); index++)
                        {
                            if (cbxHandläggare.Items[cbxHandläggare.SelectedIndex].ToString() == crimeList.GetHandläggarUserName(index) &&
                                crimeList.GetCrimeStatus(index) == backIndex)
                            {
                                lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                            }
                        }
                    }
                    else
                    {
                        for (int index = 0; index < crimeList.GetCount(); index++)
                        {
                            if (crimeList.GetCrimeStatus(index) == backIndex)
                            {
                                lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region ÄrendeListBox selection-logic

        private void lbxÄrenden_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbCrimeInformation.Text = crimeList.GetCrimeInformation(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));
            tbxCrimeDate.Text = crimeList.GetCrimeDate(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));
            tbxCrimeLocation.Text = crimeList.GetCrimeLocation(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));
            tbxCallerName.Text = crimeList.GetCallerName(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));
            tbxCallerAddress.Text = crimeList.GetCallerAddress(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));
            tbxCallerNumber.Text = crimeList.GetCallerNumber(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));
            tbxHandläggare.Text = crimeList.GetHandläggarUserName(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));
            if (crimeList.GetCrimeStatus(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6))) == 0)
                tbxBrottsstatus.Text = "Ej påbörjad";
            if (crimeList.GetCrimeStatus(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6))) == 1)
                tbxBrottsstatus.Text = "Påbörjad";
            if (crimeList.GetCrimeStatus(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6))) == 2)
                tbxBrottsstatus.Text = "Slutförd";



            lbxEvent.Items.Clear();
            for (int index = 0; index < eventList.GetCount(); index++)
            {
                if (eventList.GetCrimeID(index) == crimeList.GetCrimeID(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6))))
                {
                    lbxEvent.Items.Add(eventList.GetEventDate(index) + "   " + eventList.GetEventComment(index));
                }
            }
        }

        #endregion

        #region AssignCrime

        private void btnAssignCrime_Click(object sender, EventArgs e)
        {
            ChefAssignCrime chefTilldelaÄrendeForm = new ChefAssignCrime(userList, crimeList);
            chefTilldelaÄrendeForm.Show();
        }

        #endregion

        #region FromClosed

        private void ChefForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(userList, crimeList, eventList);
            loginForm.Show();
        }

        #endregion
    }
}
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
    public partial class ChefForm : Form
    {
        UserList userList;

        CrimeList crimeList;

        EventList eventList;

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
                if (userList.GetUser(index).Type == 2)
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

        private void ChefForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InloggningsForm inloggningsForm = new InloggningsForm(userList, crimeList, eventList);
            inloggningsForm.Show();
        }

        private void cbxÄrendeStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCrimeStatus.SelectedIndex == 0)
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
                        if (crimeList.GetCrimeStatus(index) == 0)
                        {
                            lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                        }
                    }
                }
            }

            if (cbxCrimeStatus.SelectedIndex == 1)
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

            if (cbxCrimeStatus.SelectedIndex == 2)
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

            if (cbxCrimeStatus.SelectedIndex == 3)
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

        private void cbxHandläggare_SelectedIndexChanged(object sender, EventArgs e)
        {
            //for (int backIndex = 0; backIndex < userList.GetCount(); backIndex++)
            //{
            //    if (cbxHandläggare.SelectedIndex == backIndex)
            //    {
            //        lbxÄrenden.Items.Clear();
            //        if (cbxCrimeStatus.SelectedIndex != 0)
            //        {
            //            for (int index = 0; index < crimeList.GetCount(); index++)
            //            {
            //                if (cbxHandläggare.Items[cbxHandläggare.SelectedIndex].ToString() == crimeList.GetHandläggarUserName(index) &&
            //                    crimeList.GetCrimeStatus(index) == backIndex)
            //                {
            //                    lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
            //                }
            //            }
            //        }
            //        else
            //        {
            //            for (int index = 0; index < crimeList.GetCount(); index++)
            //            {
            //                if (crimeList.GetCrimeStatus(index) == backIndex)
            //                {
            //                    lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
            //                }
            //            }
            //        }
            //    }
            //}

        }

        private void lbxÄrenden_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbCrimeInformation.Text = crimeList.GetCrimeInformation(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));
            tbxCrimeDate.Text = crimeList.GetCrimeDate(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));
            tbxCrimeLocation.Text = crimeList.GetCrimeLocation(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));
            tbxCallerName.Text = crimeList.GetCallerName(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));
            tbxCallerAddress.Text = crimeList.GetCallerAddress(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));
            tbxCallerNumber.Text = crimeList.GetCallerNumber(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));
            tbxHandläggare.Text = crimeList.GetHandläggarUserName(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6)));

            lbxEvent.Items.Clear();
            for (int index = 0; index < eventList.GetCount(); index++)
            {
                if (eventList.GetCrimeID(index) == crimeList.GetCrimeID(Convert.ToInt32(lbxÄrenden.Items[lbxÄrenden.SelectedIndex].ToString().Substring(6))))
                {
                    lbxEvent.Items.Add(eventList.GetEventDate(index) + "   " + eventList.GetEventComment(index));
                }
            }
        }

        private void btnAssignCrime_Click(object sender, EventArgs e)
        {
            ChefTilldelaÄrendeForm chefTilldelaÄrendeForm = new ChefTilldelaÄrendeForm(userList, crimeList);
            chefTilldelaÄrendeForm.Show();
        }
    }
}
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
    public partial class ChefAssignCrime : Form
    {
        #region Variables

        UserList userList;

        CrimeList crimeList;

        #endregion

        #region Constructor


        public ChefAssignCrime(UserList userList, CrimeList crimeList)
        {
            InitializeComponent();

            this.userList = userList;

            this.crimeList = crimeList;

            for (int index = 0; index < crimeList.GetCount(); index++)
            {
                if (crimeList.GetCrime(index).InvestigatorUserName == null)
                {
                    lbxUnassignedCrimes.Items.Add(crimeList.GetCrime(index).CrimeTitle);
                }
            }

            for (int index = 0; index < userList.GetCount(); index++)
            {
                if (userList.GetType(index) == 2)
                {
                    lbxInvestigator.Items.Add(userList.GetUserName(index));
                }
            }
        }

        #endregion

        #region buttonAssign_Click

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Är du säker på att du vill tilldela valt ärende till vald handläggare?", "Konfirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lbxInvestigator.SelectedIndex == -1 || lbxUnassignedCrimes.SelectedIndex == -1)
                {
                    MessageBox.Show("Du har inte valt ett brott eller en handläggare.", "Fel");
                }
                else
                {
                    for (int index = 0; index < crimeList.GetCount(); index++)
                    {
                        if (crimeList.GetCrimeTitle(index) == lbxUnassignedCrimes.Items[lbxUnassignedCrimes.SelectedIndex].ToString())
                        {
                            for (int index1 = 0; index1 < userList.GetCount(); index1++)
                            {
                                if (userList.GetUserName(index1) == lbxInvestigator.Items[lbxInvestigator.SelectedIndex].ToString())
                                {
                                    crimeList.ChangeInvestigator(index, lbxInvestigator.Items[lbxInvestigator.SelectedIndex].ToString());
                                    lbxUnassignedCrimes.SelectedIndex = -1;
                                    lbxInvestigator.SelectedIndex = -1;

                                    lbxUnassignedCrimes.Items.Clear();

                                    lbxInvestigator.Items.Clear();

                                    for (int index2 = 0; index2 < crimeList.GetCount(); index2++)
                                    {
                                        if (crimeList.GetCrime(index2).InvestigatorUserName == null)
                                        {
                                            lbxUnassignedCrimes.Items.Add(crimeList.GetCrime(index2).CrimeTitle);
                                        }
                                    }

                                    for (int index2 = 0; index2 < userList.GetCount(); index2++)
                                    {
                                        if (userList.GetType(index2) == 2)
                                        {
                                            lbxInvestigator.Items.Add(userList.GetUserName(index2));
                                        }
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}
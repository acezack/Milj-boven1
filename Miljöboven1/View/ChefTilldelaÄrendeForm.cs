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
    public partial class ChefTilldelaÄrendeForm : Form
    {
        UserList userList;

        CrimeList crimeList;

        public ChefTilldelaÄrendeForm(UserList userList, CrimeList crimeList)
        {
            InitializeComponent();

            this.userList = userList;

            this.crimeList = crimeList;

            for (int index = 0; index < crimeList.GetCount(); index++)
            {
                if (crimeList.GetCrime(index).HandläggarUserName == null)
                {
                    lbxUnassignedCrimes.Items.Add(crimeList.GetCrime(index).CrimeTitle);
                }
            }

            for (int index = 0; index < userList.GetCount(); index++)
            {
                if (userList.GetType(index) == 2)
                {
                    lbxHandläggare.Items.Add(userList.GetUserName(index));
                }
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Är du säker på att du vill tilldela valt ärende till vald handläggare?", "Konfirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (lbxHandläggare.SelectedIndex == -1 || lbxUnassignedCrimes.SelectedIndex == -1)
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
                                if (userList.GetUserName(index1) == lbxHandläggare.Items[lbxHandläggare.SelectedIndex].ToString())
                                {
                                    crimeList.ChangeHandläggare(index, lbxHandläggare.Items[lbxHandläggare.SelectedIndex].ToString());
                                    lbxUnassignedCrimes.SelectedIndex = -1;
                                    lbxHandläggare.SelectedIndex = -1;

                                    lbxUnassignedCrimes.Items.Clear();

                                    lbxHandläggare.Items.Clear();

                                    for (int index2 = 0; index2 < crimeList.GetCount(); index2++)
                                    {
                                        if (crimeList.GetCrime(index2).HandläggarUserName == null)
                                        {
                                            lbxUnassignedCrimes.Items.Add(crimeList.GetCrime(index2).CrimeTitle);
                                        }
                                    }

                                    for (int index2 = 0; index2 < userList.GetCount(); index2++)
                                    {
                                        if (userList.GetType(index2) == 2)
                                        {
                                            lbxHandläggare.Items.Add(userList.GetUserName(index2));
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
    }
}
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

        public ChefForm(UserList userList, CrimeList crimeList)
        {
            InitializeComponent();
            this.userList = userList;
            this.crimeList = crimeList;
            cbxÄrendeStatus.Items.Add("Ej påbörjade");
            cbxÄrendeStatus.Items.Add("Påbörjade");
            cbxÄrendeStatus.Items.Add("Slutförda");
            cbxÄrendeStatus.SelectedIndex = 0;
            lbxÄrenden.Items.Clear();
            for (int index = 0; index < crimeList.GetCount(); index++)
            {
                if (crimeList.GetCrimeStatus(index) == 0)
                {
                    lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                }
            }
        }

        private void ChefForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InloggningsForm inloggningsForm = new InloggningsForm(userList, crimeList);
            inloggningsForm.Show();
        }

        private void cbxÄrendeStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxÄrendeStatus.SelectedIndex == 0)
            {
                lbxÄrenden.Items.Clear();
                for (int index = 0; index < crimeList.GetCount(); index++)
                {
                    if (crimeList.GetCrimeStatus(index) == 0)
                    {
                        lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                    }
                }
            }

            if (cbxÄrendeStatus.SelectedIndex == 1)
            {
                lbxÄrenden.Items.Clear();
                for (int index = 0; index < crimeList.GetCount(); index++)
                {
                    if (crimeList.GetCrimeStatus(index) == 1)
                    {
                        lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                    }
                }
            }

            if (cbxÄrendeStatus.SelectedIndex == 2)
            {
                lbxÄrenden.Items.Clear();
                for (int index = 0; index < crimeList.GetCount(); index++)
                {
                    if (crimeList.GetCrimeStatus(index) == 2)
                    {
                        lbxÄrenden.Items.Add(crimeList.GetCrimeTitle(index));
                    }
                }
            }
        }
    }
}
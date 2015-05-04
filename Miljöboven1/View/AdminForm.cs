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
    public partial class AdminForm : Form
    {
        UserList userList;

        CrimeList crimeList;

        EventList eventList;

        /// <summary>
        /// AdminFormen är till för att kunna hantera användare, såsom att lägga till eller ta bort.
        /// </summary>
        /// <param name="userList">Listan som hanterar alla användare och även alla metoder som används för användarhantering.</param>
        /// <param name="crimeList">Listan som hanterar alla miljöbrott och även alla metoder som används för miljöbrottshantering.</param>
        /// <param name="eventList">Listan som hanterar alla händelser och även alla metoder som används för händelsehantering.</param>
        public AdminForm(UserList userList, CrimeList crimeList, EventList eventList)
        {
            InitializeComponent();
            this.userList = userList;
            this.crimeList = crimeList;
            this.eventList = eventList;
            for (int index = 0; index < userList.GetCount(); index++)
			{
                cbxRemoveUser.Items.Add(userList.GetUserName(index));
			}
            cbxAddUserType.Items.Add("Admin");
            cbxAddUserType.Items.Add("Chef");
            cbxAddUserType.Items.Add("Handläggare");
            cbxAddUserType.Items.Add("Miljösamordnare");
        }
        
        // Laddar in AdminFormen och visar två comboboxes men det första valet valt.
        private void AdminForm_Load(object sender, EventArgs e)
        {
            cbxAddUserType.SelectedIndex = 0;
            cbxRemoveUser.SelectedIndex = 0;
        }
        
        // Metoden som lägger till användare.
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vill du lägga till denna användare?", "Lägga till användare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                userList.AddUser(new User(tbxAddUserUserName.Text, tbxAddUserPassword.Text, cbxAddUserType.SelectedIndex, userList.GetCount()));
                tbxAddUserUserName.Clear();
                tbxAddUserPassword.Clear();
                cbxRemoveUser.Items.Clear();
                for (int index = 0; index < userList.GetCount(); index++)
                {
                    cbxRemoveUser.Items.Add(userList.GetUserName(index));
                }
                cbxAddUserType.SelectedIndex = 0;
                cbxRemoveUser.SelectedIndex = 0;
            }
            else
            {
                tbxAddUserUserName.Clear();
                tbxAddUserPassword.Clear();
            }
        }

        // Metoden som tar bort användare.
        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Vill du ta bort denna användare?", "Ta bort användare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                userList.RemoveUser(cbxRemoveUser.SelectedIndex);
                cbxRemoveUser.Items.Clear();
                for (int index = 0; index < userList.GetCount(); index++)
                {
                    cbxRemoveUser.Items.Add(userList.GetUserName(index));
                }
                cbxRemoveUser.SelectedIndex = 0;
            }
            else
            {
                cbxRemoveUser.SelectedIndex = 0;
            }
        }

        // Öppnar InloggninsFormen som programmet förstöppnas in i.
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InloggningsForm inloggningsForm = new InloggningsForm(userList, crimeList, eventList);
            inloggningsForm.Show();
        }
    }
}
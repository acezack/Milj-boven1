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
        #region Variables

        UserList userList;

        CrimeList crimeList;

        EventList eventList;

        #endregion

        #region Constructor

        /// <summary>
        /// The AdminForm is there to handle users, such as adding or removing.
        /// </summary>
        /// <param name="userList">The list that contains models and methods used to handle users.</param>
        /// <param name="crimeList">The list that contains models and methods used to handle crimes.</param>
        /// <param name="eventList">The list that contains models and methods used to handle events.</param>
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

        #endregion

        #region Form_Load

        // Loads the AdminForm and sets the ComboBoxes' index to 0, targetting the first option in the ComboBox.
        private void AdminForm_Load(object sender, EventArgs e)
        {
            cbxAddUserType.SelectedIndex = 0;
            cbxRemoveUser.SelectedIndex = 0;
        }

        #endregion

        #region Functions

        // Funktionen som lägger till användare.
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

        // Funktionen som tar bort användare.
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

        #endregion

        #region FormClosed

        // Öppnar InloggninsFormen som programmet först öppnas in i.
        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InloggningsForm inloggningsForm = new InloggningsForm(userList, crimeList, eventList);
            inloggningsForm.Show();
        }

        #endregion
    }
}
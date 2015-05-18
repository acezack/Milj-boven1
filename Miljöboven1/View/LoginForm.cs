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
using Miljöboven1.DAL;

namespace Miljöboven1.View
{
    public partial class LoginForm : Form
    {
        #region Variables

        UserList userList;

        CrimeList crimeList;

        EventList eventList;

        public Boolean loggedIn;

        #endregion

        #region Constructor

        public LoginForm(UserList userList, CrimeList crimeList, EventList eventList)
        {
            InitializeComponent();
            loggedIn = false;
            this.userList = userList;
            this.crimeList = crimeList;
            this.eventList = eventList;
        }

        #endregion

        #region Logic for logging in
        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < userList.GetCount(); index++)
            {
                if (tbxUsername.Text == userList.GetUserName(index) && tbxPassword.Text == userList.GetPassword(index))
                {
                    if (userList.GetType(index) == 0)//admin
                    {
                        this.Hide();
                        AdminForm adminForm = new AdminForm(userList, crimeList, eventList);
                        adminForm.Show();
                        loggedIn = true;
                        tbxUsername.Clear();
                        tbxPassword.Clear();
                    }

                    else if (userList.GetType(index) == 1)//chef
                    {
                        this.Hide();
                        ChefForm chefForm = new ChefForm(userList, crimeList, eventList);
                        chefForm.Show();
                        loggedIn = true;
                        tbxUsername.Clear();
                        tbxPassword.Clear();
                    }

                    else if (userList.GetType(index) == 2)//handläggare
                    {
                        this.Hide();
                        InvestigatorForm handläggareForm = new InvestigatorForm(userList, crimeList, eventList, tbxUsername.Text);
                        handläggareForm.Show();
                        loggedIn = true;
                        tbxUsername.Clear();
                        tbxPassword.Clear();
                    }

                    else if (userList.GetType(index) == 3)//miljösamordnare
                    {
                        this.Hide();
                        CoordinatorForm miljösamordnareForm = new CoordinatorForm(userList, crimeList, eventList);
                        miljösamordnareForm.Show();
                        loggedIn = true;
                        tbxUsername.Clear();
                        tbxPassword.Clear();
                    }
                }
                if (loggedIn)
                {
                    break;
                }
            }
            if (!loggedIn)
            {
                tbxPassword.Clear();
                MessageBox.Show("Fel användarnamn eller lösenord.");
                tbxPassword.Focus();
            }
        }

        #endregion

        #region OnFormClosed

        private void InloggningsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region KeyDown

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }

        #endregion

        #region ExportToDB

        private void exportToDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccessLayerDBA db = new DataAccessLayerDBA();
            db.SaveMoviesToDatabase();
        }

        #endregion
    }
}
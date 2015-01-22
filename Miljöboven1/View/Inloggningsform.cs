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
    public partial class InloggningsForm : Form
    {
        UserList userList;

        public Boolean loggedIn;
        public InloggningsForm(UserList userList)
        {
            InitializeComponent();
            loggedIn = false;
            this.userList = userList;
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < userList.GetCount(); index++)
            {
                if (tbxUsername.Text == userList.GetUserName(index) && tbxPassword.Text == userList.GetPassword(index))
                {
                    if (userList.GetType(index) == 0)//admin
                    {
                        this.Hide();
                        AdminForm adminForm = new AdminForm(userList);
                        adminForm.Show();
                        loggedIn = true;
                        tbxUsername.Clear();
                        tbxPassword.Clear();
                    }

                    else if(userList.GetType(index) == 1)//chef
                    {
                        this.Hide();
                        ChefForm chefForm = new ChefForm(userList);
                        chefForm.Show();
                        loggedIn = true;
                        tbxUsername.Clear();
                        tbxPassword.Clear();
                    }

                    else if (userList.GetType(index) == 2)//handläggare
                    {
                        this.Hide();
                        HandläggareForm handläggareForm = new HandläggareForm(userList);
                        handläggareForm.Show();
                        loggedIn = true;
                        tbxUsername.Clear();
                        tbxPassword.Clear();
                    }
                    
                    else if (userList.GetType(index) == 3)//miljösamordnare
                    {
                        this.Hide();
                        MiljösamordnareForm miljösamordnareForm = new MiljösamordnareForm(userList);
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
            }
        }
        private void InloggningsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }
    }
}

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
using Miljöboven1.View;

namespace Miljöboven1.View
{
    public partial class InloggningsForm : Form
    {

        public InloggningsForm()
        {
            InitializeComponent();
            userList = new UserList();

            userList.Add(new User("admin", "admin", 0, 0));
            userList.Add(new User("chef", "chef", 1, 0));
            userList.Add(new User("hand", "hand", 2, 0));
            userList.Add(new User("milj", "milj", 3, 0));
        }

        UserList userList;

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < userList.GetCount(); index++)
            {
                if (tbxUsername.Text == userList.GetUserName(index))
                {
                    if (userList.GetType(index) == 0)//admin
                    {
                        this.Hide();
                        AdminForm adminForm = new AdminForm();
                        adminForm.Show();
                    }

                    if (userList.GetType(index) == 1)//chef
                    {
                        ChefForm chefForm = new ChefForm();
                        chefForm.Show();
                    }
                }
            }
        }

        private void tbxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }

        private void InloggningsForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

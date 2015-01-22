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
        public AdminForm(UserList userList)
        {
            InitializeComponent();
            this.userList = userList;
            for (int index = 0; index < userList.GetCount(); index++)
			{
                cbxRemoveUser.Items.Add(userList.GetUserName(index));
			}
            cbxAddUserType.Items.Add("Chef");
            cbxAddUserType.Items.Add("Handläggare");
            cbxAddUserType.Items.Add("Miljösamordnare");
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            cbxAddUserType.SelectedIndex = 0;
            cbxRemoveUser.SelectedIndex = 0;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            userList.Add(new User(tbxAddUserUserName.Text, tbxAddUserPassword.Text, cbxAddUserType.SelectedIndex, userList.GetCount()));
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            userList.RemoveUser(cbxRemoveUser.SelectedIndex);
            cbxRemoveUser.Update();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InloggningsForm inloggningsForm = new InloggningsForm(userList);
            inloggningsForm.Show();
        }
    }
}

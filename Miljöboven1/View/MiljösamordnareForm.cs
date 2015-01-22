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
    public partial class MiljösamordnareForm : Form
    {
        UserList userList;
        public MiljösamordnareForm(UserList userList)
        {
            InitializeComponent();
            this.userList = userList;
        }

        private void MiljösamordnareForm_Load(object sender, EventArgs e)
        {

        }

        private void MiljösamordnareForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InloggningsForm inloggningsForm = new InloggningsForm(userList);
            inloggningsForm.Show();
        }
    }
}
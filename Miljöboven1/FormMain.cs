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

namespace Miljöboven1
{
    public partial class FormMain : Form
    {

        UserList userList;

        public FormMain()
        {
            InitializeComponent();
            userList = new UserList();

            userList.Add(new User("admin", "admin", 0, 0));
            userList.Add(new User("chef", "chef", 1, 0));
            userList.Add(new User("hand", "hand", 2, 0));
            userList.Add(new User("milj", "milj", 3, 0));
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Minimized;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            View.InloggningsForm inloggningsForm = new View.InloggningsForm(userList);
            inloggningsForm.ShowDialog();
        }
    }
}
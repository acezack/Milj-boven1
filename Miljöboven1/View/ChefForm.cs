using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miljöboven1.View
{
    public partial class ChefForm : Form
    {
        Controller.UserList userList;
        public ChefForm(Controller.UserList userList)
        {
            InitializeComponent();
            this.userList = userList;
        }

        private void ChefForm_Load(object sender, EventArgs e)
        {

        }

        private void ChefForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void ChefForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InloggningsForm inloggningsForm = new InloggningsForm(userList);
            inloggningsForm.Show();
        }
    }
}

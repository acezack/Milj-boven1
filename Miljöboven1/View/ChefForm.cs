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
        }

        private void ChefForm_Load(object sender, EventArgs e)
        {

        }

        private void ChefForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void ChefForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InloggningsForm inloggningsForm = new InloggningsForm(userList, crimeList);
            inloggningsForm.Show();
        }
    }
}

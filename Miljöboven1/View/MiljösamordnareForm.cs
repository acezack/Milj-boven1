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

        CrimeList crimeList;

        public MiljösamordnareForm(UserList userList, CrimeList crimeList)
        {
            InitializeComponent();
            this.userList = userList;
            this.crimeList = crimeList;
        }

        private void MiljösamordnareForm_Load(object sender, EventArgs e)
        {

        }

        private void MiljösamordnareForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InloggningsForm inloggningsForm = new InloggningsForm(userList, crimeList);
            inloggningsForm.Show();
        }
    }
}
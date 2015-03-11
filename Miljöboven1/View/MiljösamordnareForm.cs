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

        EventList eventList;

        public MiljösamordnareForm(UserList userList, CrimeList crimeList, EventList eventList)
        {
            InitializeComponent();
            this.userList = userList;
            this.crimeList = crimeList;
            this.eventList = eventList;
        }

        private void MiljösamordnareForm_Load(object sender, EventArgs e)
        {

        }

        private void MiljösamordnareForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InloggningsForm inloggningsForm = new InloggningsForm(userList, crimeList, eventList);
            inloggningsForm.Show();
        }

        private void btnAddCrime_Click(object sender, EventArgs e)
        {
            crimeList.AddCrime(new Crime(35,
                crimeList.GetCount(),
                0,
                DateTime.Today.ToString("yy") + "-35-" + crimeList.GetCount().ToString("00#"),
                DateTime.Now.ToString("yyyy/MM/dd"),
                tbxCrimeLocation.Text,
                tbxCrimeInformation.Text,
                tbxCallerName.Text,
                tbxCallerAddress.Text,
                tbxCallerName.Text,
                null));
        }
    }
}
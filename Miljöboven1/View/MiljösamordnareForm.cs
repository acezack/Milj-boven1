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
        #region Variables

        UserList userList;

        CrimeList crimeList;

        EventList eventList;

        #endregion

        #region Constructor

        public MiljösamordnareForm(UserList userList, CrimeList crimeList, EventList eventList)
        {
            InitializeComponent();
            this.userList = userList;
            this.crimeList = crimeList;
            this.eventList = eventList;
        }

        #endregion

        #region Form_Load

        private void MiljösamordnareForm_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region FormClosed

        private void MiljösamordnareForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InloggningsForm inloggningsForm = new InloggningsForm(userList, crimeList, eventList);
            inloggningsForm.Show();
        }

        #endregion

        #region Functions

        private void btnAddCrime_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Är du säker på att du vill lägga till detta ärende?", "Lägga till ärende", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                    tbxCallerNumber.Text,
                    null));

                tbxCrimeLocation.Clear();
                tbxCrimeInformation.Clear();
                tbxCallerName.Clear();
                tbxCallerAddress.Clear();
                tbxCallerNumber.Clear();
            }
        }

        private void tbxClearText_Click(object sender, EventArgs e)
        {
            tbxCrimeLocation.Clear();
            tbxCrimeInformation.Clear();
            tbxCallerName.Clear();
            tbxCallerAddress.Clear();
            tbxCallerNumber.Clear();
        }

        #endregion
    }
}
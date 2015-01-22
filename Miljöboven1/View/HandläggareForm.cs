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
    public partial class HandläggareForm : Form
    {
        UserList userList;
        CrimeList crimeList;
        InloggningsForm inloggningsForm;
        
        public HandläggareForm(UserList userList)
        {
            InitializeComponent();
            this.crimeList = new CrimeList(this);
            this.userList = userList;
            inloggningsForm = new InloggningsForm(userList);
        }

        private void HandläggareForm_Load(object sender, EventArgs e)
        {

        }

        private void HandläggareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void clbÄrendetitlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            crimeList.UpdateSelectedCrime(clbÄrendetitlar.SelectedIndex);
        }

        private void HandläggareForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            InloggningsForm inloggningsForm = new InloggningsForm(userList);
            inloggningsForm.Show();
        }
    }
}

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
        View.InloggningsForm inloggningsForm;
        CrimeList crimeList;
        
        public HandläggareForm()
        {
            InitializeComponent();
            this.crimeList = new CrimeList(this);
        }

        private void HandläggareForm_Load(object sender, EventArgs e)
        {

        }

        private void HandläggareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            inloggningsForm.Show();
        }

        private void clbÄrendetitlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            crimeList.UpdateSelectedCrime(clbÄrendetitlar.SelectedIndex);
        }
    }
}

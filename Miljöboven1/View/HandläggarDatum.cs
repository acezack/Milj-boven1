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
    public partial class HandläggarDatum : Form
    {
        HandläggareForm handläggareform;
        HandläggareFormController handläggarecontroller;
        public HandläggarDatum(HandläggareForm handläggareform, HandläggareFormController handläggarecontroller)
        {
            InitializeComponent();
            this.handläggareform = handläggareform;
            this.handläggarecontroller = handläggarecontroller;
        }

        private void HandläggarDatum_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //handläggarecontroller.EditEvents(handläggareform.lbEvent.SelectedIndex, handläggareform.lbCrimes.SelectedIndex, handläggareform.rtbKommentar.Text, this.dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            this.Hide();
        }
    }
}
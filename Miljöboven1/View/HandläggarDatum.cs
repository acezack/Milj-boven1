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
        int crimeID;
        int eventID;
        string newComment;
        public HandläggarDatum(HandläggareForm handläggareform, HandläggareFormController handläggarecontroller, string newComment, int eventID, int crimeID)
        {
            InitializeComponent();
            this.handläggareform = handläggareform;
            this.handläggarecontroller = handläggarecontroller;
            this.crimeID = crimeID;
            this.eventID = eventID;
            this.newComment = newComment;
        }

        private void HandläggarDatum_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            handläggarecontroller.EditEvents(eventID, crimeID, newComment, this.dateTimePicker1.Value.ToString("yyyy/MM/dd"));
            this.Hide();
            handläggareform.Show();
        }

        private void HandläggarDatum_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            handläggareform.Show();
        }
    }
}
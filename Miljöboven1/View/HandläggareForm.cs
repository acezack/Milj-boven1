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
        HandläggareFormController handläggarcontroller;

        public HandläggareForm(UserList userList)
        {
            InitializeComponent();
            this.crimeList = new CrimeList(this);
            this.userList = userList;
            this.handläggarcontroller = new HandläggareFormController(this);
            inloggningsForm = new InloggningsForm(userList);
        }

        private void HandläggareForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            inloggningsForm.Show();
        }

        private void btnSkicka_Click(object sender, EventArgs e)
        {
            if (lbCrimes.SelectedIndex != -1)
            {
                if (rtbKommentar.Text.Trim() != String.Empty)
                {
                    DialogResult res = MessageBox.Show("Är du helt säker på att du vill kommentera?", "Bekräfta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        handläggarcontroller.CommentSelectedCrime();
                        crimeList.UpdateSelectedCrime(lbCrimes.SelectedIndex);
                        rtbKommentar.Clear();
                    }
                }
                else
                    MessageBox.Show("Du måste skriva något i kommentar rutan för att uppdatera ett event!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Du måste välja ett brott ifrån listan till vänster först!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbCrimes.SelectedIndex != -1)
            {
                DialogResult res = MessageBox.Show("Är du helt säker på att jobbet har slutförts?", "Bekräfta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    crimeList.FinishCrime();
                }
                rtbKommentar.Clear();
            }
            else
                MessageBox.Show("Du måste välja ett brott ifrån listan till vänster först!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lbCrimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            crimeList.UpdateSelectedCrime(lbCrimes.SelectedIndex);
        }

        private void HandläggareForm_Load(object sender, EventArgs e)
        {
            lbCrimes.SelectedIndex = lbCrimes.Items.Count - 1;
        }
    }
}

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
    [Serializable()]
    public partial class HandläggareForm : Form
    {
        UserList userList;
        CrimeList crimeList;
        InloggningsForm inloggningsForm;
        HandläggareFormController handläggarController;

        public HandläggareForm(UserList userList, CrimeList crimeList)
        {
            InitializeComponent();
            this.userList = userList;
            this.crimeList = crimeList;
            this.handläggarController = new HandläggareFormController(this, this.crimeList);
            inloggningsForm = new InloggningsForm(userList, crimeList);
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
                        handläggarController.CommentSelectedCrime();
                        handläggarController.UpdateSelectedCrime(lbCrimes.SelectedIndex);
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
                    handläggarController.FinishCrime();
                }
                rtbKommentar.Clear();
            }
            else
            {
                MessageBox.Show("Du måste välja ett brott ifrån listan till vänster först!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lbCrimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            handläggarController.UpdateSelectedCrime(lbCrimes.SelectedIndex);
        }

        private void HandläggareForm_Load(object sender, EventArgs e)
        {
            lbCrimes.SelectedIndex = lbCrimes.Items.Count - 1;
        }
    }
}

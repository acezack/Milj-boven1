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
            inloggningsForm.Show();
        }

        private void btnSkicka_Click(object sender, EventArgs e)
        {
            crimeList.CommentSelectedCrime();
            crimeList.UpdateSelectedCrime(clbÄrendetitlar.SelectedIndex);
            if (!clbÄrendetitlar.GetItemChecked(clbÄrendetitlar.SelectedIndex))
            {
                MessageBox.Show("För att markera ett ärende: Välj ditt ärende och se till att även kryssrutan för ärendet är ifyllt!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rtbKommentar.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Du måste skriva något i kommentar rutan för att uppdatera ett event!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            rtbKommentar.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!clbÄrendetitlar.GetItemChecked(clbÄrendetitlar.SelectedIndex))
            {
                MessageBox.Show("För att markera ett ärende: Välj ditt ärende och se till att även kryssrutan för ärendet är ifyllt!", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult res = MessageBox.Show("Är du helt säker på att jobbet har slutförts?", "Bekräfta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    crimeList.FinishCrime();
                }
            }
            rtbKommentar.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miljöboven1.View;

namespace Miljöboven1.View
{
    public partial class MiljösamordnareForm : Form
    {
        InloggningsForm inloggningsForm;
        public MiljösamordnareForm(InloggningsForm inloggningsForm)
        {
            InitializeComponent();
            this.inloggningsForm = inloggningsForm;
        }

        private void MiljösamordnareForm_Load(object sender, EventArgs e)
        {

        }
    }
}
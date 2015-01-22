using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miljöboven1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            View.InloggningsForm inloggningsForm = new View.InloggningsForm();
            inloggningsForm.ShowDialog();
        }
    }
}
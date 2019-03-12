using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class pozivni_brojevi_Form : Form
    {
        public pozivni_brojevi_Form()
        {
            InitializeComponent();
        }

        private void pozivni_brojevi_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoskolaDataSet.Telefon' table. You can move, or remove it, as needed.
            this.telefonTableAdapter.Fill(this.autoskolaDataSet.Telefon);

        }
    }
}

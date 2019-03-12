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
    public partial class Koristenje_vozila_Form : Form
    {
        public Koristenje_vozila_Form()
        {
            InitializeComponent();
        }

        private void Koristenje_vozila_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoskolaDataSet.Vozilo' table. You can move, or remove it, as needed.
            this.voziloTableAdapter.Fill(this.autoskolaDataSet.Vozilo);

        }
    }
}

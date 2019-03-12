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
    public partial class LokacijeForm : Form
    {
        public LokacijeForm()
        {
            InitializeComponent();
        }

        private void LokacijeForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoskolaDataSet.Lokacija' table. You can move, or remove it, as needed.
            this.lokacijaTableAdapter.Fill(this.autoskolaDataSet.Lokacija);

        }
    }
}

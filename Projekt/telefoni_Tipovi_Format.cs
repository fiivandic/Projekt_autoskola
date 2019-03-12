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
    public partial class telefon_Tipovi_Format : Form
    {
        public telefon_Tipovi_Format()
        {
            InitializeComponent();
        }

        private void Telefoni_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoskolaDataSet.VrstaTelefona' table. You can move, or remove it, as needed.
            this.vrstaTelefonaTableAdapter.Fill(this.autoskolaDataSet.VrstaTelefona);

        }
    }
}

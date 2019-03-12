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
    public partial class UcionaForm : Form
    {
        public UcionaForm()
        {
            InitializeComponent();
        }

        private void UcionaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoskolaDataSet.Ucionica' table. You can move, or remove it, as needed.
            this.ucionicaTableAdapter.Fill(this.autoskolaDataSet.Ucionica);

        }

        private void dgvUciona_DoubleClick(object sender, EventArgs e)
        {
            var forma = new LokacijeForm();
            forma.ShowDialog();
        }
    }
}

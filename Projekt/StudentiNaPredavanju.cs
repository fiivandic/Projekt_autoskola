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
    public partial class StudentiNaPredavanju : Form
    {
        public StudentiNaPredavanju()
        {
            InitializeComponent();
        }

        private void StudentiNaPredavanju_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoskolaDataSet.Predavanje' table. You can move, or remove it, as needed.
            this.predavanjeTableAdapter.Fill(this.autoskolaDataSet.Predavanje);
            // TODO: This line of code loads data into the 'autoskolaDataSet.Polaznik' table. You can move, or remove it, as needed.
            this.polaznikTableAdapter.Fill(this.autoskolaDataSet.Polaznik);
            // TODO: This line of code loads data into the 'autoskolaDataSet.PolaznikPredavanje' table. You can move, or remove it, as needed.
            this.polaznikPredavanjeTableAdapter.Fill(this.autoskolaDataSet.PolaznikPredavanje);

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            dgvPolaznikPredavanje.FirstDisplayedScrollingRowIndex = dgvPolaznikPredavanje.RowCount - 1;
            var row = autoskolaDataSet.PolaznikPredavanje.NewPolaznikPredavanjeRow();
            autoskolaDataSet.PolaznikPredavanje.AddPolaznikPredavanjeRow(row);
        }

        private void BtnSpremi_Click(object sender, EventArgs e)
        {
            polaznikPredavanjeBindingSource.EndEdit();
            polaznikPredavanjeTableAdapter.Update(autoskolaDataSet.PolaznikPredavanje);
        }

        private void btnObriši_Click(object sender, EventArgs e)
        {
                if (MessageBox.Show("Obrisati zapis?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    autoskolaDataSet.PolaznikPredavanje[dgvPolaznikPredavanje.CurrentRow.Index].Delete();
                    polaznikPredavanjeTableAdapter.Update(autoskolaDataSet.PolaznikPredavanje);
                }
            }
        
    }
}

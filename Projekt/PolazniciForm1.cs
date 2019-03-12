using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class PolazniciForm1 : Form
    {
        public PolazniciForm1()
        {
            InitializeComponent();
        }

        private void PolazniciForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoskolaDataSet.Instruktor' table. You can move, or remove it, as needed.
            this.instruktorTableAdapter.Fill(this.autoskolaDataSet.Instruktor);
            // TODO: This line of code loads data into the 'autoskolaDataSet.Lokacija' table. You can move, or remove it, as needed.
            this.lokacijaTableAdapter.Fill(this.autoskolaDataSet.Lokacija);
            // TODO: This line of code loads data into the 'autoskolaDataSet.PolaznikPredavanje' table. You can move, or remove it, as needed.
            this.polaznikPredavanjeTableAdapter.Fill(this.autoskolaDataSet.PolaznikPredavanje);
            // TODO: This line of code loads data into the 'autoskolaDataSet.Ucionica' table. You can move, or remove it, as needed.
            this.ucionicaTableAdapter.Fill(this.autoskolaDataSet.Ucionica);
            // TODO: This line of code loads data into the 'autoskolaDataSet.Predavanje' table. You can move, or remove it, as needed.
            this.predavanjeTableAdapter.Fill(this.autoskolaDataSet.Predavanje);
            // TODO: This line of code loads data into the 'autoskolaDataSet.Mjesto' table. You can move, or remove it, as needed.
            this.mjestoTableAdapter.Fill(this.autoskolaDataSet.Mjesto);
            // TODO: This line of code loads data into the 'autoskolaDataSet.Polaznik' table. You can move, or remove it, as needed.
            this.polaznikTableAdapter.Fill(this.autoskolaDataSet.Polaznik);

        }

        private void tsbNovi_Click(object sender, EventArgs e)
        {
           
            var row = autoskolaDataSet.Polaznik.NewPolaznikRow();
            autoskolaDataSet.Polaznik.AddPolaznikRow(row);
        }

        private void tsbSpremi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Unesite ime polaznika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string.IsNullOrEmpty(txtPrezime.Text)))
            {
                MessageBox.Show("Unesite prezime polaznika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string.IsNullOrEmpty(txtOIB.Text)))
            {
                MessageBox.Show("Unesite OIB polaznika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string.IsNullOrEmpty(txtadresa.Text)))
            {
                MessageBox.Show("Unesite adresu polaznika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            else if ((string.IsNullOrEmpty(txtBrojOsobne.Text)))
            {
                MessageBox.Show("Unesite broj osobne polaznika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string.IsNullOrEmpty(txtEmail.Text)))
            {
                MessageBox.Show("Unesite email polaznika", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
           
            polaznikBindingSource.EndEdit();
            polaznikTableAdapter.Update(autoskolaDataSet.Polaznik);
        }

        private void tsbIsključi_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtOIB_TextChanged(object sender, EventArgs e)
        {
            this.txtOIB.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtOIB.Text, "[^0-9]"))
            {
                MessageBox.Show("Molim vas unesite samo brojeve od 0 do 9");
                txtOIB.Text = txtOIB.Text.Remove(txtOIB.Text.Length - 1);
            }
        }

        private void txtBrojOsobne_TextChanged(object sender, EventArgs e)
        {
            this.txtBrojOsobne.MaxLength = 9;
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBrojOsobne.Text, "[^0-9]"))
            {
                MessageBox.Show("Molim vas unesite samo brojeve od 0 do 9");
                txtBrojOsobne.Text = txtBrojOsobne.Text.Remove(txtBrojOsobne.Text.Length - 1);
            }
        }

        private void tsbPrikazUčiona_Click(object sender, EventArgs e)
        {
            var forma = new UcionaForm();
            forma.ShowDialog();
        }

        private void tsbPredavanje_Click(object sender, EventArgs e)
        {
            var forma = new StudentiNaPredavanju();
            forma.ShowDialog();
        }

        private void tsbIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbUplate_Click(object sender, EventArgs e)
        {
            var forma = new UplataForm();
            forma.ShowDialog();
        }

        private void tsbNoviTermin_Click(object sender, EventArgs e)
        {
            dgvPredavanja.FirstDisplayedScrollingRowIndex = dgvPredavanja.RowCount - 1;
            var row = autoskolaDataSet.Predavanje.NewPredavanjeRow();
            autoskolaDataSet.Predavanje.AddPredavanjeRow(row);
        }

        private void tsbSpremiPredavanje_Click(object sender, EventArgs e)
        {
            predavanjeBindingSource.EndEdit();
            predavanjeTableAdapter.Update(autoskolaDataSet.Predavanje);
        }

        private void txtOpis_TextChanged(object sender, EventArgs e)
        {
             if ((string.IsNullOrEmpty(txtOpis.Text)))
            {
                MessageBox.Show("Unesite opis predavanja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }
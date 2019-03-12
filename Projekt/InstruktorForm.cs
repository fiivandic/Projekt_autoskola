using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projekt
{
    public partial class InstruktorForm : Form
    {
        public InstruktorForm()
        {
            InitializeComponent();
        }

        private void InstruktorForm_Load(object sender, EventArgs e)
        {


            // TODO: This line of code loads data into the 'autoskolaDataSet.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.autoskolaDataSet.Model);
            // TODO: This line of code loads data into the 'autoskolaDataSet.Polaznik' table. You can move, or remove it, as needed.
            this.polaznikTableAdapter.Fill(this.autoskolaDataSet.Polaznik);
            // TODO: This line of code loads data into the 'autoskolaDataSet.Mjesto' table. You can move, or remove it, as needed.
            this.mjestoTableAdapter.Fill(this.autoskolaDataSet.Mjesto);
            // TODO: This line of code loads data into the 'autoskolaDataSet.Voznja' table. You can move, or remove it, as needed.
            this.voznjaTableAdapter.Fill(this.autoskolaDataSet.Voznja);
            // TODO: This line of code loads data into the 'autoskolaDataSet.Instruktor' table. You can move, or remove it, as needed.
            this.instruktorTableAdapter.Fill(this.autoskolaDataSet.Instruktor);

        }

        //instruktor gumbi
        private void tsbNovi_Click(object sender, EventArgs e)
        {
          
            dgvInstruktori.FirstDisplayedScrollingRowIndex = dgvInstruktori.RowCount - 1;
            
            var row = autoskolaDataSet.Instruktor.NewInstruktorRow();
            autoskolaDataSet.Instruktor.AddInstruktorRow(row);
        }

        private void tsbSpremi_Click(object sender, EventArgs e)
        {
            txtIme.Clear();
            if (string.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Unesite ime instruktora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string.IsNullOrEmpty(TxtPrezime.Text)))
            {
                MessageBox.Show("Unesite prezime instruktora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string.IsNullOrEmpty(TxtOIB.Text)))
            {
                MessageBox.Show("Unesite OIB instruktora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if ((string.IsNullOrEmpty(txtAdresa.Text)))
            {
                MessageBox.Show("Unesite adresu instruktora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else if ((string.IsNullOrEmpty(txtEmail.Text)))
            {
                MessageBox.Show("Unesite email instruktora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            instruktorBindingSource.EndEdit();
            instruktorTableAdapter.Update(autoskolaDataSet.Instruktor);
        }

        
        //Voznja gumbi
        private void tsbNovaVoznja_Click(object sender, EventArgs e)
        {
            dgvVoznje.FirstDisplayedScrollingRowIndex = dgvVoznje.RowCount - 1;
            var row = autoskolaDataSet.Voznja.NewVoznjaRow();
            autoskolaDataSet.Voznja.AddVoznjaRow(row);
        }

        private void tsbSpremiVozju_Click(object sender, EventArgs e)
        {
            voznjaBindingSource.EndEdit();
            voznjaTableAdapter.Update(autoskolaDataSet.Voznja);
        }

        private void tsbObrisiVoznju_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Obrisati zapis?", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                autoskolaDataSet.Voznja[dgvVoznje.CurrentRow.Index].Delete();
                voznjaTableAdapter.Update(autoskolaDataSet.Voznja);
            }
        }

        private void tsbIzlaz2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbIzalaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtOIB_TextChanged(object sender, EventArgs e)
        {
            this.TxtOIB.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtOIB.Text, "[^0-9]"))
            {
                MessageBox.Show("Molim vas unesite samo brojeve od 0 do 9");
                TxtOIB.Text = TxtOIB.Text.Remove(TxtOIB.Text.Length - 1);
            }
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
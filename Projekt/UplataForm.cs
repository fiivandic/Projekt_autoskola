using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class UplataForm : Form
    {
        public UplataForm()
        {
            InitializeComponent();
        }

        private void UplataForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoskolaDataSet.Polaznik' table. You can move, or remove it, as needed.
            this.polaznikTableAdapter.Fill(this.autoskolaDataSet.Polaznik);
            // TODO: This line of code loads data into the 'autoskolaDataSet.Uplata' table. You can move, or remove it, as needed.
            this.uplataTableAdapter.Fill(this.autoskolaDataSet.Uplata);

        }

     

        private void tsbSpremi_Click(object sender, EventArgs e)
        {
            uplataBindingSource.EndEdit();
            uplataTableAdapter.Update(autoskolaDataSet.Uplata);
        }

        private void tsbObirši_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Brisanje uplate. Dali ste sigurni da želite", "Upit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                autoskolaDataSet.Uplata[dgvUplata.CurrentRow.Index].Delete();
                uplataTableAdapter.Update(autoskolaDataSet.Uplata);
            }
        }

        private void tsbIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbUplata_Click(object sender, EventArgs e)
        {
           
            dgvUplata.FirstDisplayedScrollingRowIndex = dgvUplata.RowCount - 1;
 
            var row = autoskolaDataSet.Uplata.NewUplataRow();
            autoskolaDataSet.Uplata.AddUplataRow(row);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dgvUplata.Rows.Count == 0)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();
            string columnsHeader = "";
            for (int i = 0; i < dgvUplata.Columns.Count; i++)
            {
                columnsHeader += dgvUplata.Columns[i].Name + ",";
            }
            sb.Append(columnsHeader + Environment.NewLine);
            foreach (DataGridViewRow dgvRow in dgvUplata.Rows)
            {
                if (!dgvRow.IsNewRow)
                {
                    for (int c = 0; c < dgvRow.Cells.Count; c++)
                    {
                        sb.Append(dgvRow.Cells[c].Value + ",");
                    }
                    sb.Append(Environment.NewLine);
                }
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false))
                {
                    sw.WriteLine(sb.ToString());
                }
            }
            MessageBox.Show("Spremnljena je vaša datoteka");

        }

        private void dgvUplata_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            txtIznos.Text = null;
            dgvUplata.Rows[e.RowIndex].Selected = true;
        }
    }
}
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
    public partial class MjestaAutoškolaForm : Form
    {
        public MjestaAutoškolaForm()
        {
            InitializeComponent();
        }

        private void MjestaAutoškolaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'autoskolaDataSet.Mjesto' table. You can move, or remove it, as needed.
            this.mjestoTableAdapter.Fill(this.autoskolaDataSet.Mjesto);

        }

        private void btnPretraži_Click(object sender, EventArgs e)
        {
            string grad = txtGrad.Text;
            try
            {
                StringBuilder adresa = new StringBuilder();
                adresa.Append("https://www.openstreetmap.org/search?query=");
                if (grad != string.Empty)
                {
                    adresa.Append(grad + "," + "+");
                }
                webBrowser1.Navigate(adresa.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Pogreška");
            }
        }
    }
}

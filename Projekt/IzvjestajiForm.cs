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
    public partial class IzvjestajiForm : Form
    {
        public IzvjestajiForm()
        {
            InitializeComponent();
        }

        private void IzvjestajiForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AutoskolaDataSet.Vozilo' table. You can move, or remove it, as needed.
            this.VoziloTableAdapter.Fill(this.AutoskolaDataSet.Vozilo);
            // TODO: This line of code loads data into the 'AutoskolaDataSet.Predavanje' table. You can move, or remove it, as needed.
            this.PredavanjeTableAdapter.Fill(this.AutoskolaDataSet.Predavanje);

            // TODO: This line of code loads data into the 'AutoskolaDataSet.Polaznik' table. You can move, or remove it, as needed.
            this.PolaznikTableAdapter.Fill(this.AutoskolaDataSet.Polaznik);
            // TODO: This line of code loads data into the 'AutoskolaDataSet.Voznja' table. You can move, or remove it, as needed.
            this.VoznjaTableAdapter.Fill(this.AutoskolaDataSet.Voznja);
            // TODO: This line of code loads data into the 'AutoskolaDataSet.Instruktor' table. You can move, or remove it, as needed.
            this.InstruktorTableAdapter.Fill(this.AutoskolaDataSet.Instruktor);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }

       
    }
}

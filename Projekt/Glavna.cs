using System;
using System.Windows.Forms;

namespace Projekt
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnInstruktori_Click(object sender, EventArgs e)
        {
            var forma = new InstruktorForm();
            forma.ShowDialog();
        }

        private void btnPolaznici_Click(object sender, EventArgs e)
        {
            var forma = new PolazniciForm1();
            forma.ShowDialog();
        }

        private void modelVozilsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new VozilaForm();
            forma.ShowDialog();
        }

        private void korištenjeVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new Koristenje_vozila_Form();
            forma.ShowDialog();
        }

        private void telefoniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new pozivni_brojevi_Form();
            forma.ShowDialog();
        }

        private void mjestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new LokacijeForm();
            forma.ShowDialog();
        }

        private void mjestaAutoškolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new MjestaAutoškolaForm();
            forma.ShowDialog();
        }

        private void vrstaTelefonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new telefon_Tipovi_Format();
            forma.ShowDialog();
        }

        private void zahvaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new LiteraturaForm();
            forma.ShowDialog();
        }

        private void izvješćaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new IzvjestajiForm();
            forma.ShowDialog();
        }
       
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AplikacijaZaBiblioteku
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btnPregledKorisnika_Click(object sender, EventArgs e)
        {
            Form PregledKorisnika = new PregledKorisnika();
            PregledKorisnika.ShowDialog();
        }

        private void btnDodajNovogKorisnika_Click(object sender, EventArgs e)
        {
            Form UnosNovogKorisnika = new UnosNovogKorisnika();
            UnosNovogKorisnika.ShowDialog();
        }

        private void btnPregledLiterature_Click(object sender, EventArgs e)
        {
            Form PregledLiterature = new PregledLiterature();
            PregledLiterature.ShowDialog();
        }

        private void btnDodajNovuLiteraturu_Click(object sender, EventArgs e)
        {
            Form DodajNovuKnjigu = new DodajNovuKnjigu();
            DodajNovuKnjigu.ShowDialog();
        }

        private void btnPosudba_Click(object sender, EventArgs e)
        {
            Form Posudba = new Posudba();
            Posudba.ShowDialog();
        }

    }
}

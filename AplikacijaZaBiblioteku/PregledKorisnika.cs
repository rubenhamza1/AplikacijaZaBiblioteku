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
    public partial class PregledKorisnika : MainForm
    {
        public PregledKorisnika()
        {
            InitializeComponent();
            
        }

        private void btnDodajNovogKorisnika_Click(object sender, EventArgs e)
        {
            Form UnosNovogKorisnika = new UnosNovogKorisnika();
            UnosNovogKorisnika.ShowDialog();
        }
    }
}

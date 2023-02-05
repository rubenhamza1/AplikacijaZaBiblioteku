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
using System.Xml;

namespace AplikacijaZaBiblioteku
{
    public partial class UnosNovogKorisnika : MainForm
    {
        public UnosNovogKorisnika()
        {
            InitializeComponent();
        
        }
        private void btnUnesi_Click(object sender, EventArgs e)
        {

            XmlDocument xmlDoc = new XmlDocument();

            if()

            xmlDoc.LoadXml(("<korisnik>" +
                            "<ime>" + txtIme + "</ime>" +
                            "<prezime>" + txtPrezime + "</prezime>" +
                            "<datumRodenja>" + dtpDatumRodenja +"</datumRodenja>" +
                            "<id>" + + "</id>" +
                            "<brojTelefona> </brojTelefona>" +
                            "<emailAdresa> </emailAdresa>" +
                            "</korisnik>"));
            
        }
    }
}

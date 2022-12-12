using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaBiblioteku
{
    internal class Korisnik
    {
        string ime, prezime;
        int datumRodenja;

        public Korisnik(string ime, string prezime, int datumRodenja)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodenja = datumRodenja;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public int DatumRodenja { get => datumRodenja; set => datumRodenja = value; }

       
    }

}

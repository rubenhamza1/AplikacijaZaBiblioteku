using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaBiblioteku
{
    internal class Knjige
    {
        string naslov, autorImePrezime;
        int datumPosudbe;

        public string Naslov { get => naslov; set => naslov = value; }
        public string AutorImePrezime { get => autorImePrezime; set => autorImePrezime = value; }
        public int DatumPosudbe { get => datumPosudbe; set => datumPosudbe = value; }
    }
}

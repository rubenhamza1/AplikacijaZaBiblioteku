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
        int datumPosudbe, datumIzdanja;
        int knjigaId;
        bool dostupnost;

        public Knjige(string naslov, string autorImePrezime, int datumPosudbe, bool dostupnost, int datumIzdanja, int knjigaId)
        {
            this.naslov = naslov;
            this.autorImePrezime = autorImePrezime;
            this.datumPosudbe = datumPosudbe;
            this.dostupnost = dostupnost;
            this.datumIzdanja = datumIzdanja;
            this.knjigaId = knjigaId;
        }

        public string Naslov { get => naslov; set => naslov = value; }
        public string AutorImePrezime { get => autorImePrezime; set => autorImePrezime = value; }
        public int DatumPosudbe { get => datumPosudbe; set => datumPosudbe = value; }
        public bool Dostupnost { get => dostupnost; set => dostupnost = value; }
        public int DatumIzdanja { get => datumIzdanja; set => datumIzdanja = value; }
        public int KnjigaId { get => knjigaId; set => knjigaId = value; }
    }
}

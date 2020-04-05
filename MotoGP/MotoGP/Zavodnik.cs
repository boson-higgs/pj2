using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP
{
    public class Zavodnik
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Cislo { get; set; }
        public string Tym { get; set; }
        public bool TovarniTym { get; set; }

        public Zavodnik(string jmeno, string prijmeni, int cislo, string tym, bool tovarni_tym)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Cislo = cislo;
            Tym = tym;
            TovarniTym = tovarni_tym;
        }

        public void Edituj(string e_jmeno, string e_prijmeni, int e_cislo, string e_tym, bool e_tovarni_tym)
        {
            this.Jmeno = e_jmeno;
            this.Prijmeni = e_prijmeni;
            this.Cislo = e_cislo;
            this.Tym = e_tym;
            this.TovarniTym = e_tovarni_tym;
        }


        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + " " + " | " + " " + Cislo;
        }
    }
}
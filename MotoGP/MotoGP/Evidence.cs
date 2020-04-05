﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGP
{
    public class Evidence
    {
        public BindingList<Zavodnik> Zavodnici { get; set; }

        public Evidence()
        {
            Zavodnici = new BindingList<Zavodnik>();
        }

        public void Pridej(string jmeno, string prijmeni, int cislo, string tym, bool tovarnitym)
        {
            if (cislo < 1 & cislo > 99)
            {
                throw new ArgumentException("Pravidla umožňují závodní čísla v rozsahu 1 až 99");
            }
            Zavodnik zavodnik = new Zavodnik(jmeno, prijmeni, cislo, tym, tovarnitym);
            Zavodnici.Add(zavodnik);
        }

        public void Odeber(Zavodnik zavodnik)
        {
            Zavodnici.Remove(zavodnik);
        }

       /* public void Edituj(Zavodnik zavodnik)
        {
            Zavodnici.
        }*/

        /*public Evidence SeradPodleCisla()
        {
            return Zavodnici.OrderBy(cislo);
        }*/

        /*public Evidence Zobraz (Zavodnik zavodnik)
        {
            return zavodnik;
        }*/
        
    }
}
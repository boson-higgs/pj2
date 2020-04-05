using System;
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

        public void Pridej(string jmeno, string prijmeni, int cislo, string tym, bool tovarni_tym)
        {
            if (cislo < 1 & cislo > 99)
            {
                throw new ArgumentException("Pravidla umožňují závodní čísla v rozsahu 1 až 99");
            }
            Zavodnik zavodnik = new Zavodnik(jmeno, prijmeni, cislo, tym, tovarni_tym);
            Zavodnici.Add(zavodnik);
        }

        public void Odeber(Zavodnik zavodnik)
        {
            Zavodnici.Remove(zavodnik);
        }


        /*public void SeradPodleCisla()
         {
             Zavodnici.OrderBy(o => Zavodnik.Cislo).ToList();
         } 

         public void SeradPodlePrijmeni()
         {
             Zavodnici.OrderBy(o => Zavodnik.Prijmeni).ToList();
         }*/

    }
}
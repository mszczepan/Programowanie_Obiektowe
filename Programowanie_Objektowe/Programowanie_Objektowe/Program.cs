using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie_Objektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            Karta kartaOcen = UtworzKarte();

            kartaOcen.DodajOcene(4);
            kartaOcen.DodajOcene(8);
            kartaOcen.DodajOcene(6);
            kartaOcen.DodajOcene(3);

            KartaStatystki statystyki = kartaOcen.ObliczStatystki();

            Console.WriteLine("Srednia: " + statystyki.SredniaOcena);
            Console.WriteLine("Najnizsza: " + statystyki.NajnizszaOcena);
            Console.WriteLine("Najwyzsza: " + statystyki.NajwyzszaOcena);
        }

        private static LepszaKarta UtworzKarte()
        {
            return new LepszaKarta();
        }
    }
}

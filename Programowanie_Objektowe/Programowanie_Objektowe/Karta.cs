using System;
using System.Collections.Generic;
using System.Linq;


namespace Programowanie_Objektowe

{
    public class Karta
    {
        //Konstruktor
        public Karta()
        {
            oceny = new List<float>();           
        }


        //Stan (zmienne-pola)
        public string _nazwa;
        public String Nazwa
        {
            get 
            {
                return _nazwa.ToUpper();
            }
            set 
            { 
                if (!String.IsNullOrEmpty(value))
                {
                    if (_nazwa!=value)
                    {
                        ZmianaNazwyEventArgs args = new ZmianaNazwyEventArgs();
                        args.IstniejacaNazwa = _nazwa;
                        args.NowaNazwa = value;
                        
                        ZmianaNazwy(this, args);
                    }
                     
                    _nazwa = value;
                }
            } 
        }
        protected List<float> oceny;
 
        //Zdarzenie
        public event ZmianaNazwyDelegat ZmianaNazwy;
      

        //Zachowania(metody)

        public virtual KartaStatystki ObliczStatystki()
        {
            Console.WriteLine("Karta :Oblicz statystyki");
            KartaStatystki stat = new KartaStatystki();
            stat.SredniaOcena=oceny.Average();
            stat.NajnizszaOcena= oceny.Min();
            stat.NajwyzszaOcena=oceny.Max();

            return stat;
        }

        /// <summary>
        /// Dodaje nową ocenę do listy ocen
        /// </summary>
        /// <param name="ocena">nowa ocena</param>
        public void DodajOcene(float ocena) 
        {
            oceny.Add(ocena);
        }

        /// <summary>
        /// Obliczanie średniej z listy ocen
        /// </summary>
        /// <returns>Średnia ocena</returns>
        public float ObliczSrednia()
        {
            //float suma = 0;
            //float srednia = 0;

            //foreach (var ocena in oceny)
            //{
            //    suma += ocena;
            //    srednia = suma / oceny.Count();
            //}

            //return srednia;

            return oceny.Average();

        }

        /// <summary>
        /// Znajduje najniższą ocenę
        /// </summary>
        /// <returns>Najniższa ocena</returns>
        public float NajnizszaOcena()
        {
        
            return oceny.Min();
        }

        /// <summary>
        /// Oblicza najwyższą ocenę 
        /// </summary>
        /// <returns>Najwyższa ocena</returns>
        public float NajwyzszaWartosc()
        {
            return oceny.Max();

        }

        public void ZmianaTypu(string istniejacy , string nowy)
        {
            Console.WriteLine($"Typ został zmieniony {istniejacy} na {nowy}");
        }

    }
}

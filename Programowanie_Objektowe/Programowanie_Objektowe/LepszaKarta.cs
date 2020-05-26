using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie_Objektowe
{
    public class LepszaKarta:Karta
    {

        public override KartaStatystki ObliczStatystki()
        {
            Console.WriteLine("Lepsza Karta :Oblicz statystyki");
            float najnizsza = float.MaxValue;

            foreach (var ocena in oceny)
            {
                najnizsza = Math.Min(ocena, najnizsza);
            }

            oceny.Remove(najnizsza);
            return base.ObliczStatystki();

        }
    }
}

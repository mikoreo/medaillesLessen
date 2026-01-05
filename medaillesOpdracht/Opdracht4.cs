using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medaillesOpdracht
{
    internal class Opdracht4
    {
        
        public void Start()
        {
            Console.WriteLine("wat is je geboorte jaar?");
            int geboorteDatum = int.Parse(Console.ReadLine());

            int jaar = 2026;
            int leeftijd = jaar - geboorteDatum;

            Console.WriteLine("is je verjaardag al geweest?");
            string verjaardag = Console.ReadLine();

            if (verjaardag == "nee")
            {
                leeftijd--;
            } 

            Console.WriteLine(leeftijd);

            bool isVolwassen = IsAchtienPlus(geboorteDatum);

            if (isVolwassen)
            {
                Console.WriteLine("je bent achtienplus");
            } else
            {
                Console.WriteLine("je bent niet achtienplus");
            }
        }

        static bool IsAchtienPlus(int geboorteDatum)
        {
            int jaar = 2026;
            int leeftijd = jaar - geboorteDatum;

            return leeftijd >= 18;
        }
    }
}

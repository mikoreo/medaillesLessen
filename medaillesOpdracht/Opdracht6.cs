using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medaillesOpdracht
{
    internal class Opdracht6
    {
        public void Start()
        {
            Random randomCijfer = new Random();
            int cijfer = randomCijfer.Next(1, 101);
            Console.WriteLine("raad het nummer van 1 tot 100");
            int cijferGok = 0;
            int gokAantal = 0;


            while (cijferGok != cijfer)
            {
                if (!int.TryParse(Console.ReadLine(), out cijferGok))
                {
                    Console.WriteLine("geen geldig getal");
                    continue;
                }

                if (cijferGok <= cijfer)
                {
                    Console.WriteLine("hoger");
                }
                else
                {
                    Console.WriteLine("lager");
                }
                gokAantal++;
                Console.WriteLine($"hoe vaak je hebt gegokt = {gokAantal}");

                if (cijferGok == cijfer)
                {
                    Console.WriteLine("je hebt het goed!");
                }
            }
        }
    }
}

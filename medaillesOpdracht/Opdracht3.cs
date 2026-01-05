using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medaillesOpdracht
{
    internal class Opdracht3
    {
        public void Start()
        {
            Console.WriteLine("wat voor weer is het?");
            Console.WriteLine("zonnig, regen of bewolkt");
            string antwoordWeer = Console.ReadLine();
            if (antwoordWeer != "zonnig" && antwoordWeer != "regen" && antwoordWeer != "bewolkt")
            {
                Console.WriteLine("no");
                return;
            }

            

            Console.WriteLine("hoe veel graden is het?");
            string antwoordGraden = Console.ReadLine();
            if (!double.TryParse(antwoordGraden, out double graden))
            {
                Console.WriteLine("no");
                return;
            }

            if (antwoordWeer == "zonnig")
            {
                if (graden >= 17)
                {
                    Console.WriteLine("het is lekker warm");
                }
                else
                {
                    Console.WriteLine("het is nie zo super warm");
                }
            } else if (antwoordWeer == "regen")
            {
                if (graden >= 20)
                {
                    Console.WriteLine("kijk voor een regenboog, maar pak wel een paraplu");
                }
                else
                {
                    Console.WriteLine("pak een paraplu");
                }
            } else if (antwoordWeer == "bewoklt")
            {
                if (graden >= 25)
                {
                    Console.WriteLine("het is warm en je hoeft geen zonnebrand op");
                }
                else
                {
                    Console.WriteLine("doe maar een jas aan");
                }
            }
            
        }
    }
}

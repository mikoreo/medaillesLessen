using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace medaillesOpdracht
{
    internal class Opdracht5
    {
        public void Start()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 5);
            }

            Console.WriteLine("welke tafel wil je doen?");
            int eersteCijfer = int.Parse(Console.ReadLine());

            Console.WriteLine("en hoe vaak");
            int tweedeCijfer = int.Parse(Console.ReadLine());

            for (int i = 1; i <= tweedeCijfer; i++)
            {
                Console.WriteLine(eersteCijfer * i);
            }
        }
    }
}

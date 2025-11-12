using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medaillesOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wat is je naam?");
            string naam = Console.ReadLine();
            Console.WriteLine("wat is je leeftijd");
            string leeftijd = Console.ReadLine();
            Console.WriteLine("Hoi " + naam + ", je bent " + leeftijd + " jaar oud!");
        }
    }
}

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
            bool admin = false;
            /* medaillesOpdracht 1

             Console.WriteLine("wat is je naam?");
             string naam = Console.ReadLine();
             Console.WriteLine("wat is je leeftijd");
             string leeftijd = Console.ReadLine();
             Console.WriteLine("Hoi " + naam + ", je bent " + leeftijd + " jaar oud!");
            */




            //Opdracht4 test = new Opdracht4();
            //test.Start();

            // Character Player1 = new Character("Player1", 5);

            List<Weapon> weaponList = new List<Weapon>()
            {
                new Weapon("gouden prikker", 10),
            };

            foreach (Weapon weapon in weaponList)
            {
                weapon.ShowStats();
            }
           
            

            

        }
    }
}

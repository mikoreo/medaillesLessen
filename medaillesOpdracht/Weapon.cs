using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace medaillesOpdracht
{
    internal class Weapon
    {
        private string _name;
        private int _damage;

        public Weapon(string name, int damage)
        {
            _name = name;
            _damage = damage;

            
        }

        public void ShowStats()
        {
            Console.WriteLine($"{_name} doet {_damage} damage");
        }
    }
}

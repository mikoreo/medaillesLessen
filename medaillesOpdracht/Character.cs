using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medaillesOpdracht
{
    internal class Character
    {
        private string _Name;
        private int _Level;

        public Character(string Name, int Level)
        {
            _Name = Name;
            _Level = Level;

            Console.WriteLine($"player: {_Name} met level: {_Level} is aangemaakt.");
        }
    }
}

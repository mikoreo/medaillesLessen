using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medaillesOpdracht
{

    //je stopt er een nederlands woord in als key, ik krijg een string array met values terug die engels. deze array word volledig uitgeprint

    internal class Opdracht2
    {


        private readonly Dictionary<string, string[]> nederlandsEngels =
             new Dictionary<string, string[]>
             {
                { "stoel", new[] { "chair"} },
                { "tafel", new[] { "table" } },
                 { "steen", new[]{ "rock", "stone", "boulder", "henk"} }
             };


        private readonly Dictionary<string, string> naam =
            new Dictionary<string, string>
            {
                {"kees","hendrik" }
            };

        public void Start()
        {

            //Console.WriteLine(nederlandsEngels["b"][0]);
            Console.WriteLine(nederlandsEngels["tafel"][0]);
            Console.WriteLine(nederlandsEngels["steen"][2]);
            Console.WriteLine(naam["kees"]);
        }


    }
}

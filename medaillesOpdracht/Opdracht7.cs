using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medaillesOpdracht
{
    internal class Opdracht7
    {
        public void Start()
        {
            Random dobbelsteen = new Random();
            int dobbelsteenCijfer = dobbelsteen.Next(1, 7);
            Console.WriteLine(dobbelsteenCijfer);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace medaillesOpdracht
{
    internal class Loops
    {
        int i = 0;
        public void Start()
        {
            /*
            bool running = true;

            while (running)
            {
                Console.WriteLine("wat is jou naam");
                string answer = Console.ReadLine();

                if (answer == "Michael")
                {
                    running = false;
                }


                Console.Clear();
         
            }

            do
            {
                i++;
                Console.WriteLine(i);
            } while (i < 10);
            

            for(int i = 0; i  <= 10; i++)
            {
                Console.WriteLine(i);
            }
            

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            */
            int i = 0;
            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }

        }
    }
}

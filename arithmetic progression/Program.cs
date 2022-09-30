using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_progression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minValue = 5;
            int maxValue = 96;
            int step = 7;

            for(int i = minValue; i <= maxValue; i += step)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}

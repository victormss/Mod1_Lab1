using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int outer;
            int inner;

            for (outer = 2; outer < 10000000; outer++)
            {
                for (inner = 2; inner <= (outer / inner); inner++)
                    if ((outer % inner) == 0) break;
                if (inner > (outer / inner))
                    Console.WriteLine("{0} is prime", outer);
            }
        }
    }
}

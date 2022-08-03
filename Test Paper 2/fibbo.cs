using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_2
{
    class fibbo
    {
        public void printSeries ()
        {
            int val1 = 0, val2 = 1, val3, i, n;

            n = 20;

            Console.WriteLine("Fibonacci series:");
            Console.Write(val1 + " " + val2 + " ");

            for (i = 2; i < n; i++)
            {
                val3 = val1 + val2;
                Console.Write(val3 + " ");
                val1 = val2;
                val2 = val3;
            }
        }
    }
}

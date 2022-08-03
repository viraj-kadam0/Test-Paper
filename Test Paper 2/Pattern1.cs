using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_2
{
    class Pattern1
    {
        public void print1()
        {

            int i, j, k;

            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }

                for (k = 1; k <= 6 - i; k++)
                    Console.Write(k);

                Console.WriteLine();
            }

            Console.ReadLine();
        }


        public void print2()
        {
            int i, j;

            for (i = 1; i <= 6; i++)
            {
                for (j = 1; j <= 6 - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        public void print3()
        {
            int i, j, n = 5;
            for (i = 0; i < n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write(i);
                Console.Write("\n");
            }

        }

    }
}
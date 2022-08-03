using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_4
{
     class Patterns
    {
        //1
        //21
        //321
        //4321
        //54321
        public void printPat1()
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j >=1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //     1
        //    10
        //   101
        //  1010
        // 10101

        public void printPat2()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 5; k > i; k--)
                {
                        Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                  
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //Print pattern 
        //1
        //22
        //333
        //4444
        //55555
        public void printPat3()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

    }
}

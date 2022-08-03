using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_2
{
    //1!+2!+3!+4!...n WAP a program to find sum
    class FactorialSeriesSum
    {
        public void factSum()
        {
            Console.WriteLine("Enter number=");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                int fact = 1;
                for (int j = 1; j <= i; j++)
                {
                    fact = fact * j;
                    sum = sum + fact;
                }
            }
            Console.WriteLine(sum);
        }
    }
}

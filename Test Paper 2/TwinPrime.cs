using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_2
{
    class TwinPrime
    {
        public void twin()
        {
            int num1 = 3;
            int num2 = 15;
              if (isprime(num1) && isprime(num2))
            {
                if (num1 - num2 == 2 || num1 - num2 == -2)
                {
                    Console.WriteLine("twin prime");
                }
                else
                {
                    Console.WriteLine("prime");
                }
            }
        }


        public bool isprime(int n)
        {
            // use for loop to find the twin prime  
            bool prime = true;
            for (int i = 2; i < n; i++)
            {
                // if n is completely divisible by 1 without leaving any remainder, it returns 0  
                if (n % i == 0)
                {
                    prime = false;
                    Console.WriteLine(n + "Not prime");
                    break;
                }
            }

            return prime;
        }
    }
}

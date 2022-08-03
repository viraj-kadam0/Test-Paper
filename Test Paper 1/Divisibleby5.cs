using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper
{
     class Divisibleby5
    {
        public void divisible ()
        {
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());

            if (num % 5 == 0 && num % 11 == 0) 
            {
                Console.WriteLine("Divisible by 5 & 11");
            }
  
            else
            {
                Console.WriteLine("Not Divisible by 5 & 11");
            }
        }

    }
}

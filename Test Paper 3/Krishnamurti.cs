using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_3
{
    class Krishnamurti
    {        public void isKrishnamurti()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, r = 0;
            for (int i = n; i > 0; i = i / 10)
            {
                r = i % 10;
                int fact = 1;
                for(int j = 1; j<=r; j++)
                {
                    fact = fact * j;
                }
                sum = sum + fact;
            }



            if (n == sum)
            {
                Console.WriteLine("Krishnamurti Number");
            }
            else
            {
                Console.WriteLine("Not Krishnamurti Number");
            }
        }
    }
}

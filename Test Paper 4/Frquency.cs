using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_4
{
    class Frquency
    {
        public void test()
        {
            int num = int.Parse(Console.ReadLine());
            int i;
            for(i = 0; i < num; i++)
            {
                int n = num;
                int count = 0;
                while(n > 0)
                {
                    int rem = n % 10;
                    if(rem == i)
                    {
                        count++;
                    }

                    n = n / 10;
                }
                Console.WriteLine("Frequency of Digit" + i + " " + count);
            }
        }
    }
            
}

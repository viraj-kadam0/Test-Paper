using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_3
{
    class HarshadNumber
    {
        public void isHarshad()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0, r = 0;
            for(int i=n; i>0; i=i/10) {
                r = i % 10;
                sum=sum+r;
            }

            if(n%sum==0)
            {
                Console.WriteLine("Harshad Number");
            } else
            {
                Console.WriteLine("Not Harshad Number");
            }
        }
    }
}

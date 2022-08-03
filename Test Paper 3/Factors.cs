using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_3
{
    internal class Factors
    {
        public void findFactors()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                if(n%i==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

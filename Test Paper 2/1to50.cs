using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_2
{
    class _1to50
    {
        public  void oddNegativeSquare ()
        {

            for (int n = 1; n <= 50; n++)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine("-" + n * n);
                }
            }
        }
    }
}

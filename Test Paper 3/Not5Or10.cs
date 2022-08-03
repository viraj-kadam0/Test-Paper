using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_3
{
    internal class Not5Or10
    {
        public void printExcept5Or10()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 != 0 && i % 10 != 0 )
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

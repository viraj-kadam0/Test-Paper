using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_4
{
    class Series
    {
        public void se()

        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i * (i + 2));
            }

        }
    }
}
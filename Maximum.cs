﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper
{
    internal class Maximum
    {
        public void max()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());   
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1);
            }
            else if (num2 > num3)
            {
                Console.WriteLine(num2);
            }

            else
            {
                Console.WriteLine(num3);
            }
        }

    }
}

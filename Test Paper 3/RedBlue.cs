﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_3
{
    class RedBlue
    {
        public void printRedBlue()
        {
            for(int i = 1; i <= 100; i++)
            {
                if(i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("RedBlue");
                } 
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Red");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Blue");
                } else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

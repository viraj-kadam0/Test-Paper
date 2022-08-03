using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper
{
    internal class LeapOrNot
    {
        public void year()
        {
            Console.WriteLine("Enter Year");
            int year = int.Parse(Console.ReadLine());

            if(((year%4==0) && (year%100!=0))|| (year %400==0))
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not Leap Year");
            }

        }
    }
}

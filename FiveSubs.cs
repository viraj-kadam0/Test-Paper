using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper
{
     class FiveSubs
    {
        public void avg ()
        {
            float sub1, sub2, sub3, sub4, sub5, total, average, percentage;
            Console.WriteLine("Enter Marks of sub1");
            sub1= float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of sub2");
            sub2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of sub3");
            sub3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of sub4");
            sub4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks of sub5");
            sub5 = float.Parse(Console.ReadLine());

            total = sub1 + sub2 + sub3 + sub4 + sub5;
            average= total / 5;
            percentage = total / 500 *100;

            Console.WriteLine("Total is" + total);
            Console.WriteLine("Average is"+ average);
            Console.WriteLine("Percentage is"+ percentage);
            
        }

    }
}

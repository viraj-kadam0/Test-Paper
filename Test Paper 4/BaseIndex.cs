using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_4
{
    class BaseIndex
    {
        public void Cal()

        {
            Console.WriteLine("Enter Base");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Power");
            int power = int.Parse(Console.ReadLine());

            int count = 1;
            int Ans;

            for (int i = 0; i < power; i++)
            {
                count = count * num;
            }
            Console.WriteLine(count);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper
{
    internal class EquilateralArea
    {
        public void area()
        {
            Console.WriteLine("Sides Of Equilateral Triangle");
            float side = float.Parse(Console.ReadLine());
            float area = (float)(1.73205 * side * side / 4);
            Console.WriteLine("Area is"+ area);
        }
    }
}

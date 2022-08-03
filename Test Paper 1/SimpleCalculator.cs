using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper
{
    class SimpleCalculator
    {
        public void calculate()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter character:\n+ Add\n- Substract\n* Mulltiply\n / Divide");
            char c = Convert.ToChar(Console.ReadLine());

            switch (c)
            {
                case '+':
                    Console.WriteLine("Add= " + (a + b));
                    break;
                case '-':
                    Console.WriteLine("Substract= " + (a - b));
                    break;
                case '*':
                    Console.WriteLine("Multiply= " + (a * b));
                    break;
                case '/':
                    Console.WriteLine("Divide= " + (a / b));
                    break;
            }
        }
    }
}

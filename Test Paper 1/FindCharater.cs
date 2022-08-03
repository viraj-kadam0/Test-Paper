using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper
{
    internal class FindCharater
    {
        public void checkCharacter()
        {
            char ch;
            Console.WriteLine("Enter character");
            ch = Convert.ToChar(Console.ReadLine());

            if ((ch >= 'a' && ch <='z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("Alphabet");
            }
            else if(ch >= '0' && ch <= '9')
            {
                Console.WriteLine("Digit");

            } else
            {
                Console.WriteLine("Special Character");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper
{
    class VowelConconent
    {
        public void vowel()
        {
            char ch;
            Console.WriteLine("ENter alphabet");
            ch = Convert.ToChar (Console.ReadLine());

            if (ch == 'a' || ch == 'e'|| ch == 'i'||  ch== 'o'|| ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonents");

            }


        }
    }
}

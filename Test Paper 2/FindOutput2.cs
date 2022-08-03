using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_2
{
     class FindOutput2
    {
       
            public void find2 ()
            {
                int b = 0;
                do
                {
                    int a = 2;
                    b++;
                    Console.WriteLine(a++);
                }
                while (b != 3);
         
        
        }
        public void find3()
        {
            int i = 1, k = 1;
            while (i++ <= 5)
            {
                k *= i;
            }
            Console.WriteLine("k ="+k +"i ="+i);
        }
        
        public void find9 ()
        {
            for (int i = 5; i > 0; i--)
            {
                int mysteryInt = 100;
                mysteryInt -= i;
                Console.WriteLine(mysteryInt);
            }

        }

        public void find13 ()

        {
            int i = 1;
            while (i <= 5)
            {
                int j = 1;
                while (j <= 5)
                {
                    if (j == 2)
                    {
                        break;
                        Console.WriteLine(j);
                    }
                    j++;
                }
                Console.WriteLine(i);
            }

        }
    }

}
    


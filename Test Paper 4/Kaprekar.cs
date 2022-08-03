using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Paper.Test_Paper_4
{
     class Kaprekar
    {
        //int n = 45;
        //int n = 13;
        //int n = 297;
        int n;

            int square;
            public void isKaprekarNumber()
            {
            n = int.Parse(Console.ReadLine());
            square = n * n;
                int count = getCount(square);
                bool isKN = false;
                for (int k = count - 1; k > 0; k--)
                {
                    int mul10 = 1;
                    for (int i = 1; i <= k; i++)
                    {
                        mul10 = mul10 * 10;
                    }

                    int first = square / mul10;
                    int second = square % mul10;
                    if (first == 0 || second == 0)
                    {
                        continue;
                    }
                    if ((first + second) == n)
                    {
                        isKN = true;
                        break;
                    }
                }

                if (isKN)
                {
                    Console.WriteLine("Kaprekar Number");
                }
                else
                {
                    Console.WriteLine("No Kaprekar Number");
                }

            }

            public int getCount(int num)
            {
                int count = 0;
                while (num > 0)
                {
                    num = num / 10;
                    count++;
                }
                return count;
            }


        
    }
}

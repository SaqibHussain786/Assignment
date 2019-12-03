using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Modular_Exponentiation
{
    class Program
    {
        static int power(int x, int y, int p)
        {
            
            int res = 1;

            
            x = x % p;

            while (y > 0)
            {
          
                if ((y & 1) == 1)
                    res = (res * x) % p;

            
                y = y >> 1;
                x = (x * x) % p;
            }
            return res;
        }

        public static void Main()
        {
            int x = 2;
            int y = 5;
            int p = 13;
            System.Console.WriteLine("Power is " +
                                      power(x, y, p));
        }
    }


}


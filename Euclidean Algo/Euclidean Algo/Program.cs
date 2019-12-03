using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidean_Algo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            Console.Write("Enter first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("GCD of {0} and {1} is equal to {2}", number1, number2, gcd(number1, number2));
        }
        static int gcd(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
    }
}

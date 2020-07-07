using System;
using System.Numerics;

namespace Factorial
{
    public class Factorial
    {
        public BigInteger factorial(BigInteger number)
        {
            // Console.WriteLine(number);
            if (number < 2)
            {
                return 1;
            }
            else
            {
                return number * factorial(number - 1);

            }
        }
    }
}

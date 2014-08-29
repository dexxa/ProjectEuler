using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_1
{
  /**
   * Problem 1:
   * If we list all the natural numbers below 10 that are multiples of 3 or 5, 
   * we get 3, 5, 6 and 9. The sum of these multiples is 23.
   * Find the sum of all the multiples of 3 or 5 below 1000.
   * 
   */

  class Program
  {

    static void Main(string[] args)
    {
      const int MAX_NUMBER = 1000;
      int[] divisors = { 3, 5 };
      int sum = 0;

      for (int i = MAX_NUMBER - 1; i > 0; i--)
      {
        foreach (int divisor in divisors)
        {
          if (i % divisor == 0)
          {
            sum += i;
            break;
          }
        }
      }

      Console.Write("Sum of all natural number less than {0} divisible by 3 or 5 is {1}", MAX_NUMBER, sum);
      Console.Read();
    }
  }
}

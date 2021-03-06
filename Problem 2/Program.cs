﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_2
{
  /**
   * Prblem 2: 
   * Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
   * By starting with 1 and 2, the first 10 terms will be:
   * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
   * By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
   * find the sum of the even-valued terms.
   * 
   */
  class Program
  {
    static void Main(string[] args)
    {
      const int MAX_NUMBER = 4000000;
      int fibA = 1, fibB = 2;
      int sum = fibA + fibB;

      while (fibB < MAX_NUMBER)
      {
        int temp = fibB;
        fibB = fibA + fibB;
        fibA = temp;

        if (fibB < MAX_NUMBER)
        {
          Console.Write(fibB + ", ");
          sum += fibB % 2 == 0 ? fibB : 0;
        }
      }

      Console.WriteLine("Sum of fibonacci number less than {0} is {1}", MAX_NUMBER, sum);
      Console.Read();
    }
  }
}

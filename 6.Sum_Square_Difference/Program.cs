using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _6.Sum_Square_Difference {
    class Program {
        static void Main(string[] args) {
            List<int> numbers = new List<int>();
            int sumOfSquares = 0;

            for (int i = 1; i <= 100; i++) {
                sumOfSquares += (int)Math.Pow(i, 2);
                numbers.Add(i);
            }

            int squareOfSum = (int)Math.Pow(numbers.Sum(), 2);

            Console.WriteLine(squareOfSum - sumOfSquares);
        }
    }
}

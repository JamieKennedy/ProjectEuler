using System;
using System.Collections.Generic;

namespace _2.Even_Fibonacci_Numbers {
    class Program {
        static void Main(string[] args) {
            List<int> fibNumbers = new List<int>();

            fibNumbers.Add(0);
            fibNumbers.Add(1);

            while (true) {
                int fibNumber = fibNumbers[^1] + fibNumbers[^2];

                if (fibNumber < 4000000) {
                    fibNumbers.Add(fibNumber);
                } else {
                    break;
                }
            }

            int sum = 0;

            foreach (int num in fibNumbers) {
                if (IsEven(num)) {
                    sum += num;
                }
            }

            Console.WriteLine(sum);


        }

        private static bool IsEven(int num) {
            return num % 2 == 0;
        }
    }
}

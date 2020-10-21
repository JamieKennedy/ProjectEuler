using System;
using System.Collections.Generic;

namespace _12.Highly_Divisible_Triangular_Number {
    class Program {
        static void Main(string[] args) {
            int triangularNumber;
            int numberOfDivisors;

            const int maxDivisors = 500;
            int counter = 1;

            while (true) {
                triangularNumber = GetTriangular(counter);
                numberOfDivisors = GetNumberOfDivisors(triangularNumber);

                if (numberOfDivisors >= maxDivisors) {
                    Console.WriteLine($"{triangularNumber} is the first triangular number to have over {maxDivisors} divisors");
                    break;
                } else if (numberOfDivisors > 250) {
                    Console.WriteLine(numberOfDivisors);
                }
                counter += 1;
            }
        }

        private static int GetTriangular(int num) {
            int triangularNum = 0;

            for (int i = 1; i <= num; i++) {
                triangularNum += i;
            }

            return triangularNum;
        }

        private static int GetNumberOfDivisors(int num) {
            int numberOfDivisors = 0;
            int sqrt = (int)Math.Sqrt(num);

            for (int i = 1; i <= sqrt; i++) {
                if (num % i == 0) {
                    numberOfDivisors += 2;
                }
            }

            if (sqrt * sqrt == num) {
                numberOfDivisors--;
            }

            return numberOfDivisors;
        }

        private static bool IsEven(int num) {
            return num % 2 == 0;
        }
    }
}

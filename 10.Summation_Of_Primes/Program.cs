using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _10.Summation_Of_Primes {
    class Program {
        static void Main(string[] args) {
            List<long> primes = new List<long>();

            long count = 1;

            while (count < 200000000) {
                if (IsPrime(count)) {
                    primes.Add(count);
                }
                count++;
            }

            Console.WriteLine(primes.Sum());
        }

        private static bool IsPrime(long num) {
            if (num <= 1) {
                return false;
            } else if (num == 2) {
                return true;
            } else if (num % 2 == 0) { // Number is even but not equal to 2
                return false;
            } else {
                int boundry = (int)Math.Floor(Math.Sqrt(num));

                for (int i = 3; i <= boundry; i += 2) {
                    if (num % i == 0) {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}

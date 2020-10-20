using System;

namespace _7._10001st_Prime {
    class Program {
        static void Main(string[] args) {
            int counter = 0;
            int primeCount = 0;
            int prime = 0;

            while (primeCount < 10001) {
                if (IsPrime(counter)) {
                    primeCount += 1;
                    prime = counter;
                }
                counter += 1;
            }

            Console.WriteLine(prime);
        }

        private static bool IsPrime(int num) {
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

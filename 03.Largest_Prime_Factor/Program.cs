using System;

namespace _3.Largest_Prime_Factor {
    class Program {
        static void Main(string[] args) {
            //int num = int.Parse(args[0]);
            long num = 600851475143;

            int maxCheck = (int)Math.Ceiling(Math.Sqrt(num));

            for (int i = maxCheck; i > 2; i--) {
                if (num % i == 0) { // i is a factor of num
                    if (IsPrime(i)) {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
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

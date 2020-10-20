using System;
using System.Linq;

namespace _4.Largest_Palindrome_Product {
    class Program {
        static void Main(string[] args) {
            int product;
            int maxPalindrome = 0;

            for (int i = 100; i < 1000; i++) {
                for (int j = 100; j < 1000; j++) {
                    product = i * j;
                    if (IsPalindrome(product)) {
                        maxPalindrome = Math.Max(maxPalindrome, product);
                    }
                }
            }

            Console.WriteLine(maxPalindrome);
        }

        private static bool IsPalindrome(int num) {
            string numAsString = Convert.ToString(num);
            string reversedString = ReverseString(numAsString);

            return numAsString == reversedString;
        }

        private static string ReverseString(string s) {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}

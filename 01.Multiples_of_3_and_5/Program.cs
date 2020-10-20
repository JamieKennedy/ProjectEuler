using System;
using System.Collections.Generic;
using System.Linq;

namespace Multiples_of_3_and_5 {
    class Program {
        static void Main(string[] args) {
            List<int> multiples = new List<int>();

            for (int i = 1; i < 1000; i++) {
                if (IsMultipleOf5(i) || IsMultipleOf3(i)) {
                    multiples.Add(i);
                }
            }

            Console.WriteLine(multiples.Sum());
        }

        private static bool IsMultipleOf5(int num) {
            return num % 5 == 0;
        }

        private static bool IsMultipleOf3(int num) {
            return num % 3 == 0;
        }
    }
}

using System;
using System.Diagnostics.Tracing;

namespace _5.Smallest_Multiple {
    class Program {
        static void Main(string[] args) {

            int counter = 20;
            while (true) {
                bool success = true;
                for (int i = 1; i <= 20; i++) {
                    if (!IsMultiple(counter, i)) {
                        success = false;
                        break;
                    }
                }

                if (success) {
                    Console.WriteLine(counter);
                    break;
                } else {
                    counter += 1;
                }
            }
        }

        private static bool IsMultiple(int x, int y) {
            // Returns true if x is a multiple of y
            return x % y == 0;
        }
    }
}

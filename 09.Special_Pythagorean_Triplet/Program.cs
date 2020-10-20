using System;

namespace _9.Special_Pythagorean_Triplet {
    class Program {
        static void Main(string[] args) {

            bool found = false;

            for (int a = 1; a <= 1000; a++) {
                for (int b = 1; b < a; b++) {
                    if (1000 - a - b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))) {
                        int c = 1000 - a - b;
                        found = true;
                        Console.WriteLine(a * b * c);
                        break;
                    }
                }
                if (found) {
                    break;
                }
            }
        }
    }
}

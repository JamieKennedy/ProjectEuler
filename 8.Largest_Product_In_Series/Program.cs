using System;
using System.IO;

namespace _8.Largest_Product_In_Series {
    class Program {
        static void Main(string[] args) {
            string subString;

            string dir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string series = File.ReadAllText(dir + "/Series.txt");

            long maxProduct = 0;
            int subStringSize = 13;


            for (int i = 0; i <= series.Length - subStringSize; i++) {
                subString = series.Substring(i, subStringSize);
                Console.WriteLine($"{subString} : {GetProduct(subString)}");
                maxProduct = Math.Max(maxProduct, GetProduct(subString));
            }

            Console.WriteLine($"Max Product: {maxProduct}");
        }

        private static long GetProduct(string s) {
            long product = 1;

            foreach (char number in s) {
                product *= int.Parse(number.ToString());
            }

            return product;
        }
    }
}

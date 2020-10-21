using System;
using System.Collections.Generic;
using System.IO;

namespace _11.Largest_Product_In_A_Grid {
    class Program {
        enum Direction {
            vertical,
            horizontal,
            diagonalLeft,
            diagonalRight
        }

        static void Main(string[] args) {
            string dir = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            string[] lines = File.ReadAllLines(dir + "/Grid.txt");

            List<string[]> grid = new List<string[]>();

            foreach (string str in lines) {
                grid.Add(str.Split(" "));
            }

            int height = grid.Count;
            int width = grid[0].Length;
            int maxProduct = 0;

            for (int i = 0; i < height; i++) {
                for (int j = 0; j < width; j++) {
                    if (InBounds(width, height, i, j, Direction.vertical)) {
                        maxProduct = Math.Max(maxProduct, GetVerticalProduct(grid, i, j));
                    }

                    if (InBounds(width, height, i, j, Direction.horizontal)) {
                        maxProduct = Math.Max(maxProduct, GetHorizontalProduct(grid, i, j));
                    }

                    if (InBounds(width, height, i, j, Direction.diagonalLeft)) {
                        maxProduct = Math.Max(maxProduct, GetDiagonalProduct(grid, i, j, -1));
                    }

                    if (InBounds(width, height, i, j, Direction.diagonalRight)) {
                        maxProduct = Math.Max(maxProduct, GetDiagonalProduct(grid, i, j, 1));
                    }
                }
            }

            Console.WriteLine($"Max Product: {maxProduct}");
        }

        private static int GetVerticalProduct(List<string[]> grid, int i, int j) {
            int product = 1;

            for (int offset = 0; offset < 4; offset++) {
                product *= int.Parse(grid[i + offset][j]);
            }

            return product;
        }

        private static int GetHorizontalProduct(List<string[]> grid, int i, int j) {
            int product = 1;

            for (int offset = 0; offset < 4; offset++) {
                product *= int.Parse(grid[i][j + offset]);
            }

            return product;
        }

        private static int GetDiagonalProduct(List<string[]> grid, int i, int j, int dir) {
            int product = 1;

            for (int offset = 0; offset < 4; offset++) {
                product *= int.Parse(grid[i + offset][j + offset * dir]);
            }

            return product;
        }

        private static bool InBounds(int width, int height, int i, int j, Direction dir) {
            switch (dir) {
                case Direction.vertical:
                    return i + 4 <= height;
                case Direction.horizontal:
                    return j + 4 <= width;
                case Direction.diagonalLeft:
                    return i + 4 <= height && j - 3 >= 0;
                case Direction.diagonalRight:
                    return i + 4 <= height && j + 4 <= width;
                default:
                    return false;
            }
        }
    }
}

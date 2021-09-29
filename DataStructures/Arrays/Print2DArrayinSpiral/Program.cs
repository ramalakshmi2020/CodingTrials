using System;
using System.Collections.Generic;

namespace Print2DArrayinSpiral
{
    class Program
    {
        static List<int> SpiralTraversal(List<List<int>> matrix, int r, int c)
        {
            List<int> spiral = new List<int>();
            int top = 0;
            int bottom = r - 1;
            int left = 0;
            int right = c - 1;
            int dir = 0;
            while(left <= right && top <= bottom)
            {
                if (dir == 0)
                {
                    for (int i = left; i <= right; i++)
                        spiral.Add(matrix[top][i]);
                    top++;
                }
                else if(dir == 1)
                {
                    for (int i = top; i <= bottom; i++)
                        spiral.Add(matrix[i][right]);
                    right--;
                }
                else if(dir == 2)
                {
                    for (int i = right; i >= left; i--)
                        spiral.Add(matrix[bottom][i]);
                    bottom--;
                }
                else if(dir == 3)
                {
                    for (int i = bottom; i >= top; i--)
                        spiral.Add(matrix[i][left]);
                    left++;

                }
                dir = (dir + 1) % 4;
            }

            return spiral;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> r1 = new List<int> { 1, 2, 3, 4 };
            List<int> r2 = new List<int> { 5, 6, 7, 8 };
            List<int> r3 = new List<int> { 9,10, 11,12};
            List<int> r4 = new List<int> { 13,14,15,16 };
            List<List<int>> inputmatrix = new List<List<int>>();
            inputmatrix.Add(r1);
            inputmatrix.Add(r2);
            inputmatrix.Add(r3);
            inputmatrix.Add(r4);
            List<int> spiral = SpiralTraversal(inputmatrix, 4, 4);

            Console.Write("The 4*4 matrix from 1-16 in spiral form is ");
            foreach (int i in spiral) Console.Write("{0} ", i);
        }
    }
}

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.


using System;
using System.Collections.Generic;
using System.Linq;

class MaxSum
{
    static void Main()
    {
        Console.Write("Enter number of rows in the matrix: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number of colloms in the matrix: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        for (int irow = 0; irow < n; irow++)
        {
            Console.Write("Enter {0} row: ", irow + 1);
            string[] currentRow = Console.ReadLine().Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < m; i++)
            {
                matrix[irow, i] = int.Parse(currentRow[i]);
            }
            //for (int icol = 0; icol < m; icol++)
            //{
            //    Console.Write("Enter number in [{0}],[{1}] position: ", irow, icol);
            //    matrix[irow, icol] = int.Parse(Console.ReadLine());
            //}
        }
        //int[,] matrix = 
        //{
        //    {7, 1, 1, 1, 8, 1},
        //    {2, 1, 1, 1, 2, 1},
        //    {7, 1, 1, 1, 8, 1},
        //    {1, 1, 1, 1, 1, 1}
        //};
        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] 
                    + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] 
                    + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }
        Console.WriteLine("Max sum is: {0}", maxSum);
        Console.WriteLine("Matrix is :");
        Console.WriteLine("{0} {1} {2}", matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1], matrix[maxRow, maxCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1], matrix[maxRow + 1, maxCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[maxRow + 2, maxCol], matrix[maxRow + 2, maxCol + 1], matrix[maxRow + 2, maxCol + 2]);
    }
}


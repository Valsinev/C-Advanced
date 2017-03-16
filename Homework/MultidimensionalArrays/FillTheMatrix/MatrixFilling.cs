using System;
class MatrixFilling
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int length = matrix.Length;
        int count = 1;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                    matrix[col, row] = count;
                    count++;
            }
        }
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0, 4} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}


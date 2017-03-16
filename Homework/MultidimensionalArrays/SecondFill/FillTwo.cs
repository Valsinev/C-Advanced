using System;
class FillTwo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int lenth = matrix.Length;
        int count = 1;
        int reverse = 1;
        for (int row = 0; row < n; row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[col, row] = count;
                    count++;
                }
            }
            else
            {
                for (int col = n - 1; col >= 0; col--)
                {
                    matrix[col, row] = count;
                    count++;
                }
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


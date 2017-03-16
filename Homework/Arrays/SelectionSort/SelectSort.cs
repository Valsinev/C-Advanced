//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.


using System;

class SelectSort
{
    static void Main()
    {
        int[] array = 
        {
            64, 25, 12, 22, 11,
            11, 64, 25, 12, 22,
            11, 12, 64, 25, 22,
            11, 12, 22, 64, 25,
            11, 12, 22, 25, 64
        };
        int tmp;
        int minIndex = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            minIndex = i;
            for (int j = i; j < array.Length - 1; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
                tmp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = tmp;
            }
            foreach (var item in array)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }
    }
}


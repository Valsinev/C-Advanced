// Write a program that finds the maximal sequence of equal elements in an array. Example:

using System;

namespace MaximalSeq
{
    class MaxSeq
    {
        static void Main()
        {
            int[] collection = { 4, 4, 4, 4, 2, 2, 1, 1, 1, 1, 25, 25, 25, 25, 25, 25, 25, 25, 25, 3, 3, 3, };
            int counter = 1;
            int max = 0;
            int maxIndex = 0;

            for (int i = 1; i < collection.Length; i++)
            {
                if (collection[i - 1] == collection[i])
                {
                    counter++;
                    if (counter > max)
                    {
                        max = counter;
                        maxIndex = i;
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine("Max sequence is : {0} (of number - {1})!", max, collection[maxIndex]);
        }
    }
}

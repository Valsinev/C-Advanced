//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	                     result
//3, 2, 3, 4, 2, 2, 4	     2, 3, 4




using System;
using System.Collections.Generic;

class MaxIncSequence
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int maxCount = 0;
        int currentCount = 1;
        int maxIndex = 0;
        for (int index = 0; index < arr.Length; index++)
        {
            Console.Write("Enter element {0}: ", index);
            arr[index] = int.Parse(Console.ReadLine());
            if (index != 0)
            {
                if (arr[index - 1] + 1 == arr[index])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxIndex = arr[index];
                    }
                }
                else
                {
                    currentCount = 1;
                }
            }
        }
        int[] result = new int[maxCount];
        for (int i = maxCount - 1; i >= 0; i--)
        {
            result[i] = maxIndex;
            maxIndex--;
        }
        for (int j = 0; j < result.Length; j++)
        {
            Console.Write(result[j] + " ,");
        }
    }
}

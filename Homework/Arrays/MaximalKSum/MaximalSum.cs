//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.


using System;

class MaximalSum
{
    static void Main()
    {
        //Console.Write("Enter number of elements: ");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("Enter integer number (K): ");
        //int k = int.Parse(Console.ReadLine());
        int[] arr = { 2, 1, 6, 5, 11, 5, 2, 3, 4, 5, };
        //int[] result = new int[k];
        int sum = 0;
        int currentCount = 1;
        int maxCount = 0;
        int maxIndex = 0;
        //for (int index = 0; index < n; index++)
        //{
        //    Console.Write("Enter element {0}: ", index);
        //    arr[index] = int.Parse(Console.ReadLine());
        //}
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] > arr[i])
            {
                if (currentCount > maxCount)
                {
                    currentCount++;
                    maxCount = currentCount;
                    maxIndex = arr[i - 1];
                }
            }
            else
            {
                maxCount = 0;
            }
        }
        Console.WriteLine(maxIndex);
    }
}



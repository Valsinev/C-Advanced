//Write a program that finds the most frequent number in an array.
//Example:

//input	                                        result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	      4 (5 times)


using System;
class FrequentNum
{
    static void Main()
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        int maxCount = 1;
        int currentCount = 1;
        int maxIndex = 0;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter [{0}] element in the array: ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        for (int index = 1; index < arr.Length; index++)
        {
            if (arr[index - 1] == arr[index])
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxIndex = arr[index - 1];
                }
            }
            else
            {
                currentCount = 1;
            }
        }
        Console.WriteLine("{0} ({1} times)",maxIndex , maxCount);
    }

}

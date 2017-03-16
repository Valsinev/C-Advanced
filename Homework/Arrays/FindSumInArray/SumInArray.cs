//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:

//array	                    S	    result
//4, 3, 1, 4, 2, 5, 8	    11	    4, 2, 5

using System;

class SumInArray
{
    static void Main()
    {
        Console.Write("Enter the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int index = 0; index < arr.Length; index++)
        {
            Console.Write("Enter number in [{0}] index of the array: ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter the sum of sequence you want to search: ");
        int s = int.Parse(Console.ReadLine());
        bool check = false;
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    check = true;
                    for (int print = i; print <= j; print++)
                    {
                        Console.Write("The sequence summ = S is: {0}, ",arr[print]);
                    }
                }
            }
            sum = 0;
        }
        if (!check)
        {
            Console.WriteLine("There is no sum of sequence = S!");
        }
    }
}

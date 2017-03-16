//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

class AppCount
{     
    static void NumberAppearence(int[] array, int number)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine("The number {0} appears in the array {1} times!",number , counter);
    }
    static void Main()
    {
        int[] array = { 6, 5, 2, 5, 6, 7, 8, 6, 7, 6, 4, 6 };
        Console.Write("Enter number: ");
        int entry = int.Parse(Console.ReadLine());
        NumberAppearence(array, entry);
    }
}


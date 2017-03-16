//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class Compare
{
    static void Main()
    {
        Console.Write("Enter first array lenght: ");
        int a = int.Parse(Console.ReadLine());
        int[] arrayOne = new int[a];
        for (int i = 0; i < a; i++)
        {
            Console.Write("Enter number in index[{0}]:", i);
            arrayOne[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter second array lenght: ");
        int b = int.Parse(Console.ReadLine());
        int[] arrayTwo = new int[b];
        for (int j = 0; j < b; j++)
        {
            Console.Write("Enter number in index[{0}]:", j);
            arrayTwo[j] = int.Parse(Console.ReadLine());
        }
        bool equal = true;
        if (a == b)
        {
            for (int i = 0; i < a; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    equal = false;
                    break;
                }
            } 
        }
        else
        {
            equal = false;
        }
        if (equal)
        {
            Console.WriteLine("Arrays have same elements!");
        }
        else
        {
            Console.WriteLine("Arrays have different elements!");
        }
       
    }
}


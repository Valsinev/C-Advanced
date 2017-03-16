
//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CharArrays
{
    static void Main()
    {
        Console.Write("Enter first array lenght: ");
        int lenghtOne = int.Parse(Console.ReadLine());
        string[] arrayOne = new string[lenghtOne];
        for (int i = 0; i < lenghtOne; i++)
        {
            Console.Write("Enter letter in index[{0}]:", i);
            arrayOne[i] = Console.ReadLine();
        }
        Console.Write("Enter second array lenght: ");
        int lenghtTwo = int.Parse(Console.ReadLine());
        string[] arrayTwo = new string[lenghtTwo];
        for (int j = 0; j < lenghtTwo; j++)
        {
            Console.Write("Enter letter in index[{0}]:", j);
            arrayTwo[j] = Console.ReadLine();
        }
        bool equal = true;
        if (lenghtOne == lenghtTwo)
        {
            for (int i = 0; i < lenghtOne; i++)
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
            Console.WriteLine("The letters in the arrays are the same!");
        }
        else
        {
            Console.WriteLine("Arrays are different!");
        }
    }
}


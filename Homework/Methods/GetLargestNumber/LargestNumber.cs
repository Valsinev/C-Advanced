//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class LargestNumber
{
    static void GetMax(int firstNumber, int secondNumber, int thirdNumber)
    {
        if (firstNumber > secondNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine(firstNumber);
        }
        else if (secondNumber > thirdNumber)
        {
            Console.WriteLine(secondNumber);
        }
        else
        {
            Console.WriteLine(thirdNumber);
        }
    }
                
    static void Main()
    {
        int max = 0;
        Console.Write("Enter first number:");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number:");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter third number:");
        int thirdNumber = int.Parse(Console.ReadLine());
        GetMax(firstNumber, secondNumber, thirdNumber);
    }
}


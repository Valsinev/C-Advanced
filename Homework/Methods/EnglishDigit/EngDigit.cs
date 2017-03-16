//Write a method that returns the last digit of given integer as an English word.
//Examples:

//input   output
//512	  two
//1024	  four
//12309   nine

using System;

class EngDigit
{
    static void LastDigitAsWord(int number)
    {
        string convert = Convert.ToString(number);
        string lastChar = convert.Remove(0, convert.Length - 1);
        int lastDigit = int.Parse(lastChar);
        switch (lastDigit)
        {
            case 1 :
                Console.WriteLine("one");
        break;
                case 2 :
                Console.WriteLine("two");
        break;
                case 3 :
                Console.WriteLine("three");
        break;
                case 4 :
                Console.WriteLine("four");
        break;
                case 5 :
                Console.WriteLine("five");
        break;
                case 6 :
                Console.WriteLine("six");
        break;
                case 7 :
                Console.WriteLine("seven");
        break;
                case 8 :
                Console.WriteLine("eight");
        break;
                case 9 :
                Console.WriteLine("nine");
        break;
                case 0 :
                Console.WriteLine("zero");
        break;
        }
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        int entry = int.Parse(Console.ReadLine());
        LastDigitAsWord(entry);
    }
}


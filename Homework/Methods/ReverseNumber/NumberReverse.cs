//Write a method that reverses the digits of given decimal number.
//Example:

//input	  output
//256	      652
//123.45	  54.321


using System;

class NumberReverse
{
    static void Reverse(decimal number)
    {
        string convert = Convert.ToString(number);
        char[] arr = convert.ToCharArray();
        Array.Reverse(arr);
        Console.WriteLine(arr);
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        decimal entry = decimal.Parse(Console.ReadLine());
        Reverse(entry);
    }
}


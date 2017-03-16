
//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
//Example:

//input	   output
//Peter	   Hello, Peter!


using System;
class Hello
{
    static void UserName(string name)
    {
        Console.WriteLine("Hello, {0}!" , name);
    }
    static void Main()
    {
        Console.Write("Enter your name: ");
        UserName(Console.ReadLine());
    }
}


//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class Letters
{
    static void Main()
    {
        Console.Write("Enter word: ");
        string n = Console.ReadLine();
        char[] alphabet = {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        char[] sum = new char[n.Length];
        for (int t = 0; t < n.Length; t++)
        {
            sum[t] = n.ToCharArray()[t];
        }
        for (int sumindex = 0; sumindex < sum.Length; sumindex++)
        {
            for (int index = 0; index < alphabet.Length; index++)
            {
                if (sum[sumindex] == alphabet[index])
                {
                    Console.WriteLine("Alphabet letter is: {0} index is: {1} ", alphabet[index], index);
                }
            }
        }

    }
}


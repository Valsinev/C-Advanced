//Write a program that compares two char arrays lexicographically (letter by letter).
using System;

namespace CompareCharArrays
{
    class CompareChar
    {
        static void Main()
        {
            Console.Write("Enter range of first array!:");
            int n1 = int.Parse(Console.ReadLine());
            char[] collection1 = new char[n1];
            Console.Write("Enter range of second array!:");
            int n2 = int.Parse(Console.ReadLine());
            char[] collection2 = new char[n2];

            for (int i = 0; i < n1; i++)
            {
                Console.Write("Enter [{0}] element of first array: ", i);
                collection1[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n2; i++)
            {
                Console.Write("Enter [{0}] element of second array: ", i);
                collection2[i] = char.Parse(Console.ReadLine());
            }
            bool equal = false;

            if (collection1.Length == collection2.Length)
            {
                for (int i = 0; i < n1; i++)
                {
                    equal = (collection1[i] != collection2[i]) ? equal = false : equal = true;
                }
                Console.WriteLine("Collections are equal: {0}", equal);
            }
            for (int i = 0; i < Math.Min(n1, n2); i++)
            {
                string firstSecond;
                if (collection1[i] == collection2[i])
                {
                    continue;   
                }
                else
                {
                    firstSecond = (collection1[i] < collection2[i]) ?
                    "Collection1 is first, collection2 is second! " :
                    "Collection2 is first, collection1 is second! ";
                }
                Console.WriteLine(firstSecond);
            }
        }
    }
}

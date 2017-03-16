
//Write a program that reads two integer arrays from the console and compares them element by element.
using System;

namespace CompareArrays
{
    class Comparing
    {
        static void Main()
        {
            Console.Write("Enter range of first array!:");
            int n = int.Parse(Console.ReadLine());
            int[] collection1 = new int[n];
            Console.Write("Enter range of second array!:");
            int n2 = int.Parse(Console.ReadLine());
            int[] collection2 = new int[n2];


            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter [{0}] element of first array: ",i);
                collection1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n2; i++)
            {
                Console.Write("Enter [{0}] element of second array: ", i);
                collection2[i] = int.Parse(Console.ReadLine());
            }
            bool equal = false;

            if (collection1.Length == collection2.Length)
            {
                for (int i = 0; i < n; i++)
                {
                    equal = (collection1[i] != collection2[i]) ? equal = false : equal = true;
                }
            }
            Console.WriteLine(equal);
        }
    }
}

//Write a program that finds the maximal sequence of equal elements in an array.
//Example:

//input	                             result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1	     2, 2, 2

using System;

class MaxSquence        
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        int maxIndex = 0;
        int currentCount = 1;
        int maxCount = 1;
        for (int index = 0; index < length; index++)
        {
            Console.Write("Enter element {0}: ", index);
            array[index] = int.Parse(Console.ReadLine());
        }
        for (int index = 1; index < length; index++)
        {
            if (array[index - 1] == array[index])  // if first element is == to second
            {
                currentCount++;                  
                if (currentCount > maxCount)    
                {
                    maxCount = currentCount;      //counter for sequence of elements
                    maxIndex = array[index];      //store the index number you want to print
                }
            }
            else
            {
                currentCount = 1;                 //restart the check
            }
        }
        for (int i = 0; i < maxCount; i++)
        {
            Console.Write("{0} ", maxIndex);
        }
    }
}


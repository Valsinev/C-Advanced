//Write a method that checks if the element at given position in given array of integers is 
//larger than its two neighbours (when such exist).


using System;
class LargerOFNeighbours
{
    static void Check(int[] array, int number)
    {
        if (number == 0)
        {
            if (array[number] > array[number + 1])
            {
                Console.WriteLine("{0} is bigger than its neighbours!", array[number]);
            }
            else
            {
                Console.WriteLine("{0} isnt bigger than its neighbours!", array[number]);
            }
        }
        else if (number + 1 > array.Length - 1)
        {
            if (array[number] > array[number - 1])
            {
                Console.WriteLine("{0} is bigger than its neighbours!", array[number]);
            }
            else
            {
                Console.WriteLine("{0} isnt bigger than its neighbours!", array[number]);
            }
        }
        else if(array[number] > array[number - 1] && 
                array[number] > array[number + 1])
	    {
		 Console.WriteLine("{0} is bigger than its neighbours!", array[number]);
	    }
        else
        {
            Console.WriteLine("{0} isnt bigger than its neighbours!", array[number]);
        }
        
    }
    static void Main()
    {
        int[] arr = { 5, 6, 7, 2, 4, 5, 6, 1 };
        Console.Write("Enter array position: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number <= arr.Length - 1 && number >= 0)
        {
            Check(arr, number);
        }
        else
        {
            Console.WriteLine("You are out of range of the array!");
        }
    }
}
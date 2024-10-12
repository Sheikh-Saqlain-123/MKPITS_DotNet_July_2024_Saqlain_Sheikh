using System;
using System.Collections.Generic;

public class FindMinMax
{
   

    public static int FindSmallest(List<int> list)
    {
        int min = int.MaxValue;

        foreach (int num in list)
        {
            if (num < min)
            {
                min = num;
            }
        }

        return min;
    }

    public static int FindLargest(List<int> list)
    {
        int max = int.MinValue;

        foreach (int num in list)
        {
            if (num > max)
            {
                max = num;
            }
        }

        return max;
    }

     public static void Main(string[] args)
    {
        List<int> list = new List<int> { 5, 2, 8, 1, 3 };

        int min = FindSmallest(list);
        int max = FindLargest(list);

        Console.WriteLine("Smallest: " + min);
        Console.WriteLine("Largest: " + max);
    }
}

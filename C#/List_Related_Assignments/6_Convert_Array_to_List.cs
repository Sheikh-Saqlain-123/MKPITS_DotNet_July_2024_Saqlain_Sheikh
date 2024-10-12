using System;
using System.Collections.Generic;

class Program
{
    static List<int> ConvertArrayToList(int[] array)
    {
        return new List<int>(array);
    }

    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        List<int> list = ConvertArrayToList(array);

        Console.WriteLine("List of integers: " + string.Join(", ", list));
    }
}

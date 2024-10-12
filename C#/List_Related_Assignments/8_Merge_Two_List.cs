using System;
using System.Collections.Generic;

class Program
{
    static List<int> MergeLists(List<int> list1, List<int> list2)
    {
        List<int> mergedList = new List<int>(list1);
        mergedList.AddRange(list2);
        return mergedList;
    }

    static void Main()
    {
        List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int> { 6, 7, 8, 9, 10 };

        List<int> mergedList = MergeLists(list1, list2);
        Console.WriteLine("Merged List: " + string.Join(", ", mergedList));
    }
}

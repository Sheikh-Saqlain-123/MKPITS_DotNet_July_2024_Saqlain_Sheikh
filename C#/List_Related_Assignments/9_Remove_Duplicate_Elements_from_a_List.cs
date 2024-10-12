using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> RemoveDuplicates(List<int> list)
    {
        return list.Distinct().ToList();
    }

    static void Main()
    {
        List<int> list = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        List<int> uniqueList = RemoveDuplicates(list);
        Console.WriteLine("List without duplicates: " + string.Join(", ", uniqueList));
    }
}

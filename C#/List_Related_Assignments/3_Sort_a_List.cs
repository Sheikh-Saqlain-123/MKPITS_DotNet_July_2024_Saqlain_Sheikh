using System;
using System.Collections.Generic;
using System.Linq;

public class SortList
{
  

    public static List<int> SortListAscending(List<int> list)
    {
        return list.OrderBy(x => x).ToList();
    }

    public static List<int> SortListDescending(List<int> list)
    {
        return list.OrderByDescending(x => x).ToList();
    }

      public static void Main(string[] args)
    {
        List<int> list = new List<int> { 5, 2, 8, 1, 3 };

        List<int> ascendingList = SortListAscending(list);
        List<int> descendingList = SortListDescending(list);

        Console.WriteLine("Ascending: " + string.Join(", ", ascendingList));
        Console.WriteLine("Descending: " + string.Join(", ", descendingList));
    }
}

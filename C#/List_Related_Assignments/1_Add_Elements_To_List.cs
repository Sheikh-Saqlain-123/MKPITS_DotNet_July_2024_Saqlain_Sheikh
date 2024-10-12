using System;
using System.Collections.Generic;

public class AddElements
{
   

    public static void AddElementsToList(List<int> list)
    {
        for (int i = 1; i <= 5; i++)
        {
            list.Add(i);
        }
    }

     public static void Main(string[] args)
    {
        List<int> list = new List<int>();
        AddElementsToList(list);
        Console.WriteLine(string.Join(", ", list));
    }
}
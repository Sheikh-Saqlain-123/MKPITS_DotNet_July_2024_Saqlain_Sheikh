using System;
using System.Collections.Generic;

public class RemoveElements
{


    public static void RemoveElementFromList(List<string> list, string element)
    {
        list.Remove(element);
    }

        public static void Main(string[] args)
    {
        List<string> list = new List<string> { "Apple", "Banana", "Cherry", "Date", "Elderberry" };
        RemoveElementFromList(list, "Cherry");
        Console.WriteLine(string.Join(", ", list));
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<int> GetEvenNumbers(List<int> numbers)
    {
        return numbers.Where(num => num % 2 == 0).ToList();
    }

    static void Main()
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> evenNumbers = GetEvenNumbers(list);

        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
    }
}

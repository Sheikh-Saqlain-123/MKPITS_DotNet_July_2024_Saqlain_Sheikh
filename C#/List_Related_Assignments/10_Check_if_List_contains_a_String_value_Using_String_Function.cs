using System;
using System.Collections.Generic;

public class CheckListValue
{
    public static void Main(string[] args)
    {
        List<int> list = new List<int> { 5, 2, 8, 1, 3 };
        int checkVaslue = 8;

        bool checkTheValue = list.Contains(checkVaslue);
        Console.WriteLine("List contains value is : "+checkVaslue);
    }
}

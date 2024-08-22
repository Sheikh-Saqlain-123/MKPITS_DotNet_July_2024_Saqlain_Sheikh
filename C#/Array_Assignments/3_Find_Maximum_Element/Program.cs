/*
3. Find Maximum Element:
○ Write a C program to find the maximum element in an array of integers
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Find_Maximum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size :-");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter Array Elements:- ");
            for (int position = 0; position < size; position++)
            {
                arr[position] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Entered Array Elements Are :- ");
            for (int position = 0; position < size; position++)
            {
                Console.Write(arr[position] + " ");

            }
            int length = arr.Length;
            Console.WriteLine("Length is :- " + length);
            int max = arr[0];
            for(int count=0; count < length; count++)
            {
                if (arr[count] > max)
                {
                    max = arr[count];
                }
            }
            Console.WriteLine("The Max Element in the Array is :- "+max);
            Console.Read();
        }
    }
}

/*
2. Sum of Array Elements:
○ Write a C program that takes an array of integers as input and calculates the sum of its
elements.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Sum_of_Array_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size:- ");
            int size = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int[] arr = new int[size];

            Console.WriteLine("Enter Array Elements:- ");
            for (int position=0;position<size;position++)
            {
                arr[position] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Entered Elements Are :- ");
            for (int position = 0; position < size; position++)
            {
                Console.Write(arr[position]+" ");
                sum += arr[position];
            }
            Console.WriteLine("Sum of Elements of the Array is :- "+sum);
            Console.Read();
        }
    }
}

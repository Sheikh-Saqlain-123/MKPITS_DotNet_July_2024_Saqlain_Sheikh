/*
 1. Basic Array Initialization and Access:
○ Write a C program to declare an array of 10 integers, initialize it with values from 1 to 10,
and print these values
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Basic_Array_Initialization_and_Access
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Total Array Elements You Want:- ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            for(int position = 0; position < size; position++)
            {
                arr[position]=position+1;
                Console.Write(arr[position]+" ");
            }

            Console.Read();
        }
    }
}

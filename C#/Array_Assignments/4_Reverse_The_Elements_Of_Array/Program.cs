/*
4. Reverse Array:
○ Write a C program to reverse the elements of a given array
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _4_Reverse_The_Elements_Of_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size :-");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int position = 0; position < size; position++)
            {
                arr[position] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Entered Array Elements Are :- ");
            for (int position = 0; position < size; position++)
            {
                Console.Write(arr[position] + " ");

            }
            int startIndex = 0;
            int endIndex = arr.Length - 1;

            //while (startIndex<endIndex)
            //{
            //    int tmp = arr[startIndex];
            //    arr[startIndex] = arr[endIndex];
            //    arr[endIndex] = tmp;
            //    startIndex++;
            //    endIndex--;
            //}

            for (int cnt = 0; cnt < arr.Length; cnt++)
            {
                int temp = arr[cnt];
                arr[cnt] = arr.Length - startIndex - 1;
                arr[arr.Length - startIndex - 1] = temp;
            }
            Console.WriteLine("Array Elements in Reverse Order are:-");
            for (int position = 0; position < size; position++)
            {
                Console.Write(arr[position] + " ");

            }



            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_WAP_TO_TAKE_INTEGER_INPUTS_AND_FIND_THEIR_TOTAL_AVERAGE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size:- ");
            int size = Convert.ToInt32(Console.ReadLine());
            int average = 0;int total = 0;
            int[] arr = new int[size];
            Console.WriteLine("Enter Array Elements:- ");
            for (int count=0; count<size; count++)
            {
                arr[count] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enterd Elements in Array are :- ");
            for (int count = 0; count < size; count++)
            {
                Console.WriteLine(arr[count]);
                total = total + arr[count];
            }
            average = total / size;
            Console.WriteLine("Abverage of teh Elements of the Array is:- "+average);

            Console.Read();
        }
    }
}

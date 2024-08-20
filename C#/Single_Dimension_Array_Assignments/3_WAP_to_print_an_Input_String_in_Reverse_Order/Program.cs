//WAP to print an Input String( take user input ) in Reverse Order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3_WAP_to_print_an_Input_String_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string str = Convert.ToString(Console.ReadLine());
            string[] reverse = new string[] { "SAQLAIN" };

            Console.WriteLine("...............................................");
            Console.WriteLine("String Entered Character Wise Is:- ");
            for(int count=0; count<str.Length; count++)
            {
                Console.WriteLine(str[count]);
            }

            Console.WriteLine("...............................................");
            Console.WriteLine("String Entered Character Wise In Reverse Order Is:- ");
            for (int count = str.Length-1; count>=0 ; count--)
            {
                Console.WriteLine(str[count]);
            }

            Console.WriteLine("...............................................");
            Console.Read();
        }
    }
}

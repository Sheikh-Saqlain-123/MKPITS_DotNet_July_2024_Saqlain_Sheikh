using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_11_String_Concatenation_Using_Operator_Overloading
{
    class ConcatenateStrings
    {
        private string str;

        // Constructor to initialize the string
        public ConcatenateStrings(string str)
        {
            this.str = str;
        }

        // Overloading the + operator to concatenate two strings
        public static ConcatenateStrings operator +(ConcatenateStrings s1, ConcatenateStrings s2)
        {
            return new ConcatenateStrings(s1.str + s2.str);
        }

        // Method to display the string
        public void Display()
        {
            Console.WriteLine(str);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

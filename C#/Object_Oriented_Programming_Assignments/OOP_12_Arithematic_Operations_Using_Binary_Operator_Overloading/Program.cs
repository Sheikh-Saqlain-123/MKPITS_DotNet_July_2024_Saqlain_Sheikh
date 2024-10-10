using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_12_Arithematic_Operations_Using_Binary_Operator_Overloading
{
    class Numbers
    {
        private int value;

        // Constructor to initialize the number
        public Numbers(int value)
        {
            this.value = value;
        }

        // Overloading the + operator
        public static Numbers operator +(Numbers n1, Numbers n2)
        {
            return new Numbers(n1.value + n2.value);
        }

        // Overloading the - operator
        public static Numbers operator -(Numbers n1, Numbers n2)
        {
            return new Numbers(n1.value - n2.value);
        }

        // Overloading the * operator
        public static Numbers operator *(Numbers n1, Numbers n2)
        {
            return new Numbers(n1.value * n2.value);
        }

        // Method to display the value
        public void Display()
        {
            Console.WriteLine(value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers num1 = new Numbers(10);
            Numbers num2 = new Numbers(5);

            Console.WriteLine("Choose an operation: +, -, *");
            char operation = Console.ReadLine()[0];

            Numbers result = null;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    return;
            }

            Console.WriteLine("Result of the operation:");
            result.Display();

            Console.Read();
        }
    }
}

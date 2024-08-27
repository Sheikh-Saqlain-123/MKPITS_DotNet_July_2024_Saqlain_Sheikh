using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5_Addition_Substraction_Multiplication_Using_Constructors_
{
    public class ArithematicOperations
    {
       public double number_1;
        public double number_2;
        public ArithematicOperations(double num1, double num2)
        {
            number_1 = num1;
            number_2 = num2;
        }
       

        public int add()
        {
            double result = number_1 + number_2;
            return Convert.ToInt32(result);
        }

        public int sub()
        {
            double result = number_1 - number_2;
            return Convert.ToInt32(result);
        }

        public double div()
        {
            double result = number_1 / number_2;
            return result;
        }
        public int mul()
        {
            double result = number_1 * number_2;
            return Convert.ToInt32(result);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            char yesOrno = 'y';
            do
            {
                Console.WriteLine("Enter Number  1  & Number  2:- ");
                ArithematicOperations obj = new ArithematicOperations(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

                Console.WriteLine("Enter The Operation to Perform :- \nAdd [1] \nSub [2] \nMultiply [3] \nDivide [4]");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Addition Result is :-"+ obj.add());
                        
                        break;
                    case 2:
                        Console.WriteLine("Substraction Result is :-"+ obj.sub());
                        
                        break;
                    case 3:
                        Console.WriteLine("Multiplication Resullt is :-" + obj.mul());
                        
                        break;
                    case 4:
                        Console.WriteLine("Division Result is :-" + obj.div());
                       
                        break;
                    default:
                        Console.WriteLine("Invalid Choice !");
                        break;
                }
                Console.WriteLine("Press 'y' to Continue Operations :- \nOr Press 'n' to Exit :-");
                yesOrno =Convert.ToChar(Console.ReadLine());
            }while (yesOrno == 'y');
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2_BookShop
{

    public class BookShop
    {
        public string NameOfAuthor { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Publisher { get; set; }

        public void AssignValues()
        {
            Console.WriteLine("Enter the Author Name :- ");
            NameOfAuthor = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Book Title :- ");
            Title = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Book Price:- ");
            Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Book Publisher :- ");
            Publisher = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Printing The Result......");
            Console.WriteLine("-----------------------------------------------------------------------------");
            DisplayValues();
        }
        public void DisplayValues()
        {
            Console.WriteLine(" The Author Name :- "+NameOfAuthor);
            Console.WriteLine(" The Book Title :-  "+Title);
            Console.WriteLine(" The Book Price :- "+Price);
            Console.WriteLine(" The Book Publisher :- "+Publisher);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BookShop bookShop = new BookShop();
            bookShop.AssignValues();

            Console.WriteLine("-------------------------------------------------------------------------");

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apples_Or_Oranges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please press enter to continue story.");
            Console.WriteLine("Please Enter Name...");

            var Name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Hello, " + Name);
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("What's Up " + Name);

            var A1 = Console.ReadLine();

            Console.WriteLine(A1);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Do you like apples or oranges?");

            var fav1 = Console.ReadLine();

            if (fav1 == "oranges")
            {
                Console.Clear();
                Console.WriteLine("\nMe Too");
            }
            else if (fav1 == "apples")
            {
                Console.Clear();
                Console.WriteLine("we are so different");
            }
            Console.ReadKey();


        }
    }
}

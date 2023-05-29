using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM_michal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture =new System.Globalization.CultureInfo("en-US");
           
            Product[] products = { new Product("milk", 9, 7), new Product("chicken", 15, 30), new Product("fish", 15, 65) };
            //Product milk = new Product("milk",9,7);
            //Product Chicken = new Product("chicken", 15, 30);
            //Product fish  = new Product("fish", 15, 65);           
            while (true)
            {
                Loop(products);
            }
        }
        static void Loop(Product[] products)
        {
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("enter your Name :");
            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine();
            Console.Clear() ;          
            for (int i = 0; i < products.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"[{i + 1}]: ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(products[i]);
            }

            Console.WriteLine($"Please choose product (1-{products.Length})");

            int choice = ReadNumber("Please write only numbers, try again: ");
            while (choice < 1 || choice > products.Length)
            {
                Console.WriteLine("Sorry, we can't find this product... try again");
                choice = ReadNumber("Please write only numbers, try again: ");
            }
            Console.Clear();
            Console.Write("Thank you, ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nInvoce:\n{products[choice - 1]}");
            Console.ReadKey();
        }
        static int ReadNumber(string error = "Invalid")
        {
            int res = 0;
            while (!int.TryParse(Console.ReadLine(), out res))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error);
                Console.ForegroundColor = ConsoleColor.White;
            }
            return res;
        }
    }
}

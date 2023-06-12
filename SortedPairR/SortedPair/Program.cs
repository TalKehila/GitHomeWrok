using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
namespace SortedPair
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test1();
            //TestPoint();
        }
        static void Test1()
        {
            bool stop= false;
            List<SortedPair<string>> mysortpair = new List<SortedPair<string>>();// creating list 
            
            do
            {
                Console.WriteLine("give the first  word ");
                string First=Console.ReadLine();
                Console.WriteLine("give the secound  word ");
                string Sceound = Console.ReadLine();
                try
                {
                    SortedPair<string> myList = new SortedPair<string>(First, Sceound);//creating instance
                    Console.WriteLine(myList);
                    mysortpair.Add(myList);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("do you want to contin press Y to continu or N to stop ");
                     string choice=Console.ReadLine();
                    if(choice == "y")
                    {
                        stop = true;
                    }
                    
                }              
            }
            while(stop);                 
        }
        static void TestPoint()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    
                    Point p1 = new Point();
                    Point p2 = new Point();
                    p1.X = rnd.Next(100);
                    p1.Y = rnd.Next(100);
                    p2.X = rnd.Next(100);
                    p2.Y = rnd.Next(100);

                    if (!(p1 is Point))
                    {
                        throw new ArgumentException();
                    }
                    if (p1.X < p2.X && p1.X < p2.Y)
                        Console.WriteLine($" pair ({p1.X}),({p1.Y}) smaller then ({p2.X}),({p2.Y})");
                    if (p1.X > p2.X && p1.X > p2.Y)
                        Console.WriteLine($" pair ({p1.X}),({p1.Y}) bigger then  ({p2.X}),({p2.Y})");
                    if (p1.X == p2.X && p1.Y == p2.Y)
                        Console.WriteLine($" pair ({p1.X}),({p1.Y}) = {p2.X},({p2.Y}) the points are even ");
                    if (p1.X > p2.X && p1.X < p2.Y)
                        Console.WriteLine($" pair ({p1.X}),({p1.Y}) = ({p2.X}),({p2.Y})the points are even");
                    if (p1.X < p2.X && p1.X > p2.Y)
                        Console.WriteLine($" pair ({p1.X}),({p1.Y}) = ({p2.X}),({p2.Y})the points are even");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Illgal pair " + e.Message);
                }
            }

        }
    }
}

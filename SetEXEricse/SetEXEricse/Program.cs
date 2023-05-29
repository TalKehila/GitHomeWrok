using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetEXEricse
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            B();
          
        }
        private static Set RandomSet(Random random)
        {
            int[] randomNumber = new int[12];
            for (int i = 0; i < randomNumber.Length; i++)
                randomNumber[i] = random.Next(1001);

            return new Set(randomNumber);
        }

        public static void B()
        {
            Random random = new Random();

            Set setA = RandomSet(random);
            Set setB = RandomSet(random);
            Console.WriteLine("setA: " + setA.ToString());
            Console.WriteLine("setB: " + setB.ToString()); // סעיף א 

            Set setACopy = new Set(setA);
            setACopy.Union(setB);
            Console.WriteLine("setA union setB: " + setACopy.ToString());// סעיף ב 

            setACopy = new Set(setA);
            setACopy.Intersect(setB);
            Console.WriteLine("setA intersect setB: " + setACopy.ToString());// סעיף ב 
            Console.WriteLine("");
            int[] arr = new int[3];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("(" + i + ") ");
                arr[i] = getInputNumberFromUser();
            }            
            Set setC = new Set(arr);
            
           Console.WriteLine("setC: " + setC.ToString());

            Console.WriteLine("is setC subset of setA: " + setC.Subset(setA));
            Console.WriteLine("is setC subset of setB: " + setC.Subset(setB));// subset

           int ismembernumer= getInputNumberFromUser();
            setA.IsMember(ismembernumer);
            Console.WriteLine(" the number is member of Set A :" + setA.IsMember(ismembernumer));


            int number = getInputNumberFromUser();
            setA.Insert(number);
            setB.Insert(number);
            setC.Insert(number);
            Console.WriteLine("setA: " + setA.ToString());
            Console.WriteLine("setB: " + setB.ToString());
            Console.WriteLine("setC: " + setC.ToString());

            number = getInputNumberFromUser();
            setA.Delete(number);
            setB.Delete(number);
            Console.WriteLine(" Delete");// only to know which method when you running the program 
            Console.WriteLine("setA: " + setA.ToString());
            Console.WriteLine("setB: " + setB.ToString());
        }
        public static int getInputNumberFromUser()
        {
            Console.WriteLine("Enter Number between 0 to 1000");
            int input;
            bool receivedNumber = int.TryParse(Console.ReadLine(), out input);

            if (receivedNumber && input >= 0 && input <= 1000)
                return input;

            Console.WriteLine("Invalid input, try again");
            return getInputNumberFromUser();
        }
    }
}
//Set emptySet = new Set();
//Set s0 = new Set(1, 2, 3, 4, 5, 6, 3, 5, 88);//union
//Set s1 = new Set(1, 2, 4, 6, 8, 9);//union
//Set s2 = new Set(1, 2, 33, 22, 87, 9);//intersect
//Set s3 = new Set(1, 2, 22, 54, 34, 23, 12);//intersect
//Set s4 = new Set(1, 2, 3, 4);//subset 
//Set s5 = new Set(1, 2, 3, 4, 5);//subset
//Set s6 = new Set(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);// is member
//Set s7 = new Set(1, 2, 3, 4, 5, 6);//insert
//Set s8 = new Set(1, 2, 4, 5, 8, 3);//delete


//Console.WriteLine("s1: " + s1.ToString());
//Console.WriteLine("s0: " + s0.ToString());
//Console.WriteLine("s1 union s0..");
//s1.Union(s0);
//Console.WriteLine("s1: " + s1.ToString());

//Console.WriteLine("");

//Console.WriteLine("s3: " + s3.ToString());
//Console.WriteLine("s2: " + s2.ToString());
//Console.WriteLine("s3 intesect s2..");
//s3.Intersect(s2);
//Console.WriteLine("s3: " + s3.ToString());

//Console.WriteLine("s4: " + s4.ToString());
//Console.WriteLine("s5: " + s5.ToString());
//Console.WriteLine("s4 subset s5..");
//Console.WriteLine(s4.Subset(s5));

//Console.WriteLine(s6.IsMember(88));

//s7.Insert(9999);
//Console.WriteLine("s7: " + s7.ToString());


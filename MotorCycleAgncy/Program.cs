using MotorCycleAgncy;
using System;
using System.ComponentModel;

class Program
{
    static void Main()//פונקציה main 
    {
      //יצירת מערך בשם בייקס מסוג מערך מוטורסייקל 4 איברים (כלומר 4 אופנועים
        Console.WriteLine("choose motorbike from the list");

        MotorCycle[] bikesArr = new MotorCycle[4];//הגדרת המערך

        bikesArr[0]= new MotorCycle("SV650", "Suziki", 2022, 34000, 48000);//מופע 
        bikesArr[1] = new MotorCycle("z900", "Kwasaki", 2023, 56000, 68000);// מערך של אובייקטים 
        bikesArr[2] = new MotorCycle("gs1200", "BMW", 2021, 32000, 148000);
        bikesArr[3] = new MotorCycle("R1", "yamaha", 2020, 13000, 58000);

        for (int i = 0; i < 4; i++)
            bikesArr[i].PrintMe();
        
        int choice = int.Parse(Console.ReadLine());
       
        Console.WriteLine("the price is : "  + bikesArr[choice - 1].getprice()); //גישה ישר למיקום המערך שמשתמש בחר 
    }
    
}


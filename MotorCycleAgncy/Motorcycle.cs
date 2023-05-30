using MotorCycleAgncy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorCycleAgncy
{
    class MotorCycle
    {
        //initialize variables
        private string model;
        private string manufacturer;
        private int year;
        private int km;
        private int price;
        //constractor
        public MotorCycle()
        {
            model = "";
            manufacturer = "";
            year = 0;
            km = 0;
            price = 0;
        }


        //constarctor with parameter 
        public MotorCycle(string _model, string _manufacturer, int _year, int _km, int _price)//משתנים 
        {
            model = _model;
            manufacturer = _manufacturer;
            year = _year;
            km = _km;
            price = _price;

        }
          
        public void PrintArray(MotorCycle[] array)
        {
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine(array[i].toString());//we call o method
            }
        }

        public void PrintMe()// פונקציית הדפסה עם סרינט לאינט 
        {
                Console.WriteLine("model:" + model + " manufacturer:" + manufacturer + " year:" + year.ToString() + " km:" + km.ToString() +" Price:" + price.ToString());//we call o method
        }

        //השיטה שלי 
        public string toString()//מחזיר את מה שאני רוצה  שייצג את המופע 
        {
            string str = model +  ", "+ manufacturer + ", " + year + ", " + km + ", " + price; // שרשור סטרינגים 

            return str;
        }

        public int getprice()// 
        {
            
                return price;
        }

    }
}

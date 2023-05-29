using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HM_michal
{
    class Product
    {
        private string _name = "";
        private double _price;
        private DateTime  _expirationDate;
       
        public Product(string name, int numday, double price = 100)
        {
            SetName(name);
            SetPrice(price);
            SetWarrantyExpirationDate(numday);
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }

        public void SetPrice(double price)
        {
            if (price > 0)
            {
                _price = price;
            }
        }
        public double GetPrice()
        {
            return _price;
        }
       
        public void SetWarrantyExpirationDate(int numDays)
        {
            if (numDays >= 0)
            {
                _expirationDate = DateTime.Now.AddDays(numDays);
            }
        }

        public DateTime GetWarrantyExpirationDate()
        {
            return _expirationDate;
        }

        public string GetFormattedWarrantyExpirationDate()
        {
            return $"Warranty expiration date: {_expirationDate.ToString("dd/MM/yyyy")}";
        }
        public override string ToString()
        {            
            DateTime dt = DateTime.Now;
            string theDate = $"{dt:F}";
            int days = (int)(_expirationDate - DateTime.Now).TotalDays;
            return $"product : {_name}\nprice : {_price}\nexp date: {(theDate)}(left {days} days) ";
        }
    }
}

//and {24 - _expirationDate.Subtract(TimeSpan.FromDays(days)).Hour} Hours) \n
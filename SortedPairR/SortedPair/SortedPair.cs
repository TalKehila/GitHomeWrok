using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortedPair
{
    class SortedPair<T> where T : IComparable<T>
    {
        private T smaller, larger;
        public T First { get { return smaller; } set { smaller = value; } }
        public T Second { get { return larger; } set { larger = value; } }
      
        public SortedPair(T first, T secound)
        {
            if (first.Equals(secound))
            {
                throw new IllegalPair("the words are the same.");
            }
            if (first.CompareTo(secound) < 0)
            {
                smaller = first;
                larger = secound;
            }
            else
            {
                smaller = secound;
                larger= first;
            }         
        }    
        public override string ToString()
        {
       
            return $"Smaller obj:{First} , Larger obj: {Second}";
        }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            SortedPair<T> otherPair = (SortedPair<T>)obj;

            return First.Equals(otherPair.First) && Second.Equals(otherPair.Second);
        }
    }
}



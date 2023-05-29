using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Lifetime;

namespace SetEXEricse
{
    class Set
    {
        private bool[] set;
        private int size;

        public Set()
        {
            //creating empty set
            //making new bool arr 
            set = new bool[1001];
            size = 0;
        }
        public Set(params int[] numbers) : this()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] >= 0 && numbers[i] <= 1000)
                {
                    set[numbers[i]] = true;
                    size++;
                }
            }
        } 

        public Set(Set other) : this()
        {
            for(int i = 0;i<set.Length;i++)
                this.set[i] = other.set[i];
            
            this.size = other.size;
        }

        public void Union(Set other)
        {
            for (int i = 0; i < other.set.Length; i++)
            {
                if (!this.set[i] && other.set[i])
                {
                    set[i] = true;
                    size++;
                }
            }
        }
        public void Intersect(Set other)
        {
            for (int i = 0; i < set.Length; i++)
            {
                // run for the current set

                bool notInOther = this.set[i] && !other.set[i];
                bool notInThis = !this.set[i] && other.set[i];

                // Same, but less logical. its better not to remove something that doesn't exists in the set.
                // bool notInOther = !otherSet.set[i];
                // bool notInThis = !this.set[i];
                if (notInThis || notInOther)
                {
                    // if there is a true value so there is same value in both set 
                    set[i] = false;
                    size--;
                }
            }
        }
        public bool Subset(Set other)
        {
            for (int i = 0; i < set.Length; i++)
            {
                if (this.set[i] && !other.set[i])
                    return false;
            }
            return true;
        }
        public bool IsMember(int number)
        {
            bool notInBorder = number < 0 || number >= set.Length;
            if (notInBorder)
                return false;

            return set[number];
        }
        public void Insert(int number)
        {
            bool inBorder = number >= 0 && number < set.Length;
            if (inBorder)
            {
                if (set[number])
                    return;

                set[number] = true;
                size++;
            }
        }
        public void Delete(int number)
        {
            bool inBorder = number >= 0 && number < set.Length;
            if (inBorder)
            {
                if (!set[number])
                    return;

                set[number] = false;
                size--;
            }
        }
        public override string ToString()
        {
            // ex. {1,2,3,6}
            string str = "{";
            for (int i = 0; i < set.Length; i++)
            {
                if (set[i])
                {
                    if (str.Equals("{"))
                        str += i;

                    else
                        str += "," + i;
                }
            }
            str += "}";
            return str;
        }
    }
}




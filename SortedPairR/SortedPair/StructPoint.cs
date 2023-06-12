using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SortedPair
{
    struct Point
    {
        public event Action<int> PointChanged;
        private int _x, _y;

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
                PointChanged?.Invoke(_x);
            }
        }
        public int Y
        {
            get
            {
                return _y;
            }

            set
            {
                _y = value;
                PointChanged?.Invoke(_y);
            }
        }
      
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace Laba7_2
{
    class Sort<T> : IComparer<T>
        where T : Net
    {
        //Борг, сума абонплати

        public int Compare(T x, T y)
        {
            if (x.Debt< y.Debt)
                return 1;
            else if (x.Debt > y.Debt)
                return -1;

            else if (x.Sum < y.Sum)
                return 1;

            else if (x.Sum > y.Sum)
                return -1;

            else
                return 0;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace bai5
{
    class sort
    {
        public static int giatrilonnhat(int a, int b, int c)
        {
            int max = a;
            if (b > max)
                max = b;
            if (c > max)
                max = c;
            return max;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    static class DelegateImplClass
    {

        public delegate int mDelegate(double x, int y);

        public static int mainMethod(double x, int y)
        {
            return Convert.ToInt32(Math.Pow(x,3)) + Convert.ToInt32(x) + y;
        }

        public static void DelegateMethod(double x, int y, mDelegate del)
        {
            Console.WriteLine(del(x, y));
        }

        public static void DelegateFunc(double x, int y, Func<double,int,int> del)
        {
            Console.WriteLine(del(Convert.ToInt32(x), y));
        }
    }
}

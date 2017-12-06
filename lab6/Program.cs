using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        

        static void Main(string[] args)
        {

            // метод, соответствующий данному делегату
            DelegateImplClass.mDelegate mDelegate = new DelegateImplClass.mDelegate(DelegateImplClass.mainMethod);
            Console.WriteLine(mDelegate(4.0, 2));

            //метод, принимающий разработанный Вами делегат, в качестве
            //одного из входным параметров (метод+лямбда)
            DelegateImplClass.DelegateMethod(3.0, 3,mDelegate);
            DelegateImplClass.DelegateMethod(6.0, 8, (x,y) => Convert.ToInt32(Math.Pow(x, 3)) + Convert.ToInt32(x) + y);

            //обобщенный делегат Func<>,соответствующий сигнатуре
            //разработанного делегата
            DelegateImplClass.DelegateFunc(10.0, 1500,DelegateImplClass.mainMethod);
            DelegateImplClass.DelegateFunc(4.0, 200, (x, y) => Convert.ToInt32(Math.Pow(x, 3)) + Convert.ToInt32(x) + y);
        }
    }
}
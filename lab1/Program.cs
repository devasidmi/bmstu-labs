using System;

namespace lab1
{
    internal class Program
    {
        private class Equation
        {
            public double a, b, c;


            /// <summary>
            /// Ввод данных
            /// </summary>
            /// <returns>Возвращает число</returns>
            public static double EnterData()
            {
                double value;
                while (!Double.TryParse(Console.ReadLine(), out value))
                {
                    Console.Write("Enter valid data\n");
                }
                return value;
            }

            /// <summary>
            /// Считает дискриминант
            /// </summary>
            /// <returns>Возвращает значение дискриминанта </returns>
            private double calcDiscriminant()
            {
                return Math.Pow(b, 2) - 4 * a * c;
            }

            /// <summary>
            /// Расчет корней уравнения
            /// </summary>
            public void calcRoots()
            {
                double d = calcDiscriminant();
                if (d < 0)
                {
                    Console.Write("The roots on the set of real numbers don't exist");
                    return;
                }

                if (d == 0)
                {
                    Console.Write("Answer is {0}", -b / (2 * a));
                    return;
                }

                if (d > 0)
                {
                    Console.Write("Answer is {0} and {1}", (-b + Math.Sqrt(d)) / (2 * a),
                        (-b - Math.Sqrt(d)) / (2 * a));
                }
            }
        }

        public static void Main(string[] args)
        {
            Equation mEquation = new Equation();

            mEquation.a = Equation.EnterData();
            mEquation.b = Equation.EnterData();
            mEquation.c = Equation.EnterData();


            mEquation.calcRoots();
        }
    }
}
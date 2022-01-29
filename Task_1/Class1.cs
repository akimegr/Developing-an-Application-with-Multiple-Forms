using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3rpvs
{
    class Class1
    {
        public static double HSIN(double x)
        {
            return Math.Sin(x);
        }
        public static void Printer(double x1, double sum, ref string s)
        {
            s += "При x: " + x1.ToString() + " сумма: " + sum + " При sin(x): " + HSIN(x1) + "\r\n";
        }

        public static int factorial(int fa, int NN, int countFa)
        {
            while (countFa <= (2 * NN + 1))
            {
                fa *= countFa;
                countFa++;
            }
            return fa;
        }

        public static double answ(int NN, double x1, int fa)
        {
            return Math.Pow((-1), NN) * Math.Pow(x1, (2 * NN + 1)) / (fa);
        }
    }
}

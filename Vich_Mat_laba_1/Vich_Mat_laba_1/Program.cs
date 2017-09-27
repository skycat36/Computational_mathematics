using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vich_Mat_laba_1
{
    class Program
    {
        public static double Func(double x)
        {
            return Math.Sinh(x);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество узлов интерполяции: ");
            int n = Convert.ToInt32(Console.ReadLine());
            TableInterp[] table = new TableInterp[n];
            double temp;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите значение точки Х в [" + i + "] узле интерполяции: ");
                temp = Convert.ToDouble(Console.ReadLine());
                table[i] = new TableInterp(temp, Func(temp));
                Console.WriteLine("");
            }
            Inter inter = new Inter(table);
            Console.WriteLine("Введите значение в котором нужно вычислить Бариационный многочлен Лагранжа");
            inter.Set_ArgX(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(Convert.ToString(inter.LagrangInterp()));
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyModules10_Ex1
{
    internal class Colculater : IColCulate
    {
        public double Colculate(double first, double second) => first + second;
        

        public void WorkCalculate()
        {
            double first;
            double second;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите два числа для сложения");
                    first = Convert.ToDouble(Console.ReadLine());
                    second = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Сумма этих числе равна: {Colculate(first,second)}");
                }
                catch
                {
                    Console.WriteLine("Введите корректные значения");
                }
            }
        }
    }
}

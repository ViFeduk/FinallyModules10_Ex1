using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyModules10_Ex1
{
    internal class Colculater : IColCulate
    {
        ILogger Logger {  get;}
        public Colculater(ILogger logger)
        {

            Logger = logger;

        }
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

                    Logger.Log($"Сумма этих числе равна: {Colculate(first,second)}");
                }
                catch
                {
                    Logger.Error("Введите корректные значения");
                }
            }
        }
    }
}

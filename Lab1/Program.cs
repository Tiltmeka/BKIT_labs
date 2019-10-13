using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Якубов Артём, ИУ5-33Б";
            double[] coef = new double[3];
            double D, x1, x2, y1, y2, y3, y4;
            bool ok;
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Введите {0} коэффициент:", i + 1);
                ok = double.TryParse(Console.ReadLine(), out coef[i]);
                while (!ok)
                {
                    Console.WriteLine("Введен некоректный  {0} коэффициент! Повторите:", i + 1);
                    ok = double.TryParse(Console.ReadLine(), out coef[i]);
                }

            }
            D = coef[1] * coef[1] - 4 * coef[0] * coef[2];
            Console.WriteLine("D={0}", D);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Корни квадратного уравнения");
            Console.ResetColor();
            if (D >= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                x1 = (-coef[1] + Math.Sqrt(D)) / (2 * coef[0]);
                x2 = (-coef[1] - Math.Sqrt(D)) / (2 * coef[0]);
                Console.WriteLine("x1={0} " + Environment.NewLine + "x2={1}", x1, x2);
                Console.ResetColor();
                if (x1 >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Корни биквадратного уравнения");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    y1 = Math.Sqrt(x1);
                    y2 = Math.Sqrt(x1) * (-1);
                    Console.WriteLine("y1={0} " + Environment.NewLine + "y2={1}", y1, y2);
                    Console.ResetColor();
                }
                if (x1 < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Корень меньше нуля");
                    Console.ResetColor();
                }
                if (x2 >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Корни биквадратного уравнения");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    y3 = Math.Sqrt(x1);
                    y4 = Math.Sqrt(x1) * (-1);
                    Console.WriteLine("y3={0} " + Environment.NewLine + "y4={1}", y3, y4);
                    Console.ResetColor();
                }
                if (x2 < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Корень меньше нуля");
                    Console.ResetColor();
                }
            }
            if (D < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                x1 = (-coef[1] / (2 * coef[0]));
                x2 = Math.Sqrt(Math.Abs(D)) / (2 * coef[0]);
                Console.WriteLine("x1={0}+{1:F3}i" + Environment.NewLine + "x2={0}-{1:F3}i", x1, x2);
                Console.ResetColor();
            }
            Console.ReadKey();

        }
    }
}

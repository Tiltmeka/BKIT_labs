﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ваши параметры командной строки: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            Console.WriteLine(args[2]);
            Console.ResetColor();
            Console.Title = "Якубов Артём, ИУ5-33Б";
            double[] coef = new double[3];
            double[] param = new double[3];
            double D, x1, x2, y1, y2, y3, y4;
            bool ok;
 
            try
            {
                param[0] = Convert.ToDouble(args[0]);
                coef[0] = param[0];
                param[1] = Convert.ToDouble(args[1]);
                coef[1] = param[1];
                param[2] = Convert.ToDouble(args[2]);
                coef[2] = param[2];
            }
            catch
            {
                Console.WriteLine("Введен неверный коефициент командной строки!");
                Thread.Sleep(50000);
                Environment.Exit(0);
            }
            D = coef[1] * coef[1] - 4 * coef[0] * coef[2];
            Console.WriteLine("D={0}", D);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Корни квадратного уравнения");
            Console.ResetColor();
            if (coef[0] == 0 && coef[1] == 0 && coef[2] == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корни - любое число");
                Console.ResetColor();
                Thread.Sleep(50000);
                Environment.Exit(0);
            }
            if (coef[0] == 0 && coef[1] == 0 && coef[2] == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корень квадратного уравнения равен - " + coef[2]);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Корни биквадратного уравнения");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корни биквадратного уравнения будут равны +/- 1 ");
                Thread.Sleep(50000);
                Environment.Exit(0);
            }
            if (coef[0] == 0 && coef[1] == 1 && coef[2] == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корень квадратного уравнения равен - " + coef[2] * (-1));
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Корни биквадратного уравнения");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корни биквадратного уравнения отсутствуют");
                Thread.Sleep(50000);
                Environment.Exit(0);
            }
            if (coef[0] == 0 && coef[1] == 1 && coef[2] == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корень квадратного уравнения равен - 0");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Корни биквадратного уравнения");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корни биквадратного уравнения также будут равны 0");
                Thread.Sleep(50000);
                Environment.Exit(0);
            }
            if (coef[0] == 1 && coef[1] == 0 && coef[2] == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корень квадратного уравнения равен - 0");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Корни биквадратного уравнения");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корни биквадратного уравнения также будут равны 0");
                Thread.Sleep(50000);
                Environment.Exit(0);
            }
            if (D >= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                x1 = (-coef[1] + Math.Sqrt(D)) / (2 * coef[0]);
                x2 = (-coef[1] - Math.Sqrt(D)) / (2 * coef[0]);
                Console.WriteLine("x1={0} " + Environment.NewLine + "x2={1}", x1, x2);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Корни биквадратного уравнения");
                Console.ResetColor();
                if (x1 >= 0)
                {

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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Корни биквадратного уравнения");
                Console.ResetColor();
                if (x2 >= 0)
                {

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
                Console.WriteLine("Дискриминант меньше нуля, корней нет");
                Console.ResetColor();

            }
           
        










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
            if (coef[0] == 0 && coef[1] == 0 && coef[2] == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корни - любое число");
                Console.ResetColor();
                Thread.Sleep(50000);
                Environment.Exit(0);
            }
            if (coef[0] == 0 && coef[1] == 0 && coef[2] == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корень квадратного уравнения равен - " + coef[2]);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Корни биквадратного уравнения");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корни биквадратного уравнения будут равны +/- 1 ");
                Thread.Sleep(50000);
                Environment.Exit(0);
            }
            if (coef[0] == 0 && coef[1] == 1 && coef[2] == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корень квадратного уравнения равен - " + coef[2] * (-1));
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Корни биквадратного уравнения");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корни биквадратного уравнения отсутствуют");
                Thread.Sleep(50000);
                Environment.Exit(0);
            }
            if (coef[0] == 0 && coef[1] == 1 && coef[2] == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корень квадратного уравнения равен - 0");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Корни биквадратного уравнения");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корни биквадратного уравнения также будут равны 0");
                Thread.Sleep(50000);
                Environment.Exit(0);
            }
            if (coef[0] == 1 && coef[1] == 0 && coef[2] == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корень квадратного уравнения равен - 0");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Корни биквадратного уравнения");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Корни биквадратного уравнения также будут равны 0");
                Thread.Sleep(50000);
                Environment.Exit(0);
            }
            if (D >= 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                x1 = (-coef[1] + Math.Sqrt(D)) / (2 * coef[0]);
                x2 = (-coef[1] - Math.Sqrt(D)) / (2 * coef[0]);
                Console.WriteLine("x1={0} " + Environment.NewLine + "x2={1}", x1, x2);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Корни биквадратного уравнения");
                Console.ResetColor();
                if (x1 >= 0)
                {

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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Корни биквадратного уравнения");
                Console.ResetColor();
                if (x2 >= 0)
                {

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
                Console.WriteLine("Дискриминант меньше нуля, корней нет");
                Console.ResetColor();

            }
            Console.ReadKey();

        }
    }
}

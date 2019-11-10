using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Якубов Артём, ИУ5-33Б";
            Rect rect = new Rect(50, 2.5);
            Square square = new Square(6);
            Circle circle = new Circle(2);
            rect.Print();
            square.Print();
            circle.Print();
            Console.ReadLine();
        }
    }
}

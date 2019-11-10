using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2csharp
{
    class Rect : Figure, IPrint
    {
        public double Hight { get; set; }
        public double Width { get; set; }
        public Rect(double h, double w)
        {
            this.Hight = h;
            this.Width = w;
            this.Type = "Прямоугольник";
        }
        public override double Area()
        {
            double Result = this.Width * this.Hight;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}

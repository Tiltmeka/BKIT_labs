using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2csharp
{
    class Circle : Figure, IPrint
    {
        double Radius{get;set;}
        public Circle(double pr)
        {
            this.Radius = pr;
            this.Type = "Круг";
        }

        public override double Area()
        {
            double Result = Math.PI * this.Radius * this.Radius;
            return Result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}

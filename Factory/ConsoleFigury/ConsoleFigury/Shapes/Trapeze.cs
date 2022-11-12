using ConsoleFigury.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigury.Shapes
{
    public class Trapeze : Shape
    {
        public double a, b, h;

        public override void CalculateField()
        {
            Console.WriteLine("Podaj podstawę a:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj podstawę b:");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wysokość:");
            h = double.Parse(Console.ReadLine());


            double field = ((a+b)*h)/2;
            Console.WriteLine($"Pole prostokąta wynosi: {field}cm");
        }
    }
}

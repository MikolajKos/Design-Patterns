using ConsoleFigury.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigury.Shapes
{
    public class Rectangle : Shape
    {
        public double height, width;

        public override void CalculateField()
        {
            Console.WriteLine("Podaj wysokość prostokąta:");
            height = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj szerokość prostokąta:");
            width = double.Parse(Console.ReadLine());

            double field = width * height;
            Console.WriteLine($"Pole prostokąta wynosi: {field}cm");
        }
    }
}

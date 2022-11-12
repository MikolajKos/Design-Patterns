using ConsoleFigury.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigury.Shapes
{
    public class Circle : Shape
    {
        public double radius;

        public override void CalculateField()
        {
            Console.WriteLine("Podaj promień koła:");
            radius = double.Parse(Console.ReadLine());

            double field = 3.14 * (radius * radius);
            Console.WriteLine($"Pole koła wynosi: {field}cm");
        }
    }
}

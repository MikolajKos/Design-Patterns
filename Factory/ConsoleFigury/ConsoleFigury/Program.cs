using ConsoleFigury.Factory;
using System;

namespace ConsoleFigury
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wybierz pole które chcesz obliczyć.");
            Console.WriteLine("1 - Prostokąt");
            Console.WriteLine("2 - Koło");
            Console.WriteLine("3 - Trapez");
            int choice = int.Parse(Console.ReadLine());

            var shapeFactory = new ShapeFactory();

            switch (choice)
            {
                case 1:
                    var rectangle = shapeFactory.CreateShape(ShapeType.Rectangle);
                    rectangle.CalculateField();
                    break;
                case 2:
                    var circle = shapeFactory.CreateShape(ShapeType.Circle);
                    circle.CalculateField();
                    break;
                case 3:
                    var trapeze = shapeFactory.CreateShape(ShapeType.Trapeze);
                    trapeze.CalculateField();
                    break;
                default:
                    Console.WriteLine("Wprowadzony typ jest nieprawidłowy.");
                    break;
            }
        }
    }
}

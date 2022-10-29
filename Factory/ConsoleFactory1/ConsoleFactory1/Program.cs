using System;

namespace ConsoleFactory1
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeFactory = new ShapeFactory();
            var circle = shapeFactory.CreateShape(ShapeType.Circle);

            circle.Render();
            circle.ShapeInfo();

            var triangle = shapeFactory.CreateShape(ShapeType.Triangle);

            triangle.Render();
            triangle.ShapeInfo();
        }
    }
}

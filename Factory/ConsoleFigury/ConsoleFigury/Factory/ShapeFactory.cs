using ConsoleFigury.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFigury.Factory
{
    public class ShapeFactory
    {
        public Shape CreateShape(ShapeType type)
        {
            switch (type)
            {
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Trapeze:
                    return new Trapeze();
                default:
                    throw new Exception($"Given type {type}, is not handled.");
            }
        }
    }
}

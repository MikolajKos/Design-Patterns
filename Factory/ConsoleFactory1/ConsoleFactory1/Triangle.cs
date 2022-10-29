using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactory1
{
    public class Triangle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render Triangle");
        }

        public override void ShapeInfo()
        {
            Console.WriteLine("This is triangle ~~ probably");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactory1
{
    public class Circle : Shape
    {
        public override void Render()
        {
            Console.WriteLine("Render Circle");
        }

        public override void ShapeInfo()
        {
            Console.WriteLine("Just a circle.");
        }
    }
}

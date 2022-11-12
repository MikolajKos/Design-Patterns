using FactoryInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryInterface.Products
{
    public class Computer : IProduct
    {
        public string Operation()
        {
            return "{Operation from Computer Class}";
        }
    }
}

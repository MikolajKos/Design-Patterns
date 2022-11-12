using FactoryInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryInterface.Products
{
    public class TV : IProduct
    {
        public string Operation()
        {
            return "{Operation from TV Class}";
        }
    }
}

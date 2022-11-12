using FactoryInterface.Interfaces;
using FactoryInterface.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryInterface.Factory
{
    public class ComputerCreator : Creator
    {
        public override IProduct CreateProduct()
        {
            return new Computer();
        }
    }
}

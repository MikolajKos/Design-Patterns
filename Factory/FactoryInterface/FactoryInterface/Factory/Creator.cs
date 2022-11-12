using FactoryInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryInterface.Factory
{
    public abstract class Creator
    {
        public abstract IProduct CreateProduct();

        public string SomeOperations()
        {
            var product = CreateProduct();
            var result = "Kod Kreatora: " + product.Operation();
            return result;
        }
    }
}

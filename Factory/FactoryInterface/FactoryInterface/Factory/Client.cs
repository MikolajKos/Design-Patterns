using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryInterface.Factory
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("Aplikacja: Uruchomiona z TVCreator");
            ClientCode(new TVCreator());
            Console.WriteLine("");

            Console.WriteLine("Aplikacja: Uruchomiona z ComputerCreator");
            ClientCode(new TVCreator());
            Console.WriteLine("");
        }

        private void ClientCode(Creator creator)
        {
            Console.WriteLine("Kod klienta: Nie znam klasy twórcy i nadal pracuję.");
            Console.WriteLine(creator.ToString());
            Console.WriteLine(creator.SomeOperations());
        }
    }
}

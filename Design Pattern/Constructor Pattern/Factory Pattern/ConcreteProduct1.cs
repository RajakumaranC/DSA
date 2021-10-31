using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.FactoryPattern
{
    public class ConcreteProduct1 : ISpecialProducts
    {
        public void DoNothing()
        {
            Console.WriteLine("I am doing nothing here. LOL!");
        }

        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}

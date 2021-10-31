using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.FactoryPattern
{
    public class ConcreteProduct2 : ISpecialProducts
    {
        public void DoNothing()
        {
            Console.WriteLine("I am also doing nothing here. Good Luck! Hehe :P");
        }

        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}

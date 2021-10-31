using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.FactoryPattern
{
    public class ConcreteCreator1 : Creator
    {
        public override IProducts FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}

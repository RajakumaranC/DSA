using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.FactoryPattern
{
    public abstract class Creator
    {
        public abstract IProducts FactoryMethod();

        public string Operation()
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();
            // Now, use the product.
            var result = "Creator: The same creator's code has just worked with "
                + product.Operation();

            return result;
        }

        //public abstract string Operation();
    }
}

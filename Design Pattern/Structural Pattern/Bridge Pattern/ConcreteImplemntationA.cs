﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.StructuralPattern
{
    // Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.
    public class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}

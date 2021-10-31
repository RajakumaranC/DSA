using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.BehavioralPattern
{
    public class StateDemo
    {
        public static void Start()
        {
            // The client code.
            var context = new StateContext(new ConcreteStateA());
            context.Request1();
            context.Request2();

            
        }
    }
}

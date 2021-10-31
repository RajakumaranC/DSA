using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.BehavioralPattern
{
    public class TemplateDemo
    {
        public static void Start()
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            TemplateClient.ClientCode(new ConcreteClass1());

            Console.Write("\n");

            Console.WriteLine("Same client code can work with different subclasses:");
            TemplateClient.ClientCode(new ConcreteClass2());
        }
    }
}

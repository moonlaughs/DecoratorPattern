using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ConcreteComponentTea : IComponentDrink
    {
        public int cost()
        {
            return 5;
        }

        public void size()
        {
            Console.WriteLine("tea is small");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ConcreteComponentCoffee : IComponentDrink
    {
        public int cost()
        {
            return 3;
        }

        public void size()
        {
            Console.WriteLine("coffe is of size medium");
        }
    }
}

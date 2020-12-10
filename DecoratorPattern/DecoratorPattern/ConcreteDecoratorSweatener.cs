using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ConcreteDecoratorSweatener : Decorator
    {
        public ConcreteDecoratorSweatener(IComponentDrink componentDrink) : base(componentDrink)
        {
        }

        public override int cost()
        {
            return 8;
        }
    }
}

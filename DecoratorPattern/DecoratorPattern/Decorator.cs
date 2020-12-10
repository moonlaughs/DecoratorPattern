using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Decorator : IComponentDrink
    {
        //List<IComponentDrink> cList = new List<IComponentDrink>();
        private IComponentDrink c;

        public Decorator(IComponentDrink componentDrink)
        {
            c = componentDrink;
        }
        public abstract int cost();

        public void size()
        {
            c.size();
        }
    }
}

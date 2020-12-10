using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator pattern");

            IComponentDrink tea = new ConcreteComponentTea();
            IComponentDrink coffee = new ConcreteComponentCoffee();
            ConcreteDecoratorSweatener d = new ConcreteDecoratorSweatener(tea);
            Console.WriteLine(d.cost());
        }
    }
}

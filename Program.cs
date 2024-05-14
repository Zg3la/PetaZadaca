using System;

namespace Zadaca5
{
    public  class Test
    {
        public static void Main(string[] args)
        {
            Coffee coffee = new Espresso();
            Console.WriteLine(coffee.GetCost());
            Console.WriteLine(coffee.GetDescription());
            Coffee milk = new Milk(coffee);
            Console.WriteLine(milk.GetCost());
            Console.WriteLine(milk.GetDescription());
            Coffee caramel = new Caramel(milk);
            Console.WriteLine(caramel.GetCost());
            Console.WriteLine(caramel.GetDescription());
        }
    }
}
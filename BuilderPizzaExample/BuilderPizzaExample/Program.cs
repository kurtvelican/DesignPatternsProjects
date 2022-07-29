using System;

namespace BuilderPizzaExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Waiter waiter = new Waiter();
            
            waiter.setPizzaBuilder(new HawaiianPizzaBuilder());
            waiter.constructPizza();
            Pizza pizza1 = waiter.getPizza();

        }
    }
}
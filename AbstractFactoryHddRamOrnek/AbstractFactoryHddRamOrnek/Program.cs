using System;

namespace AbstractFactoryHddRamOrnek
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Factory factory1 = new Factory(new Concrete1Factory());
            factory1.Birlestir();
            Console.WriteLine();

            Factory factory2 = new Factory(new Concrete2Factory());
            factory2.Birlestir();
            
        }
    }
}
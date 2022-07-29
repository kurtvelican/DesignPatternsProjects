using System;

namespace EEATelefonAdapterUygulama
{
    public class Priz
    {
        public void elektrikver(ElektrikliEvAletleri elektrikliEvAletleri)
        {
            int volt = elektrikliEvAletleri.prizeTakVeCalistir();
            Console.WriteLine("Prizden " + volt + " volt alınıyor");
        }
    }
}
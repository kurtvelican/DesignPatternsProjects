using System;

namespace EEATelefonAdapterUygulama
{
    public class Buzdolabi : ElektrikliEvAletleri
    {
        private int volt;

        public Buzdolabi()
        {
            this.volt = 220;
        }


        public int prizeTakVeCalistir()
        {
            Console.WriteLine("Buzdolabı çalışıyor");
            return volt;
        }
    }
}
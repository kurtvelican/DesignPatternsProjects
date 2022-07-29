using System;

namespace EEATelefonAdapterUygulama
{
    public class Utu : ElektrikliEvAletleri
    {
        private int volt;

        public Utu()
        {
            this.volt = 220;
        }

        public int prizeTakVeCalistir()
        {
            Console.WriteLine("Ütü çalışıyor");
            return volt;
        }
    }
}
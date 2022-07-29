using System;

namespace AkilliEvSistemiFacade
{
    public class Klima
    {
        private int sicaklik;

        public void guncelle(int sicaklik)
        {
            this.sicaklik = sicaklik;
            Console.WriteLine("Klima " + sicaklik + " dereceye ayarlandı");
        }

        public void ac()
        {
            Console.WriteLine("Klima açıldı");
        }

        public void kapat()
        {
            Console.WriteLine("Klima kapatıldı");
        }
    }
}
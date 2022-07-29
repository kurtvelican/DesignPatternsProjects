using System;

namespace AkilliEvSistemiFacade
{
    public class İsik
    {
        private bool []durum;

        public İsik(int adet)
        {
            durum = new bool [adet];
        }

        public void ac(int numara)
        {
            durum[numara] = true;
            Console.WriteLine(numara + " numaralı ışık açıldı");
        }

        public void kapat(int numara)
        {
            durum[numara] = false;
            Console.WriteLine(numara + " numaralı ışık kapatıldı");
        }
    }
}
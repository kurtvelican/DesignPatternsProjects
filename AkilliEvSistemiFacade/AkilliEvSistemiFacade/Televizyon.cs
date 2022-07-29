using System;

namespace AkilliEvSistemiFacade
{
    public class Televizyon
    {
        private int sesSeviyesi , kanalNumarasi;

        public Televizyon()
        {
            sesSeviyesi = 10;
            kanalNumarasi = 1;
        }

        public void ac()
        {
            Console.WriteLine("Televizyon açıldı");
        }

        public void kapat()
        {
            Console.WriteLine("Televizyon kapatıldı");
        }

        public void sesAzalt()
        {
            sesSeviyesi -= 1;
            Console.WriteLine("Televizyon ses seviyesi azaltıldı = " + sesSeviyesi);
        }

        public void sesArtir()
        {
            sesSeviyesi += 1;
            Console.WriteLine("Televizyon ses seviyesi artırıldı = " + sesSeviyesi);     
        }

        public void kanalAzalt()
        {
            kanalNumarasi -= 1;
            Console.WriteLine("Televizyon kanal numarasi azaltıldı = " + kanalNumarasi);
        }
        
        public void kanalArtir()
        {
            kanalNumarasi += 1;
            Console.WriteLine("Televizyon kanal numarasi artırıldı = " + kanalNumarasi);
        }
    }
}
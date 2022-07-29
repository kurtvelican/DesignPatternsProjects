using System;

namespace AdapterDikdortgenKare
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Dikdortgen hesapla = new Dikdortgen();
            Adapter alanHesapla = new Adapter();
            
            hesapla.setKenar(5,4);
            Console.WriteLine(hesapla.alanHesapla());
            
            alanHesapla.setKenar(5);
            Console.WriteLine(alanHesapla.alanHesapla());
        }
    }
}
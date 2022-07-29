using System;
using System.Collections.Generic;

namespace ChainOfResponsibilityDers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Kredi> islemler = new List<Kredi>();
            islemler.Add(new KrediSkor());
            islemler.Add(new OdemeGecikmesi());
            islemler.Add(new KefilUygunlugu());
            islemler.Add(new MaasYeterliligi());

            Musteri musteri = new Musteri(1600, 2, true, true);

            bool sonuc = true;
            
            foreach (var kredi in islemler)
            {
                sonuc &= kredi.kontrol(musteri);
            }

            /*for (int i = 0; i < islemler.Count - 1; i++)
            {
                islemler[i].SonrakineGec(islemler[i+1]);
            }

            sonuc = islemler[0].kontrol(musteri);*/

            if (sonuc)
            {
                Console.WriteLine("Kredi Onaylandı");
            }
            else
            {
                Console.WriteLine("Kredi Onaylanmadı");
            }
            
        }
    }
}
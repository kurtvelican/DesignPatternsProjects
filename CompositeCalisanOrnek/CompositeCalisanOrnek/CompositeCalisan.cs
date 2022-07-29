using System;
using System.Collections.Generic;

namespace CompositeCalisanOrnek
{
    public class CompositeCalisan : Calisan
    {
        private List<Calisan> calisanList;
        public CompositeCalisan(string ad, enPozisyon pozisyon) : base(ad, pozisyon)
        {
            calisanList = new List<Calisan>();
        }

        public void Ekle(Calisan c)
        {
            calisanList.Add(c);
        }

        public override void Goster()
        {
            Console.WriteLine("{0} {1}",base.Pozisyon.ToString(),base.Ad);

            foreach (var item in calisanList)
            {
                item.Goster();
            }
        }
    }
}
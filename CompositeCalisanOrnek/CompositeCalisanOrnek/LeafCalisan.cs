using System;

namespace CompositeCalisanOrnek
{
    public class LeafCalisan : Calisan
    {
        public LeafCalisan(string ad, enPozisyon pozisyon) : base(ad, pozisyon)
        {
        }

        public override void Goster()
        {
            Console.WriteLine("{0} {1}",base.Pozisyon.ToString(),base.Ad);
        }
    }
}
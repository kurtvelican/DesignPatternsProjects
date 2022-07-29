using System;

namespace ChainOfResponsibilityDers
{
    public class OdemeGecikmesi : Kredi
    {

        public override bool kontrol(Musteri musteri)
        {
            if (musteri.Gecikme < 3)
            {
                Console.WriteLine("Odeme gecikmesi onaylandı");
                return true;
            }
            else
            {
                Console.WriteLine("Odeme Gecikmesi reddedildi");
                return false;
            }
            
        }
    }
}
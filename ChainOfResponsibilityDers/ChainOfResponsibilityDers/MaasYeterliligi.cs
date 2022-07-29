using System;

namespace ChainOfResponsibilityDers
{
    public class MaasYeterliligi : Kredi
    {

        public override bool kontrol(Musteri musteri)
        {
            if (musteri.Maas == true)
            {
                Console.WriteLine("Maas yeterliligi onaylandı");
                return true;
            }
            else
            {
                Console.WriteLine("Maas yeterliligi reddedildi");
                return false;
            }
            
        }
    }
}
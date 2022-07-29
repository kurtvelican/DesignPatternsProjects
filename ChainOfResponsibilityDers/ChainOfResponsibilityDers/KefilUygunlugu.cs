using System;

namespace ChainOfResponsibilityDers
{
    public class KefilUygunlugu : Kredi
    {

        public override bool kontrol(Musteri musteri)
        {
            if (musteri.Kefil == true )
            {
                Console.WriteLine("Kefil uygunlugu onaylandı");
                return true;
            }
            else
            {
                Console.WriteLine("Kefil Uygunlugu reddedildi");
                return false;
            }
            
        }
    }
}
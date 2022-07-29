using System;

namespace ChainOfResponsibilityDers
{
    public class KrediSkor : Kredi
    {

        public override bool kontrol(Musteri musteri)
        {
            if (musteri.Skor > 1500)
            {
                Console.WriteLine("Kredi skoru onaylandı");
                return true;
            }
            else
            {
                Console.WriteLine("Kredi Skoru reddedildi");
                return false;
            }
            
        }
        
        
    }
}
using System;

namespace ChainOfResponsibilityDers
{
    public abstract class Kredi
    {
        public abstract bool kontrol(Musteri musteri);

        public void SonrakineGec(Kredi kredi)
        {
            SonrakineGec(kredi);
        }
    }
}
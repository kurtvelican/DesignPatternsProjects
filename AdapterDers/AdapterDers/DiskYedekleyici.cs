using System;

namespace AdapterDers
{
    public class DiskYedekleyici : IYedekleyici
    {
        public void Kaydet(string kaynak, string hedef)
        {
            Console.WriteLine(kaynak + " 'tan " + hedef +" 'e kopyalandi");
        }
    }
}
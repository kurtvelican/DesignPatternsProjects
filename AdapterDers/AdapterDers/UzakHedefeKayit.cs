using System;

namespace AdapterDers
{
    public class UzakHedefeKayit
    {
        
        public void UzakHedefeKaydet(string domain, string hedef,string kaynak)
        {
            baglantiKur();
            dosyaGonder(kaynak,domain+hedef);
            baglantiKapat();
        }

        private void baglantiKur(){}
        private void baglantiKapat(){}

        private void dosyaGonder(string s1, string s2)
        {
            Console.WriteLine(s1 + " 'den " + s2 + " 'e kopyalandı");
        }
        
    }
}
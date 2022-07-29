using System;

namespace BridgeDers
{
    public class Kagit : Nesne
    {
        private Renk renk;
        private Sekil sekil;

        public Kagit(Renk rnk)
        {
            renk = rnk;
            sekil = new Kare();
        }

        public Kagit(Sekil skl)
        {
            sekil = skl;
            renk = new Beyaz();
        }
        
        public Kagit(Renk rnk, Sekil skl)
        {
            renk = rnk;
            sekil = skl;
        }
        
        public void olustur()
        {
            Console.WriteLine("Kağıt nesnesi " + renk.renkGetir() + "renkte ve " + sekil.sekilGetir() + "şeklindedir.");
        }
    }
}
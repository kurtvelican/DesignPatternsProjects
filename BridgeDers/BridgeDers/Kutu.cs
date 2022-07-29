using System;

namespace BridgeDers
{
    public class Kutu : Nesne
    {
        private Renk renk;
        private Sekil sekil;
        
        public Kutu(Renk rnk)
        {
            renk = rnk;
            sekil = new Kare();
        }
        
        public Kutu(Sekil skl)
        {
            sekil = skl;
            renk = new Beyaz();
        }
        
        public Kutu(Renk rnk, Sekil skl)
        {
            renk = rnk;
            sekil = skl;
        }
        
        public void olustur()
        {
            Console.WriteLine("Kutu nesnesi " + renk.renkGetir() + "renkte ve " + sekil.sekilGetir() + "şeklindedir.");
        }
    }
}
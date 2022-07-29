using System;

namespace StrategyDers
{
    public class Yilbasi : Strategy
    {
        public void fiyatHesapla()
        {
            Console.WriteLine("95 tl");
        }
        
        /*
         public double fiyatHesapla(){
         return 95;
         }
         */

        public void arayuzSec()
        {
            Console.WriteLine("Yılbaşı arayüzü seçildi.");
        }
    }
}
using System;

namespace StrategyDers
{
    public class HaftaSonu : Strategy
    {
        public void fiyatHesapla()
        {
            Console.WriteLine("80 tl");
        }
        
        /*
        public double fiyatHesapla(){
        return 80;
        }
        */

        public void arayuzSec()
        {
            Console.WriteLine("Hafta Sonu arayüzü seçildi.");
        }
    }
}
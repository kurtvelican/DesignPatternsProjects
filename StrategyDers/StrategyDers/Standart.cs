using System;

namespace StrategyDers
{
    public class Standart : Strategy
    {
        public void fiyatHesapla()
        {
            Console.WriteLine("100 tl");
        }
        
        /*
        public double fiyatHesapla(){
        return 100;
        }
        */

        public void arayuzSec()
        {
            Console.WriteLine("Standart arayüz seçildi.");
        }
    }
}
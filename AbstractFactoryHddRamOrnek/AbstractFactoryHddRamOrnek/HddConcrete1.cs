using System;

namespace AbstractFactoryHddRamOrnek
{
    public class HddConcrete1 : HddAbstract
    {
        public override void HddIslem()
        {
            Console.WriteLine("HddConcrete1 birleştirildi.");
        }

        public override string HddTur { 
            get
            {
            return "Bu hdd türü : HddConcrete1";
            } 
        }
    }
}
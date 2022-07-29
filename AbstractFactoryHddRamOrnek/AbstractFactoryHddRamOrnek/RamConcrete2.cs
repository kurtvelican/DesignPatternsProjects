using System;

namespace AbstractFactoryHddRamOrnek
{
    public class RamConcrete2 : RamAbstract
    {
        public override void RamIslem()
        {
            Console.WriteLine("RamConcrete2 birleştirildi.");
        }

        public override string RamTur { 
            
            get
            {
            return "Bu ram türü : RamConcrete2";
            } 
        }
    }
}
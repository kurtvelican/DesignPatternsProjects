using System;

namespace AbstractFactoryHddRamOrnek
{
    public class RamConcrete1 : RamAbstract
    {
        public override void RamIslem()
        {
            Console.WriteLine("RamConcrete1 birleştirildi.");
        }

        public override string RamTur
        {
            get
            {
                return "Bu ram türü : RamConcrete1";
            }
        }
    }
}
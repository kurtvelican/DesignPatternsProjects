using System;

namespace AbstractFactoryHddRamOrnek
{
    public class HddConcrete2 : HddAbstract
    {
        public override void HddIslem()
        {
            Console.WriteLine("HddConcrete2 birleştirildi.");
        }

        public override string HddTur
        {
            get
            {
                return "Bu ram türü : HddConcrete2";
            }
        }
    }
}
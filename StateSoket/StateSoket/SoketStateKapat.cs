using System;

namespace StateSoket
{
    public class SoketStateKapat : ISoketState
    {
        public void Handle(Soket s)
        {
            Console.WriteLine("{0} portuna sahip soket kapandı.", s.Port);
            s.State = new SoketStateAc();
        }
    }
}
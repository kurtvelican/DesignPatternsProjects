using System;

namespace StateSoket
{
    public class SoketStateDinlen : ISoketState
    {
        public void Handle(Soket s)
        {
            Console.WriteLine("{0} portuna sahip soket dinleniyor.", s.Port);
            s.State = new SoketStateKapat();
        }
    }
}
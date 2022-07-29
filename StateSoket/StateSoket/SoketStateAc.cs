using System;

namespace StateSoket
{
    public class SoketStateAc : ISoketState
    {
        public void Handle(Soket s)
        {
            Console.WriteLine("{0} portuna sahip soket açıldı.", s.Port);
            s.State = new SoketStateDinlen();
        }
    }
}
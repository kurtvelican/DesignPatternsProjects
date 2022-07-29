using System;

namespace hayvanlarOdev
{
    public class Kus : IHayvanlar
    {
        public void isimver(string a)
        {
            Console.WriteLine("Kuşun ismi : " + a);
        }

        public void seslendir()
        {
            Console.WriteLine("Kuş sesi");
        }
    }
}
using System;

namespace MailKutusuOdev
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Ayar ayar = Ayar.Nesne();
            
            Console.WriteLine(ayar.Ayarlama(3));
            

        }
    }
}
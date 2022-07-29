using System;

namespace ChainOfResponsibilityMpgAvi
{
    public class Avi : PlayerHandler
    {
        public override void play(string player)
        {
            if (player.EndsWith(".avi"))
            {
                Console.WriteLine("{0} Avi'de çalınıyor." , player);
            }
            else
            {
                Console.WriteLine("Geçersiz dosya formatı.");
            }
        }
    }
}
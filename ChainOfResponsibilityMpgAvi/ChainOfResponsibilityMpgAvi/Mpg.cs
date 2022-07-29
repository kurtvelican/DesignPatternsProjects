using System;

namespace ChainOfResponsibilityMpgAvi
{
    public class Mpg : PlayerHandler
    {
        public override void play(string player)
        {
            if (player.EndsWith(".mpg"))
            {
                Console.WriteLine("{0} Mpg'de çalınıyor." , player);
            }
            else
            {
                if (SonrakiHandler != null)
                {
                    SonrakiHandler.play(player);
                }
            }
        }
    }
}
using System;

namespace ChainOfResponsibilityMpgAvi
{
    public class Mp4 : PlayerHandler
    {
        public override void play(string player)
        {
            if (player.EndsWith(".mp4"))
            {
                Console.WriteLine("{0} Mp4'te çalınıyor." , player);
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
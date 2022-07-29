using System;

namespace BridgeOrnekSarki
{
    public class Spotify
    {
        public string muzikCal(Muzik muzik)
        {
            Console.WriteLine("Spotify " + muzik + " sarkisini caliyor");
            return muzik.Ses;
        }
    }
}
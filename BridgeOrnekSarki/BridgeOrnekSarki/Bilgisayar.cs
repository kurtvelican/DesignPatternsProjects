namespace BridgeOrnekSarki
{
    public class Bilgisayar
    {
        private Spotify spotify;
        private Hoparlor hoparlor;

        public Spotify Spotify
        {
            get => spotify;
            set => spotify = value;
        }

        public Hoparlor Hoparlor
        {
            get => hoparlor;
            set => hoparlor = value;
        }

        public Bilgisayar()
        {
            spotify = new Spotify();
            hoparlor = new Hoparlor();
        }

        public void muzikCal(Muzik muzik)
        {
            string ses = spotify.muzikCal(muzik);
            hoparlor.sesiCal(ses);
        }
        
    }
}
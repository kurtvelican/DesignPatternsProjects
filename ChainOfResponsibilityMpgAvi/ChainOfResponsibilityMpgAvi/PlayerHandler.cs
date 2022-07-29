namespace ChainOfResponsibilityMpgAvi
{
    public abstract class PlayerHandler
    {
        private PlayerHandler _sonrakiHandler;

        public PlayerHandler SonrakiHandler
        {
            get => _sonrakiHandler;
            set => _sonrakiHandler = value;
        }

        public abstract void play(string player);
    }
}
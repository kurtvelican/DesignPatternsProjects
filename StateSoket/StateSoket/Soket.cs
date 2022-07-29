namespace StateSoket
{
    public class Soket
    {
        public int Port { get; set; }

        public Soket(int Port)
        {
            this.Port = Port;
            State = new SoketStateAc(); //açık başlıyor.
        }

        private ISoketState _State;

        public ISoketState State
        {
            get { return _State; }
            set
            {
                _State = value;
            }
        }

        public void Do()
        {
            State.Handle(this);
        }

       
    }
}
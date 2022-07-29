namespace BridgeOrnekSarki
{
    public class Muzik
    {
        private string ad;
        private string ses;

        public Muzik(string ad, string ses)
        {
            this.ad = ad;
            this.ses = ses;
        }

        public string Ad
        {
            get => ad;
            set => ad = value;
        }

        public string Ses
        {
            get => ses;
            set => ses = value;
        }

        public string toString()
        {
            return ad;
        }
    }
}
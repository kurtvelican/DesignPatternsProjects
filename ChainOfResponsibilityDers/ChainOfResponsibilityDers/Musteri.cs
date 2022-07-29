namespace ChainOfResponsibilityDers
{
    public class Musteri
    {
        private int skor;
        private int gecikme;
        private bool kefil;
        private bool maas;

        public Musteri(int skor, int gecikme, bool kefil, bool maas)
        {
            this.skor = skor;
            this.gecikme = gecikme;
            this.kefil = kefil;
            this.maas = maas;
        }

        public int Skor
        {
            get => skor;
            set => skor = value;
        }

        public int Gecikme
        {
            get => gecikme;
            set => gecikme = value;
        }

        public bool Kefil
        {
            get => kefil;
            set => kefil = value;
        }

        public bool Maas
        {
            get => maas;
            set => maas = value;
        }
    }
}
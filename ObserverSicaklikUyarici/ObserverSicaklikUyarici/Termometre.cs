using System;

namespace ObserverSicaklikUyarici
{
    public class Termometre : Observable
    {
        private int anlikSicaklik;
        private int minSicaklik;
        private int maxSicaklik;

        public Termometre(int minSicaklik, int maxSicaklik)
        {
            this.minSicaklik = minSicaklik;
            this.maxSicaklik = maxSicaklik;
            this.anlikSicaklik = 24;
        }

        public int getAnlikSicaklik()
        {
            return anlikSicaklik;
        }

        public void setAnlikSicaklik(int anlikSicaklik)
        {
            this.anlikSicaklik = anlikSicaklik;
            Console.WriteLine(anlikSicaklik);

            sicakligiKontrolEt();
        }

        public void sicakligiKontrolEt()
        {
            bool isCokSicak = anlikSicaklik.CompareTo(maxSicaklik) >= 0;
            bool isCokSoguk = anlikSicaklik.CompareTo(minSicaklik) <= 0;

            if (isCokSicak || isCokSoguk)
            {
                haberVer();
            }
        }
        
    }
}
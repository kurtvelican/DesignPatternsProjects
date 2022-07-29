using System;

namespace ObserverSicaklikUyarici
{
    public class Ebeveyn : Observer
    {
        private string ad;

        public Ebeveyn(string ad)
        {
            this.ad = ad;
        }

        public void update(Observable observable)
        {
            Termometre termometre = (Termometre) observable;

            Console.WriteLine(ad + " dedi ki : sıcaklık " + termometre.getAnlikSicaklik() + " derece olmus");
        }
    }
}
using System;
using System.Collections.Generic;

namespace ObserverDers
{
    public class Urun1 : IUrun
    {
        private string ad;
        private double fiyat;
        private List<IObserver> observerList = new List<IObserver>();

        public Urun1(string ad, double fiyat)
        {
            this.ad = ad;
            this.fiyat = fiyat;
        }

        public string getAd()
        {
            return ad;
        }

        public void setAd(string ad)
        {
            this.ad = ad;
        }
        
        public double getFiyat()
        {
            return fiyat;
        }

        public void setFiyat(double yenifiyat)
        {
            double degisim = Math.Abs((getFiyat() - yenifiyat));
            fiyat = yenifiyat;
            notifyObservers(degisim);
        }

        public void register(IObserver observer)
        {
            observerList.Add(observer);
        }

        public void deregister(IObserver observer)
        {
            observerList.Remove(observer);
        }

        public void notifyObservers(double degisim)
        {
            foreach (var iobserver in observerList)
            {
                iobserver.update(degisim);
            }
        }
    }
}

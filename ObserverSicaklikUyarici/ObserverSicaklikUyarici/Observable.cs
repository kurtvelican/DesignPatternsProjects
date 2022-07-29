using System.Collections.Generic;

namespace ObserverSicaklikUyarici
{
    public abstract class Observable
    {
        private List<Observer> observerList;

        public Observable()
        {
            observerList = new List<Observer>();
        }

        public void ekle(Observer observer)
        {
            observerList.Add(observer);
        }

        public void cikar(Observer observer)
        {
            observerList.Remove(observer);
        }

        public void haberVer()
        {
            foreach (var observer in observerList)
            {
                observer.update(this);
            }
        }
    }
}
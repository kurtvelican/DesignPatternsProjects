using System;
using System.Collections.Generic;

namespace ObserverDers
{
    public class Observer1 : IObserver
    {
        public void update(double degisim)
        {
            Console.WriteLine("Observer 1 Fiyat " + degisim + " tl değişti");
        }
        private List<IUrun> favoriList;

        public Observer1()
        {
            favoriList = new List<IUrun>();
        }

        public void favorilereEkle(IUrun urun)
        {
            favoriList.Add(urun);
            urun.register(this);
        }
    }
}
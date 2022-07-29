using System;
using System.Collections.Generic;

namespace ObserverDers
{
    public class Observer2 : IObserver
    {
        private List<IUrun> favoriList;

        public Observer2()
        {
            favoriList = new List<IUrun>();
        }
        
        public void update(double degisim)
        {
            Console.WriteLine("Observer 2 Fiyat " + degisim + " tl değişti");
        }

        public void favorilereEkle(IUrun urun)
        {
            favoriList.Add(urun);
            urun.register(this);
        }
    }
}
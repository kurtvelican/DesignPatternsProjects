using System;
using System.Collections;

namespace BilgisayarBuilder
{
    public class Bilgisayar
    {
        private string mBilgisayarTipi;
        private System.Collections.Hashtable mParcalar = new System.Collections.Hashtable();

        public Bilgisayar(string BilgisayarTipi)
        {
            mBilgisayarTipi = BilgisayarTipi;
        }

        public object this[string key]
        {
            get
            {
                return mParcalar[key];
            }
            set
            {
                mParcalar[key] = value;
            }
        }

        public void BilgisayariGoster()
        {
            Console.WriteLine("Bilgisayar Tipi : " + mBilgisayarTipi);
            Console.WriteLine("CD-ROM Model : " + mParcalar["cdrom"]);
            Console.WriteLine("Hard Disk Model : " + mParcalar["hdd"]);
            Console.WriteLine("Monitor Model : " + mParcalar["monitor"]);
            Console.WriteLine("Ram Model : " + mParcalar["ram"]);
        }
    }
}
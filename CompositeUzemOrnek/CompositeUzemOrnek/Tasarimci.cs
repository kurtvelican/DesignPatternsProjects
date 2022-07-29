using System;

namespace CompositeUzemOrnek
{
    public class Tasarimci : Calisan
    {
        private int kurumId;
        private string isim;
        private string TasarimciBilgi;

        public Tasarimci(int kurumId, string isim)
        {
            setKurumId(kurumId);
            setIsim(isim);
        }

        public int getKurumId()
        {
            return kurumId;
        }

        public void setKurumId(int kurumId)
        {
            this.kurumId = kurumId;
        }
        
        public string getIsim()
        {
            return isim;
        }

        public void setIsim(string isim)
        {
            this.isim = isim;
        }
        
        public string getTasarimciBilgi()
        {
            return TasarimciBilgi;
        }

        public void setTasarimciBilgi(string TasarimciBilgi)
        {
            this.TasarimciBilgi =TasarimciBilgi;
        }

        public void tasarimYap()
        {
            Console.WriteLine(getIsim() + " " + getTasarimciBilgi());
        }

        public void bilgiGoster()
        {
            Console.WriteLine(getKurumId() + " - " + getIsim());
        }
    }
}
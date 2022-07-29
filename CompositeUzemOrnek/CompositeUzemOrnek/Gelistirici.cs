using System;

namespace CompositeUzemOrnek
{
    public class Gelistirici : Calisan
    {
        private int kurumId;
        private string isim;
        private string GelistiriciBilgi;

        public Gelistirici(int kurumId, string isim)
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
        
        public string getGelistiriciBilgi()
        {
            return GelistiriciBilgi;
        }

        public void setGelistiriciBilgi(string GelistiriciBilgi)
        {
            this.GelistiriciBilgi =GelistiriciBilgi;
        }
        
        public void GelistirmeYap()
        {
            Console.WriteLine(getIsim() + " " + getGelistiriciBilgi());
        }
        
        public void bilgiGoster()
        {
            Console.WriteLine(getKurumId() + " - " + getIsim());
        }
    }
}
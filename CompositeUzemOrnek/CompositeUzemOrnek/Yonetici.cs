using System;

namespace CompositeUzemOrnek
{
    public class Yonetici : Calisan
    {
        private int kurumId;
        private string isim;
        private string YoneticiBilgi;

        public Yonetici(int kurumId, string isim)
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
        
        public string getYoneticiBilgi()
        {
            return YoneticiBilgi;
        }

        public void setYoneticiBilgi(string YoneticiBilgi)
        {
            this.YoneticiBilgi =YoneticiBilgi;
        }
        
        public void YoneticilikYap()
        {
            Console.WriteLine(getIsim() + " " + getYoneticiBilgi());
        }
        
        public void bilgiGoster()
        {
            Console.WriteLine(getKurumId() + " - " + getIsim());
        }
    }
}
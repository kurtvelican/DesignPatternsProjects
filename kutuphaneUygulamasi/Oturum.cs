using System;

namespace kutuphaneUygulamasi
{
    public class Oturum
    {
        public void OturumAc(String ad,String sifre)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.KullaniciAdi1 = ad;
            kullanici.Sifre1 = sifre;
            Console.WriteLine("Giriş Başarılı Sayın " + kullanici.KullaniciAdi1 );            
        }
    }
}
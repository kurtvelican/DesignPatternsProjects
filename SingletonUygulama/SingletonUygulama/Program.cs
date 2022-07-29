using System;

namespace SingletonUygulama
{
  internal class Program
  {
    public static void Main(string[] args)
    {
        /*Singleton2 nesne1 = Singleton2.Dondur();
        Singleton2 nesne2 = Singleton2.Dondur();

        if (nesne1 == nesne2)
        {
            Console.WriteLine("Nesnelerin aynı olduğu görülüyor");
        }*/
        
        YukDengeleyici yd1 = YukDengeleyici.YukDengeleyiciGetir();
        YukDengeleyici yd2 = YukDengeleyici.YukDengeleyiciGetir();
        YukDengeleyici yd3 = YukDengeleyici.YukDengeleyiciGetir();
        YukDengeleyici yd4 = YukDengeleyici.YukDengeleyiciGetir();

        if (yd1 == yd2 && yd2 == yd3 && yd3 == yd4)
        {
            Console.WriteLine("Nesnelerin aynı olduğu görülüyor.\n");
        }
        //Yük dengelemek için 15 sunucu isteği
        YukDengeleyici dengeleyici = YukDengeleyici.YukDengeleyiciGetir();
        
        for (int i = 0; i < 15; i++)
        {
            string server = dengeleyici.Sunucu;
            Console.WriteLine("Şu sunucuya istek gönderildi : " + server);
        }

        Console.ReadKey();
    }
  }
}
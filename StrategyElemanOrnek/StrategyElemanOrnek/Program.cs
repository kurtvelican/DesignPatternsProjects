using System;

namespace StrategyElemanOrnek
{
  internal class Program
  {
    public static void Main(string[] args)
    {

      Eleman eleman = new Eleman(new DepartmanAIzinHesap(),new YoneticiMaasHesap());
      int yoneticiMaas = eleman.maasHesapla();
      int yoneticiIzin = eleman.izinHesapla();

      eleman = new Eleman(new DepartmanBIzinHesap(), new MuhendisMaasHesap());
      int muhendisMaas = eleman.maasHesapla();
      int muhendisIzin = eleman.izinHesapla();

      eleman = new Eleman(new DepartmanBIzinHesap(), new TeknisyenMaasHesap());
      int teknisyenMaas = eleman.maasHesapla();
      int teknisyenIzin = eleman.izinHesapla();

      Console.WriteLine("Yönetici maaşı : " + yoneticiMaas + " Yönetici izni : " + yoneticiIzin);
      Console.WriteLine("Mühendis maaşı : " + muhendisMaas + " Mühendis izni : " + muhendisIzin);
      Console.WriteLine("Teknisyen maaşı : " + teknisyenMaas + " Teknisyen izni : " + teknisyenIzin);
    }
  }
}
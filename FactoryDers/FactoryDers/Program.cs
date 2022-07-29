using System;

namespace FactoryDers
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      /*Dikdortgen dikdortgen = new Dikdortgen();
      Console.WriteLine(dikdortgen.dikdortgenCevreHesapla(2, 4));

      ParalelKenar paralelKenar = new ParalelKenar();
      Console.WriteLine(paralelKenar.paralelKenarCevreHesapla(2, 5));*/

      Fabrika fabrika = new Fabrika();

      /*ICevreHesapla dikdortgen = new Dikdortgen();
      Console.WriteLine(dikdortgen.cevreHesapla(2,5));*/

      /*ICevreHesapla paralelKenar = new ParalelKenar();
      Console.WriteLine(paralelKenar.cevreHesapla(3,6));*/

      ICevreHesapla hesaplayici = fabrika.HesaplayiciDondur("Dikdortgen");
      int cevre = hesaplayici.cevreHesapla(2, 6);
      Console.WriteLine("Cevre = " + cevre);
      Console.ReadKey();
      
    }
  }
}
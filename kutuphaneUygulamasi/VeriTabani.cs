using System;
using System.Runtime.InteropServices;

namespace kutuphaneUygulamasi
{
    public class VeriTabani
    {
        public void BilgiGetir(int id,String ad,int price,int page)
        {

            Console.WriteLine("Veri tabanından gelen bilgiler : ");
            
            Console.WriteLine("Id = " + id);
            Console.WriteLine("Adı = " + ad);
            Console.WriteLine("Fiyatı = " + price);
            Console.WriteLine("Sayfa sayısı = " + page);
        }

        public void Kaydet(String a)
        {
            Console.WriteLine(a + " Veri Tabanına kaydedildi.");
        }
    }
}
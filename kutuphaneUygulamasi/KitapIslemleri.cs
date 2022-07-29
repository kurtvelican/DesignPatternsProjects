using System;

namespace kutuphaneUygulamasi
{
    public class KitapIslemleri : Kitap
    {
        //private Kitap _kitap = new Kitap();

        public void KitapOlustur(int id,String ad,int price,int page)
        {
            this.Id1 = id;
            this.Name1 = ad;
            this.Price1 = price;
            this.Page1 = page;
            
            Console.WriteLine(this.Name1 + " kitabı oluşturuldu.");
        }
    }
}
using System;

namespace kutuphaneUygulamasi
{
    public class DergiIslemleri : Dergi
    {
        //private Dergi _dergi = new Dergi();

        public void DergiOlustur(int id,String ad,int price,int page)
        {
            this.Id1 = id;
            this.Name1 = ad;
            this.Price1 = price;
            this.Page1 = page;
            
            Console.WriteLine(this.Name1 + " dergisi oluşturuldu.");
        }
    }
}
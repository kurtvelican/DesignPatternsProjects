namespace kutuphaneUygulamasi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Oturum oturum = new Oturum();
            oturum.OturumAc("Veli","asfafassa");
            
            KitapIslemleri kitapIslemleri = new KitapIslemleri();
            kitapIslemleri.KitapOlustur(12,"Beyaz Diş",25,300);
            kitapIslemleri.Kaydet(kitapIslemleri.Name1);
            kitapIslemleri.BilgiGetir(kitapIslemleri.Id1,kitapIslemleri.Name1,kitapIslemleri.Price1,kitapIslemleri.Page1);

            DergiIslemleri dergiIslemleri = new DergiIslemleri();
            dergiIslemleri.DergiOlustur(15,"Science",12,30);
            dergiIslemleri.Kaydet(dergiIslemleri.Name1);
            dergiIslemleri.BilgiGetir(dergiIslemleri.Id1,dergiIslemleri.Name1,dergiIslemleri.Price1,dergiIslemleri.Page1);


        }
    }
}
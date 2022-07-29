namespace CompositeDers
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            /*InsanKaynaklari ekip1 = new InsanKaynaklari();
            InsanKaynaklari ekip2 = new InsanKaynaklari();
            InsanKaynaklari ekip3 = new InsanKaynaklari();
            InsanKaynaklari ekip4 = new InsanKaynaklari();
            InsanKaynaklari ekip5 = new InsanKaynaklari();
            
            Yonetici y1 = new Yonetici(1, "yonetici 1");
            Yonetici y11 = new Yonetici(11, "yonetici 1.1");
            Yonetici y3 = new Yonetici(3, "yonetici 3");
            InsanKaynaklari yoneticiler = new InsanKaynaklari();
            yoneticiler.calisanEkle(y1);
            yoneticiler.calisanEkle(y11);
            yoneticiler.calisanEkle(y3);

            Tasarimci t1 = new Tasarimci(10, "tasarimci 1");
            Tasarimci t2 = new Tasarimci(20, "tasarimci 2");
            Tasarimci t3 = new Tasarimci(30, "tasarimci 3");
            InsanKaynaklari tasarimcilar = new InsanKaynaklari();
            tasarimcilar.calisanEkle(t1);
            tasarimcilar.calisanEkle(t2);
            tasarimcilar.calisanEkle(t3);
            
            
            ekip1.calisanEkle(y1);
            ekip2.calisanEkle(y11);
            ekip3.calisanEkle(t1);
            ekip1.calisanEkle(ekip2);
            ekip2.calisanEkle(ekip3);
            ekip4.calisanEkle(y1);
            ekip5.calisanEkle(ekip4);*/

            InsanKaynaklari ekip1 = new InsanKaynaklari(new Yonetici(1,"Veli"));
            Calisan y1 = new Yonetici(2, "Mehmet");
            Calisan t1 = new Tasarimci(3, "Selma");
            ekip1.calisanEkle(y1);
            ekip1.calisanEkle(t1);

            InsanKaynaklari ekip2 = new InsanKaynaklari(new Yonetici(23,"Halit"));
            ekip2.calisanEkle(new Tasarimci(4,"Ali"));
            ekip2.calisanEkle(new Gelistirici(5,"Mustafa"));
            ekip1.calisanEkle(ekip2);

            ekip1.bilgiGoster();
        }
    }
}
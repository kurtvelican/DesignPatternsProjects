namespace CompositeUzemOrnek
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tasarimci t1 = new Tasarimci(101, "Tasarimci Ornek1");
            Tasarimci t2 = new Tasarimci(103, "Tasarimci Ornek2");

            InsanKaynaklari tasarimcilar = new InsanKaynaklari();
            tasarimcilar.calisanEkle(t1);
            tasarimcilar.calisanEkle(t2);

            Gelistirici g1 = new Gelistirici(202, "Gelistirici Ornek1");
            Gelistirici g2 = new Gelistirici(204, "Gelistirici Ornek2");
            
            InsanKaynaklari gelistiriciler = new InsanKaynaklari();
            gelistiriciler.calisanEkle(g1);
            gelistiriciler.calisanEkle(g2);

            Yonetici y1 = new Yonetici(505, "Yonetici Ornek1");
            Yonetici y2 = new Yonetici(506, "Yonetici Ornek2");

            InsanKaynaklari yoneticiler = new InsanKaynaklari();
            yoneticiler.calisanEkle(y1);
            yoneticiler.calisanEkle(y2);

            InsanKaynaklari calisanlar = new InsanKaynaklari();
            calisanlar.calisanEkle(tasarimcilar);
            calisanlar.calisanEkle(gelistiriciler);
            calisanlar.calisanEkle(yoneticiler);
            
            /*tasarimcilar.bilgiGoster();
            gelistiriciler.bilgiGoster();
            yoneticiler.bilgiGoster();*/
            
            calisanlar.bilgiGoster();
        }
    }
}
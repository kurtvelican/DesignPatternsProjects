namespace ObserverDers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IObserver observer1 = new Observer1();
            Urun1 urun1 = new Urun1("ayakkabi", 100);
            IObserver observer2 = new Observer2();
            Urun2 urun2 = new Urun2("bilgisayar", 10000);
            urun1.register(observer1);
            urun2.register(observer1);
            urun2.register(observer2);
            urun2.deregister(observer1);
            urun1.register(observer2);
            urun1.setFiyat(80);
            
            urun2.setFiyat(15000);
            observer2.favorilereEkle(urun2);
            
            urun2.setFiyat(12000);
            
            observer1.favorilereEkle(urun1);
            urun1.setFiyat(120);
            
        }
    }
}
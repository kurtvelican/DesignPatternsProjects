namespace AdapterDers
{
    public class UzakHedefAdaptor : IYedekleyici
    {
        private string domain = "192.168.1.1";
        public void Kaydet(string kaynak, string hedef)
        {
            //...Burası...
            UzakHedefeKayit uzakHedefeKayit = new UzakHedefeKayit();
            uzakHedefeKayit.UzakHedefeKaydet(domain,hedef,kaynak);

        }
    }
}
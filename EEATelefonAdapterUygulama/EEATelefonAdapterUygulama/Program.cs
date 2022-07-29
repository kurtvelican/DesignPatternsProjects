namespace EEATelefonAdapterUygulama
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Priz priz = new Priz();
            Utu utu = new Utu();
            Buzdolabi buzdolabi = new Buzdolabi();
            
            priz.elektrikver(utu);
            priz.elektrikver(buzdolabi);
            
            SamsungTelefon samsungTelefon = new SamsungTelefon();
            TelefonEEAAdapter telefonEeaAdapter = new TelefonEEAAdapter(samsungTelefon);
            
            priz.elektrikver(telefonEeaAdapter);
        }
    }
}
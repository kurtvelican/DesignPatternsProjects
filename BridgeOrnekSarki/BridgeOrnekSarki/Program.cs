namespace BridgeOrnekSarki
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Muzik muzik = new Muzik("Sezen Aksu", "Yetinmeyi bilir misin?");

            Bilgisayar bilgisayar = new Bilgisayar();
            
            bilgisayar.muzikCal(muzik);
        }
    }
}
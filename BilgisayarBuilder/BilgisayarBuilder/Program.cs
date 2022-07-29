namespace BilgisayarBuilder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            TeknikServis teknikServis = new TeknikServis();

            IBilgisayarToplayicisi pc1 = new GoldPC();
            IBilgisayarToplayicisi pc2 = new SilverPC();
            
            teknikServis.BilgisayarTopla(pc1);
            teknikServis.BilgisayarTopla(pc2);
            
            pc1.Bilgisayar.BilgisayariGoster();
            pc2.Bilgisayar.BilgisayariGoster();
        }
    }
}
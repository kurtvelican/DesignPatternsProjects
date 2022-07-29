namespace ArabaUygulama
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SoyutArabaFabrikasi fabrika1 = new MercedesFabrikasi();
            FabrikaOtomasyon fo1 = new FabrikaOtomasyon(fabrika1);
            fo1.LastikTak();

            SoyutArabaFabrikasi fabrika2 = new FordFabrikasi();
            FabrikaOtomasyon fo2 = new FabrikaOtomasyon(fabrika2);
            fo2.LastikTak();
        }
    }
}
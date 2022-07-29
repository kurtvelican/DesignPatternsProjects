namespace ObserverSicaklikUyarici
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int minSicaklik = 23;
            int maxSicaklik = 28;

            Termometre termometre = new Termometre(minSicaklik, maxSicaklik);

            Ebeveyn anne = new Ebeveyn("Anne");
            Ebeveyn baba = new Ebeveyn("Baba");

            termometre.ekle(anne);
            termometre.ekle(baba);
            termometre.cikar(baba);

            for (int i = termometre.getAnlikSicaklik(); i <= 30; i++)
            {
                termometre.setAnlikSicaklik(i);
            }
            
            for (int i = termometre.getAnlikSicaklik(); i >= 22; i--)
            {
                termometre.setAnlikSicaklik(i);
            }
            
        }
    }
}
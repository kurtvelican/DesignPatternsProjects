namespace ArabaUygulama
{
    public class MercedesFabrikasi : SoyutArabaFabrikasi
    {
        public override SoyutArabaKasasi KasaUret()
        {
            return new MercedesE200();
        }

        public override SoyutArabaLastigi LastikUret()
        {
            return new MercedesLastik();
        }
    }
}
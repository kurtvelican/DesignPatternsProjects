namespace ArabaUygulama
{
    public class FordFabrikasi : SoyutArabaFabrikasi
    {
        public override SoyutArabaKasasi KasaUret()
        {
            return new FordFocus();
        }

        public override SoyutArabaLastigi LastikUret()
        {
            return new FordLastik();
        }
    }
}
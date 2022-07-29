namespace ArabaUygulama
{
    public class FabrikaOtomasyon
    {
        private SoyutArabaKasasi ArabaKasasi;
        private SoyutArabaLastigi ArabaLastigi;

        public FabrikaOtomasyon(SoyutArabaFabrikasi fabrika)
        {
            ArabaKasasi = fabrika.KasaUret();
            ArabaLastigi = fabrika.LastikUret();
        }

        public void LastikTak()
        {
            ArabaKasasi.LastikTak(ArabaLastigi);
        }
    }
}
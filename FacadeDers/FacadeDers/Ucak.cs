namespace FacadeDers
{
    public class Ucak
    {
        private string baslangicKonumu;
        private string hedefKonum;
        private string sinif;

        public void Ucus(string baslangicKonumu, string hedefKonum, string sinif)
        {
            this.baslangicKonumu = baslangicKonumu;
            this.hedefKonum = hedefKonum;
            this.sinif = sinif;
        }
    }
}
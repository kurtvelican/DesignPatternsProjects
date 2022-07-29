namespace FacadeDers
{
    public class Facade
    {
        private Ucak ucak;
        private Otel otel;
        private Taksi taksi;
        
        public void Rezervasyon(string baslangicKonumu,string hedefKonum,string sinif)
        {
            ucak = new Ucak();
            otel = new Otel();
            taksi = new Taksi();
            ucak.Ucus(baslangicKonumu,hedefKonum,sinif);
            otel.OtelRezervasyon(hedefKonum,sinif);
            taksi.TaksiCagir(sinif);
        }
    }
}
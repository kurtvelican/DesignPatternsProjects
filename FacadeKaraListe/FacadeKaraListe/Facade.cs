namespace FacadeKaraListe
{
    public class Facade
    {
        private Sistem1Kontrol sistem1Kontrol;
        private Sistem2Operations sistem2Operations;
        private TCKimlikSistem tcKimlikSistem;

        public void Sistem2UyeEkle(string Tc)
        {
            if (tcKimlikSistem.Kontrol(Tc) && !sistem1Kontrol.KaraListeKontrol(Tc))
            {
                sistem2Operations.UyeEkle(Tc);
            }
        }
    }
}
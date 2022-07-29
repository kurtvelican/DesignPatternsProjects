namespace StrategyElemanOrnek
{
    public class Eleman
    {
        private IzinHesap izinHesap;
        private MaasHesap maasHesap;

        public Eleman(IzinHesap izinHesap, MaasHesap maasHesap)
        {
            this.izinHesap = izinHesap;
            this.maasHesap = maasHesap;
        }

        public int izinHesapla()
        {
            return izinHesap.izinHesapla();
        }

        public int maasHesapla()
        {
            return maasHesap.maasHesapla();
        }
        
    }
}
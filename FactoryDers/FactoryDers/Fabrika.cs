namespace FactoryDers
{
    public class Fabrika
    {
        public ICevreHesapla HesaplayiciDondur(string st)
        {
            if (st == "Dikdortgen")
            {
                ICevreHesapla nesne = new Dikdortgen();
                return nesne;
            }
            else
            {
                ICevreHesapla nesne = new ParalelKenar();
                return nesne;
            }
        }
    }
}
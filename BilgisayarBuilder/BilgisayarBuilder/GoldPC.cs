namespace BilgisayarBuilder
{
    public class GoldPC : IBilgisayarToplayicisi
    {
        private Bilgisayar mBilgisayar;
        public Bilgisayar Bilgisayar
        {
            get { return mBilgisayar; }
        }

        public GoldPC()
        {
            mBilgisayar = new Bilgisayar("Gold PC");
        }
        
        public void CDROM_Olustur()
        {
            mBilgisayar["cdrom"] = "52X GoldStar";
        }

        public void HDD_Olustur()
        {
            mBilgisayar["hdd"] = "60 Gb Seagate";
        }

        public void Monitor_Olustur()
        {
            mBilgisayar["monitor"] = "17' AOC";
        }

        public void RAM_Olustur()
        {
            mBilgisayar["ram"] = "8 Gb Kioxia";
        }
    }
}
namespace BilgisayarBuilder
{
    public class SilverPC : IBilgisayarToplayicisi
    {
        private Bilgisayar mBilgisayar;
        public Bilgisayar Bilgisayar
        {
            get { return mBilgisayar; }
        }

        public SilverPC()
        {
            mBilgisayar = new Bilgisayar("Gold PC");
        }
        
        public void CDROM_Olustur()
        {
            mBilgisayar["cdrom"] = "48X SilverStar";
        }

        public void HDD_Olustur()
        {
            mBilgisayar["hdd"] = "30 Gb Maxtor";
        }

        public void Monitor_Olustur()
        {
            mBilgisayar["monitor"] = "15' Vestel";
        }

        public void RAM_Olustur()
        {
            mBilgisayar["ram"] = "4 Gb Kingston";
        }
    }
}
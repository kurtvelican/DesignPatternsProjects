namespace BilgisayarBuilder
{
    public class TeknikServis
    {
        public void BilgisayarTopla(IBilgisayarToplayicisi bilgisayarToplayicisi)
        {
            bilgisayarToplayicisi.CDROM_Olustur();
            bilgisayarToplayicisi.HDD_Olustur();
            bilgisayarToplayicisi.Monitor_Olustur();
            bilgisayarToplayicisi.RAM_Olustur();
        }
    }
}
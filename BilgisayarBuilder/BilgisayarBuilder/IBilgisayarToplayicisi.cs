namespace BilgisayarBuilder
{
    public interface IBilgisayarToplayicisi
    {
        Bilgisayar Bilgisayar { get; }

        void CDROM_Olustur();
        void HDD_Olustur();
        void Monitor_Olustur();
        void RAM_Olustur();
    }
}
namespace FactoryVeriOkuYazDers
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            OkumaFabrikasi okumaFabrikasi = new OkumaFabrikasi();
            YazmaFabrikasi yazmaFabrikasi = new YazmaFabrikasi();

            okumaFabrikasi.OkumaTuru("XLSX").veriOku();

            yazmaFabrikasi.YazmaTuru("XML").veriYaz();
            

        }
    }
}
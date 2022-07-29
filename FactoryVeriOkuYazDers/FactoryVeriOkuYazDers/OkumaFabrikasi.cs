namespace FactoryVeriOkuYazDers
{
    public class OkumaFabrikasi
    {
        public VeriOku OkumaTuru(string st)
        {
            if (st == "XLSX")
            {
                return new XLSX();
            }
            else
            {
                return new ODS();
            }
        }
    }
}
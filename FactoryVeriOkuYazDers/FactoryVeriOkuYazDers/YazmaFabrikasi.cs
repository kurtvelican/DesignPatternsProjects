namespace FactoryVeriOkuYazDers
{
    public class YazmaFabrikasi
    {
        public VeriYaz YazmaTuru(string st)
        {
            if (st == "XML")
            {
                return new XML();
            }
            else
            {
                return new JSON();
            }
        }
    }
}
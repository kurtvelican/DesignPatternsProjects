namespace FactoryZipDers
{
    public class Fabrika
    {
        public Compressing CompressorDondur(string st)
        {
            if (st == "Zip")
            {
                Compressing zip = new Zip();
                return zip;
            }
            else if (st == "Rar")
            {
                Compressing rar = new Rar();
                return rar;
            }
            else
            {
                Compressing tar = new Tar();
                return tar;
            }
        }
    }
}
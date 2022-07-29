namespace FactoryZipDers
{
  internal class Program
  {
    public static void Main(string[] args)
    {

      Fabrika fabrika = new Fabrika();

      Compressing compressor = fabrika.CompressorDondur("Zip");
      compressor.CompressThis();

      Compressing compressor2 = fabrika.CompressorDondur("Rar");
      compressor2.CompressThis();

      Compressing compressor3 = fabrika.CompressorDondur("Tar");
      compressor3.CompressThis();
      
      fabrika.CompressorDondur("Zip").CompressThis();
      fabrika.CompressorDondur("Rar").CompressThis();
      fabrika.CompressorDondur("Tar").CompressThis();
      //Compressor nesnesi üretmeden direkt fabrika üzerinden işlemi gerçekleştirdik.
    }
  }
}
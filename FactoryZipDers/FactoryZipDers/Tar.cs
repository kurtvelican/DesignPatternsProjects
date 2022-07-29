using System;

namespace FactoryZipDers
{
    public class Tar : Compressing
    {
        public void CompressThis()
        {
            Console.WriteLine("Oluşturulan dosya tipi \".tar\"");
        }
    }
}
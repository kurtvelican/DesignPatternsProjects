using System;

namespace FactoryZipDers
{
    public class Zip : Compressing
    {
        public void CompressThis()
        {
            Console.WriteLine("Oluşturulan dosya tipi \".zip\"");
        }
    }
}
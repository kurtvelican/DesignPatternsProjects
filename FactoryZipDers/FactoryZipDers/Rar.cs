using System;

namespace FactoryZipDers
{
    public class Rar : Compressing
    {
        public void CompressThis()
        {
            Console.WriteLine("Oluşturulan dosya tipi \".rar\"");
        }
    }
}
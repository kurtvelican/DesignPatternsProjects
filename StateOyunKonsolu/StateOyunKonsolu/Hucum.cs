using System;

namespace StateOyunKonsolu
{
    public class Hucum : IKonsol
    {
        public void kareBas()
        {
            Console.WriteLine("Şut çekiliyor.");
        }

        public void ucgenBas()
        {
            Console.WriteLine("Ara pası veriliyor.");
        }

        public void yuvarlakBas()
        {
            Console.WriteLine("Orta açılıyor.");
        }

        public void xBas()
        {
            Console.WriteLine("Kısa pas veriliyor.");
        }
    }
}
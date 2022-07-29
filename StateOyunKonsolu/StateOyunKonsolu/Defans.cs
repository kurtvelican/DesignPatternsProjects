using System;

namespace StateOyunKonsolu
{
    public class Defans : IKonsol
    {
        public void kareBas()
        {
            Console.WriteLine("Müdahale ediliyor.");
        }

        public void ucgenBas()
        {
            Console.WriteLine("Kaleci açılıyor.");
        }

        public void yuvarlakBas()
        {
            Console.WriteLine("Kayarak mühadale ediliyor.");
        }

        public void xBas()
        {
            Console.WriteLine("Markaj uygulanıyor.");
        }
    }
}
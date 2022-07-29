using System;

namespace StateOyunKonsolu
{
    public class Oyun
    {
        private IKonsol konsol; //state

        public Oyun()
        {
            Console.WriteLine("Oyun başladı.");

            konsol = new Hucum();
        }

        public void ucgen()
        {
            konsol.ucgenBas();
        }

        public void kare()
        {
            konsol.kareBas();
        }

        public void x()
        {
            konsol.xBas();
        }

        public void yuvarlak()
        {
            konsol.yuvarlakBas();
        }

        public void topKapildi() //hücum durumunun gerçekleştiği yer.
        {
            Console.WriteLine("Top kapıldı. Hücuma çıkılıyor.");
            konsol = new Hucum();
        }

        public void topKaptirildi() //defans durumunun gerçekleştiği yer.
        {
            Console.WriteLine("Top kaptırıldı. Defansa geçiliyor.");
            konsol = new Defans();
        }
    }
}
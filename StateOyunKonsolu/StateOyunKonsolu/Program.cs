namespace StateOyunKonsolu
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Oyun oyun = new Oyun();
            
            //hücum kısmı
            oyun.x();
            oyun.ucgen();
            oyun.kare();
            oyun.topKaptirildi(); // durum değişikliği
            
            //defans kısmı
            
            oyun.x();
            oyun.kare();
            oyun.topKapildi(); // durum değişikliği
        }
    }
}
namespace BridgeDers
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Nesne kagit = new Kagit(new Beyaz(),new Kare());
            Nesne kutu = new Kutu(new Kirmizi(),new Daire());

            kagit.olustur();
            kutu.olustur();

            Nesne kagit2 = new Kagit(new Kare());
            kagit2.olustur();

            Nesne kutu2 = new Kutu(new Daire());
            kutu2.olustur();
            
        }
    }
}
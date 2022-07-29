namespace StateSoket
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Soket soket = new Soket(8080);
            soket.Do();
            soket.Do();
            soket.Do();
        }
    }
}
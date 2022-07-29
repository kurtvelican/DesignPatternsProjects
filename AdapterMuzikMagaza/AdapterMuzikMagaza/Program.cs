namespace AdapterMuzikMagaza
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MagazaSatis magazaSatis = new GitarSiparis();
            MagazaSatis magazaSatis2 = new Adapter();
            magazaSatis.Siparis();  //gitar 
            magazaSatis2.Siparis(); //kemence
        }
    }
}
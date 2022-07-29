namespace hayvanlarOdev
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Kus kus = new Kus();
            kus.isimver("Rick");
            kus.seslendir();

            Kedi kedi = new Kedi();
            kedi.isimver("Şerafettin");
            kedi.seslendir();

            Kopek kopek = new Kopek();
            kopek.isimver("Douglas");
            kopek.seslendir();
        }
    }
}
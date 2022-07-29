namespace FacadeDers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.Rezervasyon("istanbul","trabzon","business");
        }
    }
}
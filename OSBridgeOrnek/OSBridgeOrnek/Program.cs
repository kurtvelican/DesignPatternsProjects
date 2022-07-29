namespace OSBridgeOrnek
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            UI win = new WindowsUI(new Dark());
            UI lin = new LinuxUI(new Light());
            
            win.olustur();
            lin.olustur();
        }
    }
}
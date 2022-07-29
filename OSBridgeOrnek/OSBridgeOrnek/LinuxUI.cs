using System;

namespace OSBridgeOrnek
{
    public class LinuxUI : UI
    {
        private Color color;

        public LinuxUI(Color c)
        {
            color = c;
        }
        
        public void olustur()
        {
            Console.WriteLine("Linux UI " + color.renkGetir() + "rengindedir.");
        }
    }
}
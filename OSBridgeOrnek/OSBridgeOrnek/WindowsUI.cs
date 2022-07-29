using System;

namespace OSBridgeOrnek
{
    public class WindowsUI : UI
    {

        private Color color;

        public WindowsUI(Color c)
        {
            color = c;
        }
        public void olustur()
        {
            Console.WriteLine("Windows UI " + color.renkGetir() + "rengindedir.");
        }
    }
}
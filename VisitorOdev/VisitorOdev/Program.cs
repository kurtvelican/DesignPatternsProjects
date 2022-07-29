using System;

namespace VisitorOdev
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Elektronik c1 = new Bilgisayar("Bilgisayar");
            Elektronik c2 = new Tablet("Tablet");

            Yazici y1 = new Hp("Hp");
            Yazici y2 = new Canon("Canon");
            
            c1.visit(y1);
            y1.accept(c1);
            
            c2.visit(y2);
            y2.accept(c2);
            
        }
    }
}
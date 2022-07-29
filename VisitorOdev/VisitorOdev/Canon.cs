using System;

namespace VisitorOdev
{
    public class Canon : Yazici
    {
        public Canon(string isim) : base(isim)
        {
        }

        public override void accept(Elektronik elektronik)
        {
            Console.WriteLine(elektronik.CihazIsmi + " cihazı " + this.YaziciIsmi + " yazıcı tarafından kabul edildi.");
        }
    }
}
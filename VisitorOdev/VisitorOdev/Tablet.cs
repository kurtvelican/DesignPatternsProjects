using System;

namespace VisitorOdev
{
    public class Tablet : Elektronik
    {
        public Tablet(string cihazIsmi) : base(cihazIsmi)
        {
        }

        public override void visit(Yazici yazici)
        {
            Console.WriteLine(yazici.YaziciIsmi + " markalı yazıcı " + this.CihazIsmi +" tarafından ziyaret edildi.");
        }
    }
}
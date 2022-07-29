using System;

namespace ArabaUygulama
{
    public class FordFocus : SoyutArabaKasasi
    {
        public override void LastikTak(SoyutArabaLastigi lastik)
        {
            Console.WriteLine(lastik + " lastikli FordFocus");
        }
    }
}
using System;

namespace ArabaUygulama
{
    public class MercedesE200 : SoyutArabaKasasi
    {
        public override void LastikTak(SoyutArabaLastigi lastik)
        {
            Console.WriteLine(lastik + " lastikli MercedesE200");
        }
    }
}
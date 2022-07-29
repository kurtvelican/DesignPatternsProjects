using System;

namespace AkilliEvSistemiFacade
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Klima klima = new Klima();
            Kapi kapi = new Kapi();
            İsik isik = new İsik(5);
            Televizyon televizyon = new Televizyon();
            
            klima.guncelle(24);
            kapi.kilitle();
            isik.ac(2);
            televizyon.ac();
            
            
            //Sinema Modu
            
            televizyon.ac();
            televizyon.sesArtir();
            for (int i = 0; i < 5; i++)
            {
                isik.kapat(i);
            }*/
            
            
            AkilliEvSistemi akilliEvSistemi = new AkilliEvSistemi(5);
            akilliEvSistemi.klimaGuncelle(24);
            akilliEvSistemi.kapiKilitle();
            akilliEvSistemi.isikAc(2);
            akilliEvSistemi.televizyonAc();
            
            //Sinema Modu Facade ile
            akilliEvSistemi.sinemaModu();
        }
    }
}
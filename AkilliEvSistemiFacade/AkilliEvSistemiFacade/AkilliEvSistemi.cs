using System;

namespace AkilliEvSistemiFacade
{
    public class AkilliEvSistemi
    {
        private Klima klima;
        private Kapi kapi;
        private İsik isik;
        private Televizyon televizyon;

        public AkilliEvSistemi(int adet)
        {
            klima = new Klima();
            kapi = new Kapi();
            isik = new İsik(adet);
            televizyon = new Televizyon();
        }
        
        //Klima
        public void klimaGuncelle(int sicaklik)
        {
           klima.guncelle(sicaklik);
        }

        public void klimaAc()
        {
            klima.ac();
        }

        public void klimaKapat()
        {
            klima.kapat();
        }
        
        //Kapi
        
        public void kapiKilitle()
        {
            kapi.kilitle();
        }

        public void kapiKilidiAc()
        {
            kapi.kilidiAc();
        }
        
        //İsik
        
        public void isikAc(int numara)
        {
            isik.ac(numara);
        }

        public void isikKapat(int numara)
        {
            isik.kapat(numara);
        }
        
        //Televizyon
        
        public void televizyonAc()
        {
            televizyon.ac();
        }

        public void televizyonKapat()
        {
            televizyon.kapat();
        }

        public void televizyonSesAzalt()
        {
            televizyon.sesAzalt();
        }

        public void televizonSesArtir()
        {
            televizyon.sesArtir();  
        }

        public void televizyonKanalAzalt()
        {
            televizyon.kanalAzalt();
        }
        
        public void televizyonKanalArtir()
        {
            televizyon.kanalArtir();
        }

        public void sinemaModu()
        {
            televizyon.ac();
            televizyon.sesArtir();
            for (int i = 0; i < 5; i++)
            {
                isik.kapat(i);
            }
        }
    }
}
using System;
using System.Collections.Generic;

namespace CompositeDers
{
    public class InsanKaynaklari : Calisan
    {
        private List<Calisan> calisanListe;

        public InsanKaynaklari(Calisan calisan)
        {
            calisanListe = new List<Calisan>();
        }

        public void calisanEkle(Calisan calisan)
        {
            calisanListe.Add(calisan);
        }

        public void calisanCikar(Calisan calisan)
        {
            calisanListe.Remove(calisan);
        }

        public void bilgiGoster()
        {
            foreach (var calisan in calisanListe)
            {
                calisan.bilgiGoster();
            }
        }
    }
}
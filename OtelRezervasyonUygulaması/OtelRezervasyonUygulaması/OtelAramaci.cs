using System;
using System.Collections.Generic;
using System.Linq;

namespace OtelRezervasyonUygulaması
{
    public class OtelAramaci
    {
        private Tedarikci1 tedarikci1 = new Tedarikci1();
        private Tedarikci2 tedarikci2 = new Tedarikci2();
        private List<Otel> oteller;
        public List<Otel> OtelAra(String sehirAdi,DateTime baslangicTarihi,DateTime bitisTarihi,int kisiSayisi)
        {
            oteller = new List<Otel>();
            oteller.AddRange(tedarikci1.OtelAra(sehirAdi,baslangicTarihi,bitisTarihi,kisiSayisi));
            oteller.AddRange(tedarikci2.OtelAra(sehirAdi,baslangicTarihi,bitisTarihi,kisiSayisi));
            oteller = oteller.GroupBy(i => i.OtelAdi1).Select(i => new Otel()
            {
                OtelAdi1 = i.Key,
                Ucret1 = i.Min(j=>j.Ucret1),
                TedarikciId1 = i.Min(j=>j.TedarikciId1)
            }).ToList();
            return oteller;
        }
    }
}
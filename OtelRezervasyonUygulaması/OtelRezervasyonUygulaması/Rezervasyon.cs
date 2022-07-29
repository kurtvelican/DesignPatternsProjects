using System;

namespace OtelRezervasyonUygulaması
{
    public class Rezervasyon
    {
        public int RezervasyonId { get; set; }
        public Otel OtelAdi { get; set; }
        public DateTime baslangicTarihi { get; set; }
        public DateTime bitisTarihi { get; set; }
        public int kisiSayisi { get; set; }
    }
}
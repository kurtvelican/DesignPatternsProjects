using System;

namespace OtelRezervasyonUygulaması
{
    public class Otel
    {
        private String OtelAdi;
        private int TedarikciId;
        private int Ucret;

        public string OtelAdi1
        {
            get => OtelAdi;
            set => OtelAdi = value;
        }

        public int TedarikciId1
        {
            get => TedarikciId;
            set => TedarikciId = value;
        }

        public int Ucret1
        {
            get => Ucret;
            set => Ucret = value;
        }
    }
}
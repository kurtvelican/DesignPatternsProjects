using System;

namespace EEATelefonAdapterUygulama
{
    public class SamsungTelefon : Telefon
    {
        private int calismaVoltaji;

        public SamsungTelefon()
        {
            this.calismaVoltaji = 5;
        }

        public int sarjEt()
        {
            Console.WriteLine("Samsung telefon çalışıyor");
            return calismaVoltaji;
        }
    }
}
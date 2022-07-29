namespace EEATelefonAdapterUygulama
{
    public class TelefonEEAAdapter : ElektrikliEvAletleri
    {
        private Telefon telefon;

        public TelefonEEAAdapter(Telefon telefon)
        {
            this.telefon = telefon;
        }

        public int prizeTakVeCalistir()
        {
            return telefon.sarjEt();
        }
    }
}
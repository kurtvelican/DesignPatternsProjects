namespace AdapterDikdortgenKare
{
    public class Adapter : IAlanHesapla
    {
        private int x;
        public void setKenar(int x)
        {
            this.x = x;
        }
        
        private Kare kare = new Kare();
        public int alanHesapla()
        {
            return kare.kareAlaniHesapla(x);
        }
    }
}
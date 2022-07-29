namespace AdapterDikdortgenKare
{
    public class Dikdortgen : IAlanHesapla
    {
        private int x, y;
        
        public void setKenar(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public int alanHesapla()
        {
            return x * y;
        }
    }
}
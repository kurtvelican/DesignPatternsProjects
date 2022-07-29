namespace AdapterMuzikMagaza
{
    public class Adapter : MagazaSatis
    {
        private KemenceSiparis _kemenceSiparis = new KemenceSiparis();
        
        public void Siparis()
        {
            _kemenceSiparis.kemenceSiparis();
        }
    }
}
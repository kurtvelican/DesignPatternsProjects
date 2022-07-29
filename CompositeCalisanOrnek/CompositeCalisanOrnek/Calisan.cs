namespace CompositeCalisanOrnek
{
    public abstract class Calisan
    {
        public string Ad;
        public enPozisyon Pozisyon;

        protected Calisan(string ad, enPozisyon pozisyon)
        {
            Ad = ad;
            Pozisyon = pozisyon;
        }

        public abstract void Goster();
    }
}
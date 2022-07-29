namespace CompositeCalisanOrnek
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CompositeCalisan GenelMudur = new CompositeCalisan("Veli", enPozisyon.GenelMudur);

            CompositeCalisan Mudur = new CompositeCalisan("Ali", enPozisyon.Mudur);

            CompositeCalisan DepartmanSorumlusu = new CompositeCalisan("Mehmet", enPozisyon.DepartmanSorumlusu);
            DepartmanSorumlusu.Ekle(new LeafCalisan("Mert",enPozisyon.Isci));
            DepartmanSorumlusu.Ekle(new LeafCalisan("Adem",enPozisyon.Isci));
            
            Mudur.Ekle(DepartmanSorumlusu);
            Mudur.Ekle(new LeafCalisan("Ayşe",enPozisyon.Isci));
            
            GenelMudur.Ekle(Mudur);
            GenelMudur.Goster();


        }
    }
}
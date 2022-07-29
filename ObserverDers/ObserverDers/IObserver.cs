namespace ObserverDers
{
    public interface IObserver
    {
        void update(double degisim);

        void favorilereEkle(IUrun urun);
    }
}
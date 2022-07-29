namespace ObserverDers
{
    public interface IUrun
    {
        void register(IObserver observer);
        void deregister(IObserver observer);
        void notifyObservers(double degisim);
    }
}